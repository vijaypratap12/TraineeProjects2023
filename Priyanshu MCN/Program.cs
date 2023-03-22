/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Priyanshu_MCN
{
    public class Program
    {
        public void fibonaaci()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                Console.ReadLine();
            }
        }
            public void primenumber()
            {
                int n, i, m = 0, flag = 0;
                Console.Write("Enter the Number to check Prime: ");
                n = int.Parse(Console.ReadLine());
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write("Number is not Prime.");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.Write("Number is Prime.");
            }
        public void Armstrong()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
        public void palindrome()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
        public void factorial() 
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
        public void sumofdidgit()
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }
        public void sumofarray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int element in arr)
            {
                sum += element;
            }

            Console.WriteLine("Sum of array elements is: " + sum);
        }
        public void reversearry()
        {
            int n;
            Console.Write("Enter the size of the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nReversed array:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void revstring()
        {
            Console.Write("Enter a string to reverse: ");
            string str = Console.ReadLine();

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverseStr = new string(charArray);

            Console.WriteLine("Reversed string: " + reverseStr);
        }
        public void pattern1()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void pattern2()
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
        public void concat()
        {
            string str1 = "Hello";
            string str2 = "World";

            // Concatenate two strings
            string str3 = str1 + " " + str2;

            Console.WriteLine(str3);
        }
        public void stringpalindrome()
        {
            string str = "madam";

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverseStr = new string(charArray);

            if (str == reverseStr)
            {
                Console.WriteLine("Palindrome string");
            }
            else
            {
                Console.WriteLine("Not a palindrome string");
            }


        }
        public void upperstring()
        {
            string str = "hello world";

            string uppercaseStr = str.ToUpper();

            Console.WriteLine(uppercaseStr);
        }
        public void splitstring() 
        {
            string str = "apple,banana,orange";
            string[] strArray = str.Split(',');
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Armstrong();
            p.fibonaaci();
            p.upperstring();
            p.concat();
            p.splitstring();
            p.revstring();
            p.factorial();
            p.palindrome();
            p.primenumber();
            p.reversearry();
            p.pattern1();
            p.pattern2();  
            p.stringpalindrome();
            p.sumofarray();
            p.sumofdidgit();
            Console.ReadLine();


        }
    }
}
*/