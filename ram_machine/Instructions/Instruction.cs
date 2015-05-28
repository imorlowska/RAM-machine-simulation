using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_machine
{
    abstract class Instruction
    {
        public int line;
        public List<int> parameters;

        public Instruction()
        {
            this.line = -2;
            this.parameters = new List<int>();
        }
        /**
         * Runs the instruction on the tape. Returns the number of instruction that should be run next.
         **/
        public abstract int run(int[] tape);
        /**
         * Sets the required parameters. 
         **/
        public abstract void setParameters(List<int> parameters);
        /**
         * Returns the instruction in more user friendly form.
         **/
        public abstract String ToString();
        /**
         * Sets which line the instruction is on.
         **/
        public void setLine(int line)
        {
            this.line = line;
        }
    }
}
