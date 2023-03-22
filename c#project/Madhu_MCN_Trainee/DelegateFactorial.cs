//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Madhu_MCN_Trainee
//{
//   public class DelegateFactorial
//    {      
//        public delegate void Delegatefour(int x);
//        int f = 1;
//        public void function4(int n)
//        {
//            for(int i=1;i<=n; i++)
//            {
//                f = f * i;
//            }
//            Console.WriteLine("here the factorial is: "+ f);
//        }
//        public static void Main(string[] args)
//        {
//            DelegateFactorial delfactorial =new DelegateFactorial();
//            Delegatefour del4 = new Delegatefour(delfactorial.function4);
//            Console.WriteLine("enter the num to find its factorial: ");
//            int n= Convert.ToInt32(Console.ReadLine());
//            del4.Invoke(n);
//            Console.ReadLine();
//        }
//    }
//}
