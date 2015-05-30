using System;
using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
    * 5. M[i] <-- M[M[j]]
    **/
    internal class CopyValueInstruction : Instruction
    {
        public override int Run(int[] tape)
        {
            tape[Parameters[0]] = tape[tape[Parameters[1]]];
            return Line + 1;
        }

        public override void SetParameters(List<int> parameters)
        {
            if (parameters.Count != 2)
                throw new ArgumentException("Copy Value takes exactly two parameters!");
            Parameters = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}. M[{1}] = M[M[{2}]]", Line, Parameters[0], Parameters[1]);
        }
    }
}
