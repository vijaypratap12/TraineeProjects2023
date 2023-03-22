/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligates
{
    public delegate void armstrong(int x);
    public class arm
    {
        public void armstrong(int x)
        {
            int n, m=0, temp;
            temp = x;
            while(x>0)
            {
                n = x % 10;
                m = m + (n * n * n);
                x = x / 10;
            }
            if(m==temp)
            {
                Console.WriteLine("its a armstrong number");
            }
            else
            {
                Console.WriteLine("Not a armstrong number");
            }
        }
        public static void Main(string[] args) 
        { 
            arm a =new arm();
            Console.WriteLine("Enter the number");
            int x= int.Parse(Console.ReadLine());
            armstrong am = new armstrong(a.armstrong);
            am(x);
            Console.ReadLine();
        }  

    }
}*/
