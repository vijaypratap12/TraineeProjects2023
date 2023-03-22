/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligates
{
    public delegate void palindrome(int x);
    public class pm
    {
        public void palindrome(int x)
        {
            int n, temp,rev=0;
            temp = x;
            while(x>0)
            {
                n = x % 10;
                rev = rev * 10 + n ;
                x = x / 10;
            }
            if(rev==temp)
            {
                Console.WriteLine("palindrome number");
            }
            else
            {
                Console.WriteLine("NOT a palindrome number");

            }
           
        }
        public static void Main(string[] args) 
        {
            pm p=new pm();
            Console.WriteLine("enter the number");
            int x = int .Parse(Console.ReadLine());
            palindrome pr = new palindrome(p.palindrome);
            pr(x);
            Console.ReadLine();


        }
    }
}*/
