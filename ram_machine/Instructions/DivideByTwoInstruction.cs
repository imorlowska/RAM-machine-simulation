using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_machine.Instructions
{
    /**
     * 4. Mi <-- floor(Mi/2)
     **/
    class DivideByTwoInstruction : Instruction
    {
        public override int run(int[] tape)
        {
            tape[this.parameters[0]] = tape[this.parameters[0]] / 2;
            return this.line + 1;
        }

        public override void setParameters(List<int> parameters)
        {
            if (parameters.Count != 1)
            {
                throw new ArgumentException("Divide By Two takes exactly one parameter!");
            }
            this.parameters.Add(parameters[0]); //i
        }

        public override string ToString()
        {
            return this.line + ". M[" + this.parameters[0] + "] = floor(M[" + this.parameters[0] + "]/2)";
        }
    }
}
