//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp
//{
//    public class AbstractExample
//    {

//    }
//    // Abstract class
//    abstract class Animal
//    {
//        // Abstract method (does not have a body)
//        public abstract void animalSound();
//        // Regular method
//        public static void sleep()
//        {
//            Console.WriteLine("ZZZ");
//        }
//    }

//    // Derived class (inherit from Animal)
//    class Dog : Animal
//    {
//        public override void animalSound()
//        {
//            // The body of animalSound() is provided here
//            Console.WriteLine("Boggyman");
//            Console.ReadLine();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dog obj = new Dog();
//            obj.animalSound();
//        }
//    }
//}
