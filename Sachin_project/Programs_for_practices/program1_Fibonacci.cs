using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class program1_Fibonacci
    {

        
           public void program1_Fibonacci1(int x) {
            
            int a=0, b=1, sum=0;

            Console.Write(a+" "+b+" ");
            for (int j = 1; j <= x; j++)
            {
                sum = a + b;
                Console.Write(sum+" ");
                a = b; b = sum;
            }   
        
        }
       

    }
}
