/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Madhu_MCN_Trainee
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            int num, a, total=0, ab=0;             
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            total = num;
            while (num > 0)
            {
                a = num % 10; 
                ab = ( ab * 10 )+ a;
                num = num / 10;     
            }           
            if (total == ab) 
            {
                Console.WriteLine("this is palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
*/