
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligates
{
    public delegate void fib(int x);
    class Program
    {
        public void fibonacci(int x)
        {
            int n = 0, n1 = 1, n3, i;
           
            Console.Write(n+""+ n1);
            for (i = 2; i < x; i++)
            {
                n3 = n + n1;
                Console.Write(n3);
                n = n1;
                n1 = n3;
            }
        }
        static void Main(string[] args)
        { 
            Program p=new Program();
            Console.WriteLine("enter the no of element");
            int x = int.Parse(Console.ReadLine());
            fib f = new fib(p.fibonacci);
            f(x);
            Console.ReadLine();
        }
    }
}
*/