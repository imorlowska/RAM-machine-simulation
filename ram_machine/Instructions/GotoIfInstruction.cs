using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_machine.Instructions
{
    /**
     * 7. go to m if Mi > 0
     **/
    class GotoIfInstruction : Instruction
    {
        public override int run(int[] tape)
        {
            if (tape[this.parameters[1]] > 0) //if Mi > 0
            {
                return this.parameters[0]; //m
            }
            return this.line + 1;
        }

        public override void setParameters(List<int> parameters)
        {
            if (parameters.Count != 2)
            {
                throw new ArgumentException("Goto If takes exactly two parameters!");
            }
            this.parameters.Add(parameters[0]); //m
            this.parameters.Add(parameters[1]); //i
        }

        public override string ToString()
        {
            return this.line + ". goto " + this.parameters[0] + " if M[" + this.parameters[1] + "] > 0";
        }
    }
}
