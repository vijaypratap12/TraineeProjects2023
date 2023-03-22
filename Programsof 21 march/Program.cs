using Sachin_project.Program_of_21march;
using Sachin_project.Programs_for_practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programsof_21_march
{
    internal class Program
    {

        public delegate int del1(int x);
        static void Main(string[] args)
        {
            // factorial with deligate
            Console.WriteLine("Inter any number for factorial");
            int a = Convert.ToInt32(Console.ReadLine());
            FibonacciDeligate obj = new FibonacciDeligate();
           del1 db1 = new del1(obj.Factorial2);
            Console.WriteLine(db1(a));

            // chech number is armstrome or not with deligate 
            Console.WriteLine("Inter any number for check Armstrome number");
            a = Convert.ToInt32(Console.ReadLine());
            ArmstromeWithdeligate obj1 = new ArmstromeWithdeligate();
            db1 = obj1.Armstrome1;
            db1(a);

            // fibonacci series with delegate
            Console.WriteLine("Inter number for fibonacci series ");
            int x = Convert.ToInt32(Console.ReadLine());
            FibonacciWithdelegate obj3 = new FibonacciWithdelegate();
            db1 = obj3.program1_Fibonacci1;
            db1(x);


            // prime number with deligate
            PrimeWithdeligate obj4 = new PrimeWithdeligate();
            Console.WriteLine("Inter number for prime number series ");
            int n = Convert.ToInt32(Console.ReadLine());
            db1=obj4.prime_number1;
            db1(n);

            // palindrome number with deligate
            Console.WriteLine("Inter any number for check palindrom ");
            int y = Convert.ToInt32(Console.ReadLine());
            PalindromeWithdeligate obj5 = new PalindromeWithdeligate();
            db1 = obj5.PalindromeWithdeligate1;
            db1(y);




        }
    }
}
