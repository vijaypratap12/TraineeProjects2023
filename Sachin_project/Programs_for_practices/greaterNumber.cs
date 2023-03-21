using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class greaterNumber
    {
        public void greaterNumber1(int a,int b, int c) {

            if (a>b&&a>c) {
                Console.WriteLine("Number a is greater : " + a);
            }else if (b>c) {
                Console.WriteLine("Number b is greater : " + b);
            }
            else {
                Console.WriteLine("Number c is greater : " + c);
            }
        }
    }
}
