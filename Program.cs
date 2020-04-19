using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            uint n = 0;
            string binary = "";
           
            //Requesting number
            Console.Write(" Enter the positive number: ");
            n = Convert.ToUInt32(Console.ReadLine());

            binary = Convert.ToString(n, 2);

            Console.Write(" Enter the number {0} as binary {1}", n, binary );

            Console.ReadKey();
        }
    }
}
