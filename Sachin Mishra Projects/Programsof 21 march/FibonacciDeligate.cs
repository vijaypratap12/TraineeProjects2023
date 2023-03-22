using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Program_of_21march
{
    internal class FibonacciDeligate
    {
        
            public int Factorial2(int x)
            {

                if (x != 0)
                {
                    return (x * Factorial2(x - 1));
                }
                else
                {
                    return 1;
                }
            }
        

        
    }
}
