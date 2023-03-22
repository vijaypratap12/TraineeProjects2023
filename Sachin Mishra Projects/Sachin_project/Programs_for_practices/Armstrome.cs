using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class Armstrome
    {
        public void Armstrome1(int n) {

            int sum = 0, b, c = n;
            while(n>0)
            {
                b = n % 10;
                sum=sum+b*b*b;
                n=n/10;

            }
            if(sum == c) { Console.WriteLine("Number is Armstrome : " + sum);
            }else { Console.WriteLine("Number is not Armstrome : "+sum); }
        }
    }
}
