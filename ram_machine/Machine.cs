using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ram_machine.Instructions;

namespace ram_machine
{
    class Machine
    {
        private int[] tape;
        private List<Instruction> instructions;
        private int current_line;
        public Machine(int size)
        {
            tape = new int[size];
            for (int i = 0; i < size; ++i)
            {
                tape[i] = 0;
            }
            instructions = new List<Instruction>();
            current_line = 0;
        }

        public void addInstruction(Instruction i)
        {
            i.setLine(instructions.Count);
            instructions.Add(i);
        }

        public void insertInput(int[] input)
        {
            if (input.Length > tape.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0; i < input.Length; ++i)
            {
                tape[i] = input[i];
            }
        }

        public int[] getTape()
        {
            return this.tape;
        }

        public Boolean runOneInstruction()
        {
            // current_line = -1 when the machine encountered HALT instruction
            if (current_line == -1)
            {
                return false;
            }
            // if no Halt and no infinite loops, will eventually throw ArgumentOutOfRangeException 
            Instruction current = instructions.ElementAt(current_line);
            current_line = current.run(tape);
            return true;
        }

        public void runUntilHalt()
        {
            while (runOneInstruction()) ;
        }

        public String getInstructionsString()
        {
            String tmp = "";
            foreach (Instruction i in instructions) 
            {
                tmp += i.ToString() + "\n";
            }
            if (instructions.Count == 0)
            {
                tmp = "empty";
            }
            return tmp;
        }

        public static Machine getSampleMachine()
        {
            Machine machine = new Machine(6);
            
            Instruction i0 = new AddInstruction();
            List<int> p = new List<int>(); p.Add(2); p.Add(3); p.Add(0); // M2 = 0 + M0
            i0.setParameters(p);
            machine.addInstruction(i0);

            Instruction i1 = new AssignValueInstruction();
            p.Clear(); p.Add(4); p.Add(1); //M4 = 1
            i1.setParameters(p);
            machine.addInstruction(i1);

            Instruction i2 = new GotoIfInstruction();
            p.Clear(); p.Add(5); p.Add(2); // goto 5 if M2 > 0
            i2.setParameters(p);
            machine.addInstruction(i2);

            Instruction i3 = new AddInstruction();
            p.Clear(); p.Add(0); p.Add(3); p.Add(5); // M0 = M3 + 0
            i3.setParameters(p);
            machine.addInstruction(i3);

            Instruction i4 = new HaltInstruction();
            machine.addInstruction(i4); //halt

            Instruction i5 = new AddInstruction();
            p.Clear(); p.Add(3); p.Add(3); p.Add(1); // M3 = M3 + M1
            i5.setParameters(p);
            machine.addInstruction(i5);

            Instruction i6 = new SubstractInstruction();
            p.Clear(); p.Add(2); p.Add(2); p.Add(4); // M2 = M2 - 1
            i6.setParameters(p);
            machine.addInstruction(i6);

            Instruction i7 = new GotoIfInstruction();
            p.Clear(); p.Add(2); p.Add(4); // goto 2
            i7.setParameters(p);
            machine.addInstruction(i7);
            
            int[] input = { 5, 6 };
            machine.insertInput(input);

            // when machine halts result will be in M0
            return machine;
        }
    }
}
