using Sachin_project.Programs_for_practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fibonacci series
            Console.WriteLine("Inter number for fibonacci series ");
            int x = Convert.ToInt32(Console.ReadLine());
            program1_Fibonacci obj = new program1_Fibonacci();
            obj.program1_Fibonacci1(x);
            Console.WriteLine();

            // prime number
            prime_number obj1 = new prime_number();
            Console.WriteLine("Inter number for prime number series ");
            int n = Convert.ToInt32(Console.ReadLine());
            obj1.prime_number1(n);
            Console.WriteLine();

            // palindrome number

            Console.WriteLine("Inter any number for check palindrom ");
            int y = Convert.ToInt32(Console.ReadLine());
            Palindrome obj3=new Palindrome(y);
            Console.WriteLine();

            // factorial 
            Console.WriteLine("Inter any number for factorial");
            int a = Convert.ToInt32(Console.ReadLine());
            Factorial obj4 = new Factorial();
           
            Console.WriteLine("Factorial is  : "+obj4.Factorial2(a));
            Console.WriteLine();

            // sum of digits
            Console.WriteLine("Inter any number for sum of Digits");
             a = Convert.ToInt32(Console.ReadLine());
            sumofdigits obj5 = new sumofdigits();
            obj5.sumofdigits1(a);
            Console.WriteLine();

            // sum of digits in array
            Console.WriteLine("Inter any array for sum of Digits in array");
            int []ar = {189,123,654,789,741,852,963};
            Sumofdigitsinarray obj6 = new Sumofdigitsinarray();
            obj6.Sumofdigitsinarray1(ar);
            Console.WriteLine();

            // reverse array
            Console.WriteLine("Inter any array for reverse of array");
            //int[] ar1 = { 189, 123, 654, 789, 741, 852, 963 };
            ReverseArray obj7 = new ReverseArray();
            obj7.ReverseArray1(ar);
            Console.WriteLine();


            // reverse String
            Console.WriteLine("Inter any string for reverse of String");
            
            string str = Console.ReadLine();
            ReverseString obj8 = new ReverseString();
            obj8.ReverseString1(str);
            Console.WriteLine();

            // Pattern1
            Console.WriteLine("Print Pattern");
            //string str = Console.ReadLine();
            Pattern1 obj9 = new Pattern1();
            obj9.Pattern11();
            Console.WriteLine();

            // Pattern2
            Console.WriteLine("Print Pattern");
            //string str = Console.ReadLine();
            Pattern2 obj10 = new Pattern2();
            obj10.Pattern22();
            Console.WriteLine();


            // chech number is armstrome or not 
            Console.WriteLine("Inter any number for check Armstrome number");
            a = Convert.ToInt32(Console.ReadLine());
            Armstrome obj11 = new Armstrome();
            obj11.Armstrome1(a);
            Console.WriteLine();

            // chech which number is greater in three
            Console.WriteLine("Inter any three number for check Which number is greater");
            a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            greaterNumber obj12 = new greaterNumber();
            obj12.greaterNumber1(a,b,c);
            Console.WriteLine();

            // chech consonants ans vowels and special character
            Console.WriteLine("Inter any String for count vowels and consonants");
            string a1 = Console.ReadLine();
            CountVowel obj13 = new CountVowel();
            obj13.clounvovel(a1);
            Console.WriteLine();


            // Print concatination of two string
            
            ConcatinationString obj14 = new ConcatinationString();
            obj14.ConcatinationString1();
            Console.WriteLine();

            // Print uppercase and lowecase of string
            
            Uppercase obj15 = new Uppercase();
            obj15.uppercase();
            Console.WriteLine();

            // use of properties in c#
            Properties1 obj16 = new Properties1();
            Console.WriteLine("Inter any your name for set p1");
            obj16.Name = Console.ReadLine();
            Console.WriteLine("Inter any your Age for set p1");
            obj16.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Get name from properties : "+obj16.Name);
            Console.WriteLine("Get Age from properties : " + obj16.Age);

            // use of properties in c#
            Properties2 obj17 = new Properties2();
            Console.WriteLine("Inter any your address for set p2");
            obj17.Address = Console.ReadLine();
            Console.WriteLine("Inter any your mobile number for set p2");
            obj17.Mobile = Console.ReadLine();
            Console.WriteLine("Get Address from properties : " + obj17.Address);
            Console.WriteLine("Get Mobile Number from properties : " + obj17.Mobile);


            // use of properties in c#
            Properties3 obj18 = new Properties3();
            Console.WriteLine("Inter any your E mail for set p2");
            obj18.Email = Console.ReadLine();
            Console.WriteLine("Inter any your Salary for set p2");
            obj18.Salary = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Get E-mail from properties : " + obj18.Email);
            Console.WriteLine("Get Salary from properties : " + obj18.Salary);

            //use List in properties
            IList<Properties1> list1= new List<Properties1>();
            


        }

        private static string program1_Fibonacci1(int n, int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
