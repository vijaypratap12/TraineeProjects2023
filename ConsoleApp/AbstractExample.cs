using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class AbstractExample
    {

    }
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("ZZZ");
        }
    }

    // Derived class (inherit from Animal)
    class Dog : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("Boggyman");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Pig myPig = new Pig(); // Create a Pig object
    //        myPig.animalSound();  // Call the abstract method
    //        myPig.sleep();  // Call the regular method
    //    }
    //}
}
