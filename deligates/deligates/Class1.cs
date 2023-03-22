/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligates
{
    public delegate void prime(int x);
    public class Class1
    {
        public void prime(int x) 
        {
            if (x > 1)
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine("Not a Prime Number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Its a Prime Number");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("not a prime numeber");
            }
            }
        public static void Main(string[] args)
        {
            Class1 c= new Class1();
            Console.WriteLine("enter the number");
            int x=int.Parse(Console.ReadLine());
            prime p = new prime(c.prime);
            p(x);

        }
    }
   
}*/

