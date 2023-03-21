//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp
//{
//    public delegate void DelTwo(int x, int y);
//    public class NewDelegateExample
//    {
//        public static void DelegateExample(int a, int b)
//        {
//            Console.WriteLine(a + b);
//            //Console.ReadLine();  
//        }
//        public static void DelegateExampleTwo(int a, int b)
//        {
//            Console.WriteLine(a - b);
//            Console.ReadLine();
//        }
//        public static void DelegateExampleThree(int a, int b)
//        {
//            Console.WriteLine(a * b);
//            Console.ReadLine();
//        }
//        public static void Main(string[] args)
//        {
//            DelTwo delTwo = new DelTwo(NewDelegateExample.DelegateExample);
//            delTwo.Invoke(30, 20);
//            delTwo = DelegateExampleTwo;
//           // delTwo.Invoke(10, 20);
//            delTwo(30, 20);

//            //NewDelegateExample.DelegateExample(10, 20);
//        }
//    }
//}
