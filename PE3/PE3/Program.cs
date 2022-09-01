using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert
{

    class program
    {
        static void Main(string[] args)
        {
            Console.Write("type four numbers\n");

            int total = 0;

            for(int i = 0; i < 4; i++)
            {
                string line = Console.ReadLine();

                total += (int)Convert.ToDouble(line);
            }

            Console.Write("Sum: " + total);

            


        }
    }
}