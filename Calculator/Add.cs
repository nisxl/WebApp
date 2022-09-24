using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Calculator
{
    internal class Add
    {
        public void Addition() {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            int add = Convert.ToInt32(num1) + Convert.ToInt32(num2);

            Console.WriteLine($"the sum is: {add}");
        }
    }
}
