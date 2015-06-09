using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    internal abstract class Instruction
    {
        protected Instruction()
        {
            Line = -2;
        }

        public int Line { get; set; }

        public List<int> Parameters { get; protected set; }

        public abstract int Run(int[] tape);

        public abstract void SetParameters(List<int> parameters);
    }
}
