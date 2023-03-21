using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sachin_project.Programs_for_practices
{
    internal class CountVowel
    {
        int vowels=0, consonants=0, special = 0;
        public void clounvovel(string str)
        {
            char[] chars = str.ToCharArray();
            int n=chars.Length;
           
            
                for (int i = 0; i<n; i++)
                {
                    if ((chars[i] == 'a' || chars[i] == 'e' || chars[i] ==
                    'i' || chars[i] == 'o' || chars[i] == 'u') ||
                    (chars[i] == 'A' || chars[i] == 'E' || chars[i] ==
                    'I' || chars[i] == 'O' || chars[i] == 'U'))
                    {
                        vowels = vowels + 1;
                    }
                   else if( chars[i] == '\0' || chars[i] == ' ')
                    {
                    special = special + 1;
                    } 
                    else
                    {
                        consonants = consonants + 1;
                    }
                    
                   
                }
            Console.WriteLine("Total Vowels is in String : " + vowels);
            Console.WriteLine("Total consonants is in String : " + consonants);
            Console.WriteLine("Total Special character is in String : " + special);
        }

        }
    }

