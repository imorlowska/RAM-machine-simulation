using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_machine.Instructions
{
    /**
     * 1. Mi <-- 1
     **/
    class AssignValueInstruction : Instruction
    {
        public override int run(int[] tape)
        {
            tape[this.parameters[0]] = this.parameters[1];
            return this.line + 1;
        }

        public override void setParameters(List<int> parameters)
        {
            if (parameters.Count != 2)
            {
                throw new ArgumentException("Assign Value takes exactly two parameters!");
            }
            this.parameters.Add(parameters[0]); //i
            this.parameters.Add(parameters[1]); //value
        }

        public override string ToString()
        {
            return this.line + ". M[" + this.parameters[0] + "] = " + this.parameters[1];
        }
    }
}
