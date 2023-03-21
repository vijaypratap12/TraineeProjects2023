using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Boxing
    {
        public enum Employee
        {
            emp1 = 1,
            emp2 = 3
        }

        public void Conversion()
        {
            int a = 20;  //value type
            object o = a;   //boxing, convertion from value to ref type
            Console.WriteLine(a);
            Console.WriteLine(o);
            Console.ReadLine();
        }



    }
}
