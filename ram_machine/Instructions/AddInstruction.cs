using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_machine.Instructions
{
    /**
     * 2. Mi <-- Mj + Mk
     **/
    class AddInstruction : Instruction
    {
        public override int run(int[] tape)
        {
            tape[this.parameters[0]] = tape[this.parameters[1]] + tape[this.parameters[2]];
            return this.line + 1;
        }

        public override void setParameters(List<int> parameters)
        {
            if (parameters.Count != 3)
            {
                throw new ArgumentException("Add takes exactly three parameters!");
            }
            this.parameters.Add(parameters[0]); //i
            this.parameters.Add(parameters[1]); //j
            this.parameters.Add(parameters[2]); //k
        }

        public override string ToString()
        {
            return this.line + ". M[" + this.parameters[0] + "] = M[" + this.parameters[1] + "] + M[" + this.parameters[2] + "]";
        }
    }
}
