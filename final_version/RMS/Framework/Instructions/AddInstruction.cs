using System;
using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
     * 2. Mi <-- Mj + Mk
     **/
    internal class AddInstruction : Instruction
    {
        public override int Run(int[] tape)
        {
            tape[Parameters[0]] = tape[Parameters[1]] + tape[Parameters[2]];
            return Line + 1;
        }

        public override void SetParameters(List<int> parameters)
        {
            if (parameters.Count != 3)
                throw new ArgumentException("Add takes exactly three parameters!");
            Parameters = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}. M[{1}] = M[{2}] + M[{3}]",Line,Parameters[0],Parameters[1],Parameters[2]);
        }
    }
}
