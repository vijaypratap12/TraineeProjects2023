using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class PalindromeWithdeligate
    {
        public int PalindromeWithdeligate1(int x) {
            int a,sum=0,b=0,n=x;

            while (n > 0)
            {
                b = n % 10;
                sum=sum*10 +b;
                n= n/10;
            }
            if (x == sum) Console.WriteLine("Number is Palindrome "+x);
            else Console.WriteLine("Number is not  Palindrome " + x);
            return 0;
        }
    }
}
