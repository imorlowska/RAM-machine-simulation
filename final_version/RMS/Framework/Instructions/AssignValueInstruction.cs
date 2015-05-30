using System;
using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
     * 1. Mi <-- 1
     **/
    class AssignValueInstruction : Instruction
    {
        public override int Run(int[] tape)
        {
            tape[Parameters[0]] = Parameters[1];
            return Line + 1;
        }

        public override void SetParameters(List<int> parameters)
        {
            if (parameters.Count != 2)
                throw new ArgumentException("Assign Value takes exactly two parameters!");
            Parameters = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}. M[{1}] = {2}",Line,Parameters[0],Parameters[1]);
        }
    }
}
