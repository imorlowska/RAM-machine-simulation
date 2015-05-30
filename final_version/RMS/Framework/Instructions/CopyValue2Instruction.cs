using System;
using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
     * 6. M[M[i]] <-- M[j]
     **/
    class CopyValue2Instruction : Instruction
    {
        public override int Run(int[] tape)
        {
            tape[tape[Parameters[0]]] = tape[Parameters[1]];
            return Line + 1;
        }

        public override void SetParameters(List<int> parameters)
        {
            if (parameters.Count != 2)
                throw new ArgumentException("Copy Value 2 takes exactly two parameters!");
            Parameters = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}. M[M[{1}]] = M[{2}]",Line,Parameters[0],Parameters[1]);
        }
    }
}
