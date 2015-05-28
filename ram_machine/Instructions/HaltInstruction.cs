using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_machine.Instructions
{
    /**
     * 8. HALT
     **/
    class HaltInstruction : Instruction
    {
        public override int run(int[] tape)
        {
            return -1;
        }

        public override void setParameters(List<int> parameters)
        {
            if (parameters.Count > 0)
            {
                throw new ArgumentException("HALT doesn't take any parameters");
            }
        }

        public override string ToString()
        {
            return this.line + ". HALT";
        }
    }
}
