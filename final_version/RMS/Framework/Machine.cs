using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMS.Framework.Instructions;

namespace RMS.Framework
{
    internal class Machine
    {
        private readonly int[] _tape;
        private readonly List<Instruction> _instructions = new List<Instruction>();
        private int _currentLine;

        public string LastInstruction { get; private set; }

        public Machine(int size)
        {
            _tape = new int[size];
        }

        public void AddInstruction(Instruction i)
        {
            if (i == null) return;
            i.Line = _instructions.Count;
            _instructions.Add(i);
        }

        public void InsertInput(int[] input)
        {
            if (input.Length > _tape.Length)
                throw new ArgumentOutOfRangeException();

            for (var i = 0; i < input.Length; i++)
                _tape[i] = input[i];
        }

        public bool RunOneInstruction()
        {
            // current_line = -1 when the machine encountered HALT instruction
            if (_currentLine == -1)
                return false;
            // if no Halt and no infinite loops, will eventually throw ArgumentOutOfRangeException 
            var instruction = _instructions.ElementAt(_currentLine);
            LastInstruction = instruction.ToString();
            _currentLine = instruction.Run(_tape);
            return true;
        }

        public int[] GetTape()
        {
            return _tape;
        }

        public void RunUntilHalt()
        {
            while (RunOneInstruction()) {}
        }

        public string GetInstructionsString()
        {
            if (_instructions.Count == 0)
                return "empty";

            var output = new StringBuilder();
            _instructions.ForEach( i => output.AppendLine(i.ToString()));    
            return output.ToString();
        }

        public static Machine GetSampleMachine()
        {
            var machine = new Machine(6);

            Instruction i0 = new AddInstruction();
            i0.SetParameters(new List<int> { 2, 3, 0 }); // M2 = 0 + M0
            machine.AddInstruction(i0);

            Instruction i1 = new AssignValueInstruction();
            i1.SetParameters(new List<int> { 4, 1 }); //M4 = 1
            machine.AddInstruction(i1);

            Instruction i2 = new GotoIfInstruction();
            i2.SetParameters(new List<int> { 5, 2 }); // goto 5 if M2 > 0
            machine.AddInstruction(i2);

            Instruction i3 = new AddInstruction();
            i3.SetParameters(new List<int> { 0, 3, 5 }); // M0 = M3 + 5
            machine.AddInstruction(i3);

            Instruction i4 = new HaltInstruction();
            machine.AddInstruction(i4); //halt

            Instruction i5 = new AddInstruction();
            i5.SetParameters(new List<int> { 3, 3, 1 }); // M3 = M3 + M1
            machine.AddInstruction(i5);

            Instruction i6 = new SubstractInstruction();
            i6.SetParameters(new List<int> { 2, 2, 4 }); // M2 = M2 - 1
            machine.AddInstruction(i6);

            Instruction i7 = new GotoIfInstruction();
            i7.SetParameters(new List<int> { 2, 4 }); // goto 2 if M4 > 0
            machine.AddInstruction(i7);

            int[] input = { 5, 6 };
            machine.InsertInput(input);

            // when machine halts result will be in M0
            return machine;
        }
    }
}
