using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class ReverseString
    {
        public void ReverseString1( string str ) {
            char[] chars = str.ToCharArray();
            string strev = "";
            int n=chars.Length;
            for( int i=n-1; i>=0; i-- )
            {
                strev += chars[i];
            }
            Console.WriteLine("Reverse String is "+ strev );
        
        }
    }
}
