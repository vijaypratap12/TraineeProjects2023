using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class User
    {
        public string Name = "XYZ";
    }
    public class RefType
    {
        static void Main(string[] args)
        {
            User user = new User();
            User user2 = user;
            Console.WriteLine(user2.Name);
            Console.WriteLine(user.Name);


            user2.Name = "Vijay";
            Console.WriteLine(user2.Name);
            Console.WriteLine(user.Name);
            Console.ReadLine();
        }
    }
}
