using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ControlStatements
    {
        public int ConditionOne()
        {
            int a = 10;
            int b = 30;
            while(a-- == 9)
            {
                return a;
            }
            return a + b;
        }
    }
}
