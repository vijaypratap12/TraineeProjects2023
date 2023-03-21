using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class ReverseArray
    {
       
        public void ReverseArray1(int[] arr) { 
         int n= arr.Length, temp;

            /*Array.Reverse(arr);
        for (int i = 0; i < arr.Length; i++)
            Console.Write("  "+arr[i]);*/

            for (int i = 0; i < n / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write("  " + arr[i]);


        }
    }
}
