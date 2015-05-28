using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ram_machine
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Console.Write("\n\n\n\nMachine multiplying 5 and 6\n\nInstructions:\n");
            Machine m = Machine.getSampleMachine();
            Console.Write(m.getInstructionsString());
            Console.Write("\nSteps:\n");
            while (m.runOneInstruction())
            {
                int[] tmp = m.getTape();
                foreach (int i in tmp) 
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\nResult: " + m.getTape()[0] + "\n\n\n");
        }
    }
}
