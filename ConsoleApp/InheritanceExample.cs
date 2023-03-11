using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class InheritanceExample
    {
    }
    public class Employee
    {
        public void AddEmployee()
        {
            Console.WriteLine("This will add employee");
            Console.WriteLine("This will add employee");
        }

    }
    public class Company:Employee
    {
        public void ShowEmployee()
        {
            Console.WriteLine("This is show employee");
        }
    }
//    sealed class Vehicle
//    {
//}

//    class Car : Vehicle
//    {
//}
}
