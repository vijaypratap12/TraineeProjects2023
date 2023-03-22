//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Madhu_MCN_Trainee
//{
//    public class DelegatePalindrome
//    {
//        public delegate void Delegatefive(int n);
//        public void function5(int x)
//        {
//            int a, total = 0, ab = 0;           
//            total = x;
//            while (x > 0)
//            {
//                a = x % 10;
//                ab = (ab * 10) + a;
//                x = x / 10;
//            }
//            if (total == ab)
//            {
//                Console.WriteLine("this is the palindrome");
//            }
//            else
//            {
//                Console.WriteLine("this is not a palindrome");
//            }
//            Console.ReadLine();
//        }
//        public static void Main(string[] args) 
//        { 
//        DelegatePalindrome delegatePalindrome = new DelegatePalindrome();
//            Delegatefive del5 = new Delegatefive(delegatePalindrome.function5);
//            Console.WriteLine("enter the num ");
//            int num =Convert.ToInt32(Console.ReadLine());
//            del5.Invoke(num);
//            Console.ReadLine() ;
//        }
//    }
//}
