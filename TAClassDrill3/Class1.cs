using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAClassDrill3
{
    class Numbers
    {
        public void Math(int num1, int num2 = 0)
        {            
            int result = num1 + num2;
            Console.WriteLine("Your numbers added is : {0}", result);                      
        }
    }
}
