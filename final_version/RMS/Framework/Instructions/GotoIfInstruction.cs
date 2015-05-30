using System;
using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
     * 7. go to m if Mi > 0
     **/
    internal class GotoIfInstruction : Instruction
    {
        public override int Run(int[] tape)
        {
            if (tape[Parameters[1]] > 0)
                return Parameters[0];
            return Line + 1;
        }

        public override void SetParameters(List<int> parameters)
        {
            if (parameters.Count != 2)
                throw new ArgumentException("Goto If takes exactly two parameters!");
            Parameters = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}. goto {1} if M[{2}] > 0",Line,Parameters[0],Parameters[1]);
        }
    }
}
