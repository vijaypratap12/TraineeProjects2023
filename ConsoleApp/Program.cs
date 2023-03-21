//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int a;
//            a = 15;
//            int x = 12345;
//            long y = x; //implicit
//            short z = (short)x;
//            double d = 12.3242323;
//            float f = (float)d;   //explicit
//            long l = (long)d;
//            string s = "MCN Solutions";
//            Console.WriteLine(s + ", " + x + ", " + y + ", " + z + ", " + f + ", " + l + ", " + a);



//            int[] arr;   //declare
//            arr = new int[5] { 11, 22, 33, 44, 55 };   //initialize
//            int[] arr2 = new int[5];


//            try
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    Console.WriteLine(arr[i]);
//                    if (arr[i] == 44)
//                    {
//                        Console.WriteLine("This is value 44");

//                    }
//                    else if (arr[i] == 55)
//                    {
//                        Console.WriteLine(arr[i] / 0);
//                    }
//                }

//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.ToString());
//                Console.ReadLine();
//            }
//            finally{
//                Console.WriteLine("This is finally block");
//            }

//        }
//    }
//}
