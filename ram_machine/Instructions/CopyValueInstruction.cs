using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_machine.Instructions
{
    /**
     * 5. M[i] <-- M[M[j]]
     **/
    class CopyValueInstruction : Instruction
    {
        public override int run(int[] tape)
        {
            tape[this.parameters[0]] = tape[tape[this.parameters[1]]];
            return this.line + 1;
        }

        public override void setParameters(List<int> parameters)
        {
            if (parameters.Count != 2)
            {
                throw new ArgumentException("Copy Value takes exactly two parameters!");
            }
            this.parameters.Add(parameters[0]); //i
            this.parameters.Add(parameters[1]); //j
        }

        public override string ToString()
        {
            return this.line + ". M[" + this.parameters[0] + "] = M[M[" + this.parameters[1] + "]]";
        }
    }
}
