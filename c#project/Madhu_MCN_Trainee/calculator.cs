/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madhu_MCN_Trainee
{
     public class calculator
    {
        public static void Main(string[] args)
        {
            int num_3;
            Console.WriteLine("enter the first num");
           int  num_1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second num");
            int num_2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ur operator +,-,*,/");
            string choice= Console.ReadLine();
            switch (choice)
            {
                case "+":                  
                    Console.WriteLine(num_1+num_2);
                    break;
                case "-":
                    Console.WriteLine(num_1-num_2);
                    break;
                case "*":
                    Console.WriteLine(num_1 * num_2);
                    break;
                case "/":
                    Console.WriteLine(num_1 / num_2);
                    break;
                default: 
                    Console.WriteLine("invalid task");
                    break;
            }
        }
    }
}
*/