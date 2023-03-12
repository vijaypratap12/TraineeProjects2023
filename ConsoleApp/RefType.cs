using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        string emp3 = "Uhtred";
        string emp4 = "Demon";

        //constructor
        public RefType(string emp1, string emp2)
        {
            emp1 = emp3;
            emp2 = emp4;    
        }
        public string Employee()
        {
            return emp3+emp4;
        }
        //method overloading
        public int Employee(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            User user = new User();
            RefType refType = new RefType("Baba", "Yaga");
            User user2 = user;
            Console.WriteLine(user2.Name);
            Console.WriteLine(user.Name);


            user2.Name = "Vijay";
            Console.WriteLine(user2.Name);
            Console.WriteLine(user.Name);

            string name = refType.Employee();
            int val = refType.Employee(10, 20);
            Console.WriteLine(name);
            Console.WriteLine(val);


            //control statements
            ControlStatements control = new ControlStatements();
            
            int result = control.ConditionOne();
            control.SwitchCase(2);
            Console.WriteLine(result);
            Console.WriteLine("Added for github");
<<<<<<< HEAD
=======
            Console.WriteLine("Added for github");
            Console.WriteLine("Added for github");
>>>>>>> d98fd792fdab266b6c8e8cf7b947405e3e570cf5
            Console.ReadLine();
        }
    }
}
