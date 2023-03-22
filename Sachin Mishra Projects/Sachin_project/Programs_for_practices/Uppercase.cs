using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class Uppercase
    {
        public void uppercase()
        {
            string str;
            Console.WriteLine("Enter the String in Uppercase :");
            str = Console.ReadLine();
            Console.WriteLine("String in LowerCase : {0} ", str.ToLower());
            Console.WriteLine("String in UpperCase : {0} ", str.ToUpper());

        }
    }
}
