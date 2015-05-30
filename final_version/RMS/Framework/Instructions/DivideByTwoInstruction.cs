using System;
using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
     * 4. Mi <-- floor(Mi/2)
     **/
    internal class DivideByTwoInstruction : Instruction
    {
        public override int Run(int[] tape)
        {
            tape[Parameters[0]] = tape[Parameters[0]] / 2;
            return Line + 1;
        }

        public override void SetParameters(List<int> parameters)
        {
            if (parameters.Count != 1)
                throw new ArgumentException("Divide By Two takes exactly one parameter!");
            Parameters = parameters;
        }

        public override string ToString()
        {
            return string.Format("{0}. M[{1}] = floor(M[{2}]/2)",Line,Parameters[0],Parameters[0]);
        }
    }
}
