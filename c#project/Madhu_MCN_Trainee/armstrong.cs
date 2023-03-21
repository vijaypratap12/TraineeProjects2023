/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madhu_MCN_Trainee
{
    public class armstrong
    {
        public static void Main(string[] args)
        {
            int a,num, total=0, ab=0;
            Console.WriteLine("enter the num: ");
            num =Convert.ToInt32(Console.ReadLine());
            total = num;
            while(num > 0) 
            {           
            a = num % 10;
            ab = ab + (a * a * a);
            num = num / 10;
            }
            if (total == ab)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not");
            }
            Console.ReadLine();
        }
    }
}
*/