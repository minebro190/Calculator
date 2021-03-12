using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_With_Ben
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
