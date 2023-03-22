using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class PrimeWithdeligate
    {
           public int  prime_number1(int n) {

            int count = 0;
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                        count++;

                }
                if (count == 2)
                    Console.Write(j+" ");
                count = 0;
            }
            return 0;
            }

      
        }
}
