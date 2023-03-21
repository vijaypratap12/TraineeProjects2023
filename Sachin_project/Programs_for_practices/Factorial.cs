using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class Factorial
    {
        int fact = 1;

        public int Factorial2(int x) {
            
            if (x!=0)
            {
                return (x*Factorial2(x - 1));
            }
            else
            {
                return 1;
            }
            
        }
    }
}
