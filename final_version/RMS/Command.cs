using System.Collections.Generic;
using System.ComponentModel;
using RMS.Framework.Instructions;

namespace RMS
{
    internal class Command
    {  
        public CommandType Type { get; set; }

        public int Position { get; set; }

        public int? Arg1 { get; set; }

        public int? Arg2 { get; set; }

        public int? Arg3 { get; set; }

        public override string ToString()
        {
            var arguments = Arg1 == null && Arg2 == null && Arg3 == null
                ? string.Empty
                : string.Format("{0} {1} {2}", 
                Arg1.HasValue ? Arg1.Value.ToString() : string.Empty, 
                Arg2.HasValue ? Arg2.Value.ToString() : string.Empty, 
                Arg3.HasValue ? Arg3.Value.ToString() : string.Empty
                );
            if (!string.IsNullOrEmpty(arguments))
                arguments = "Parametry: " + arguments;
            switch (Type)
            {
                case CommandType.AssignValue:
                    return "Przypisz wartość: Mi <-- 1 " + arguments;
                case CommandType.Add:
                    return "Dodaj: Mi <-- Mj + Mk " + arguments;
                case CommandType.Substract:
                    return "Odejmij: Mi <-- Mj - Mk " + arguments;
                case CommandType.Divide:
                    return "Podziel: Mi <-- floor(Mi/2) " + arguments;
                case CommandType.CopyValue:
                    return "Kopiuj wartość: M[i] <-- M[M[j]] " + arguments;
                case CommandType.CopyValue2:
                    return "Kopiuj wartość 2: M[M[i]] <-- M[j] " + arguments;
                case CommandType.GotoIf:
                    return "Idź do: goto m if Mi > 0 " + arguments;
                case CommandType.Halt:
                    return "STOP";
            }
            throw new InvalidEnumArgumentException();
        }

        public Instruction Translate()
        {
            Instruction instruction;
            switch (Type)
            {
                case CommandType.AssignValue:
                    instruction = new AssignValueInstruction();
                    instruction.SetParameters(new List<int> { Arg1.Value, Arg2.Value });
                    break;
                case CommandType.Add:
                    instruction = new AddInstruction();
                    instruction.SetParameters(new List<int> { Arg1.Value, Arg2.Value, Arg3.Value });
                    break;
                case CommandType.Substract:
                    instruction = new SubstractInstruction();
                    instruction.SetParameters(new List<int> { Arg1.Value, Arg2.Value, Arg3.Value });
                    break;
                case CommandType.Divide:
                    instruction = new DivideByTwoInstruction();
                    instruction.SetParameters(new List<int> { Arg1.Value });
                    break;
                case CommandType.CopyValue:
                    instruction = new CopyValueInstruction();
                    instruction.SetParameters(new List<int> { Arg1.Value, Arg2.Value });
                    break;
                case CommandType.CopyValue2:
                    instruction = new CopyValue2Instruction();
                    instruction.SetParameters(new List<int> { Arg1.Value, Arg2.Value });
                    break;
                case CommandType.GotoIf:
                    instruction = new GotoIfInstruction();
                    instruction.SetParameters(new List<int> { Arg1.Value, Arg2.Value });
                    break;
                case CommandType.Halt:
                    instruction = new HaltInstruction();
                    instruction.SetParameters(new List<int>());
                    break;
                default:
                    throw new InvalidEnumArgumentException();
            }
            return instruction;
        }

        public int NumberOfArguments()
        {
            switch (Type)
            {
                case CommandType.AssignValue:
                    return 2;
                case CommandType.Add:
                    return 3;
                case CommandType.Substract:
                    return 3;
                case CommandType.Divide:
                    return 1;
                case CommandType.CopyValue:
                    return 2;
                case CommandType.CopyValue2:
                    return 2;
                case CommandType.GotoIf:
                    return 2;
                case CommandType.Halt:
                    return 0;
            }
            throw new InvalidEnumArgumentException();
        }
    }

    enum CommandType
    {
        AssignValue,
        Add,
        Substract,
        Divide,
        CopyValue,
        CopyValue2,
        GotoIf,
        Halt
    }
}
