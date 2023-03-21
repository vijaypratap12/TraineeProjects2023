using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class Pattern1
    {
        public void Pattern11() {
        
            for(int i = 1; i <= 13; i++)
            {
                for(int  j = 1; j <=13; j++)
                {
                    if(i==1||j==1||i==13||j==13||i==j||i+j==14)
                    Console.Write(" *");
                    else Console.Write("  ");
                }
                Console.WriteLine("");
            }
        
        }
    }
}
