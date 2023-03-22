//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Madhu_MCN_Trainee
//{
//    public delegate void dele2(int n);
//    public class Delegate_prime
//    {
        
//        public void function2(int n)
//        {
//            if (n > 1)
//            {
//                for (int i = 2; i < n; i++)
//                {
//                    if (n % i == 0)
//                    {
//                        Console.WriteLine(" not prime num");
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("prime");
//                        break;
//                    }

//                }

//            }
//            else
//            {
//                Console.WriteLine("not a prime");
//            }
            
//        }
//        public static void Main(string[] args)
//        {
//            Delegate_prime pro = new Delegate_prime();
//            dele2 del = new dele2(pro.function2);

//            Console.WriteLine("enter the num: ");
//            int n = int.Parse(Console.ReadLine());

//            //pro.function2(y);
//            del(n);
//            Console.ReadLine();
//        }

//    }
//}
