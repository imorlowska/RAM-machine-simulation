using System.Collections.Generic;

namespace RMS.Framework.Instructions
{
    /**
     * 8. HALT
     **/
    internal class HaltInstruction : Instruction
    {
        public override int Run(int[] tape)
        {
            return -1;
        }

        public override void SetParameters(List<int> parameters) { }

        public override string ToString()
        {
            return string.Format("{0}. HALT", Line);
        }
    }
}
