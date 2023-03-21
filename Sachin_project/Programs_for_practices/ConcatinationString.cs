using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class ConcatinationString
    {
        public void ConcatinationString1() {
            Console.WriteLine("Enter the 1st String for concatination :");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the 2st String for concatination :");
            string s2 = Console.ReadLine();
            string s3 = string.Concat(s1, s2);
            Console.WriteLine("Concatinated strings : "+s3);
           
        }
    }
}
