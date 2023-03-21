using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class sumofdigits
    {
        public void sumofdigits1(int x) {
            int a, sum = 0, b = 0;

            while (x > 0)
            {
                b = x % 10;
                sum = sum + b;
                 x= x / 10;
            }
            
             Console.WriteLine("Sum of Digits  " + sum);


        }
    }
}
