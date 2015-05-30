using System;
using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
     * 3. Mi <-- Mj - Mk
     **/
    internal class SubstractInstruction : Instruction
    {
        public override int Run(int[] tape)
        {
            tape[Parameters[0]] = tape[Parameters[1]] - tape[Parameters[2]];
            return Line + 1;
        }

        public override void SetParameters(List<int> parameters)
        {
            if (parameters.Count != 3)
                throw new ArgumentException("Substract takes exactly three Parameters!");
            Parameters = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}.M[{1}] = M[{2}] - M[{3}]",Line,Parameters[0],Parameters[1],Parameters[2]);
        }
    }
}
