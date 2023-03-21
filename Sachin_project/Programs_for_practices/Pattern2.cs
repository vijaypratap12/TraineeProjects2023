using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class Pattern2
    {
        public void Pattern22() { 
         for(int i = 0; i <= 10; i++)
            {
                for(int k=10; k >=i; k--)
                    Console.Write("  ");
                for (int j = 0; j <(2*i+1); j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
        }    
    }
}
