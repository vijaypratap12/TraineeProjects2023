//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Madhu_MCN_Trainee
//{
//    public class DelegateArmstrong
//    {
//        public delegate void DelegateThree(int n);
//        public void function3(int x)
//        {
//            int a, total = 0, ab = 0;
//            total = x;
//            while (x > 0)
//            {
//                a = x % 10;
//                ab = ab + (a * a * a);
//                x = x / 10;
//            }
//            if (total == ab)
//            {
//                Console.WriteLine("armstrong");
//            }
//            else
//            {
//                Console.WriteLine("not");
//            }
//            Console.ReadLine();
//        }
//        public static void Main(string[] args)
//        {

//            DelegateArmstrong delArmstrong = new DelegateArmstrong();
//            DelegateThree del3 = new DelegateThree(delArmstrong.function3);
//            Console.WriteLine("enter the num to check whether it is armstrong or not: ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            del3.Invoke(n);
//            Console.ReadLine();

//        }
//    }
//}
