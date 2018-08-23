using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAClassDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string userInput;

            Console.WriteLine("Give me a number.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me a second number if you want to.");
            userInput = Console.ReadLine();

            if (userInput == "")
            {
                Numbers math = new Numbers();
                math.Math(num1);
            }
            else
            {
                Numbers math2 = new Numbers();
                math2.Math(num1, Convert.ToInt32(userInput));
            }
            Console.ReadLine();
        }
    }
}
