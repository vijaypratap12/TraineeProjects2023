using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligates
{
    public delegate void factorial(int x);
    public class fact
    {
        public void factorial(int x)
        {
            if (x > 1)
            {
                int f = 1;
                while (x != 0)
                {
                    f = f * x;
                    x--;
                }
                Console.WriteLine("factorial is " + f);
            }
            else
            {
                Console.WriteLine("factorial is 1");
            }
        }
        public static void Main(String[] args)
        {
            fact fobj= new fact();
            Console.WriteLine("enter the number");
            int x=int.Parse(Console.ReadLine());
            factorial fr = new factorial(fobj.factorial);
            fr(x);
            Console.ReadLine();
        }
    }
}
