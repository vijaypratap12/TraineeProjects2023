//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Madhu_MCN_Trainee
//{
//    public class Deligate_fibonacci
//    {
//        public delegate void madhu1(int x);
//        public void Deligate1(int n)
//        {
//            int x = 0, y = 1, fib_num = 0;
//            for (int i = 0; i < n; i++)
//            {
//                fib_num = x + y;
//                Console.WriteLine(fib_num);
//                x = y; y = fib_num;
//            }
//        }
//        static void Main(string[] arg)
//        {
//            Deligate_fibonacci deligate11 = new Deligate_fibonacci();
//            madhu1 m1 = new madhu1(deligate11.Deligate1);
//            Console.WriteLine("enter the num");
//            int n = Convert.ToInt32(Console.ReadLine());
//            m1(n);
//            Console.ReadLine();
//        }
//    }
//}

