using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class Sumofdigitsinarray
    {
        public void Sumofdigitsinarray1(int[]arr) {
            int n=arr.Length;
            for(int i=0; i<n; i++)
            {
                int x,sum=0,b;
                x = arr[i];
                while(x > 0)
                {
                    b=x%10; 
                    sum+=b;
                    x = x/10;
                }
                arr[i] = sum;
                Console.Write(" "+arr[i] +" ");
            }
        }
    }
}
