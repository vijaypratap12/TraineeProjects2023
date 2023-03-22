using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priyanshu
{
    public class ClassA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ClassB
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }

    public class ClassC
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

   public class program
    { 
        static void Main(string[] args)
        {
            List<ClassA> classAList = new List<ClassA>()
            {
                new ClassA { Id = 1, Name = "Product A", Price = 9 },
                new ClassA { Id = 2, Name = "Product B", Price = 12 },
                new ClassA { Id = 3, Name = "Product C", Price = 799 }
            };

            List<ClassB> classBList = new List<ClassB>()
            {
                new ClassB { Number = 1, Description = "Item A", Date = new DateTime(2023, 03, 21) },
                new ClassB { Number = 2, Description = "Item B", Date = new DateTime(2023, 03, 22) },
                new ClassB { Number = 3, Description = "Item C", Date = new DateTime(2023, 03, 23) }
            };

            List<ClassC> classCList = new List<ClassC>()
            {
                new ClassC { FirstName = "nitish", LastName = "kamal", Age = 35 },
                new ClassC { FirstName = "vikram", LastName = "vedha", Age = 30 },
                new ClassC { FirstName = "ussain", LastName = "bolt", Age = 40 }
            };

            foreach (ClassA product in classAList)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Price: {2}", product.Id, product.Name, product.Price);
            }
            foreach (ClassB product in classBList)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Price: {2}", product.Number, product.Description, product.Date);
            }
            foreach (ClassC product in classCList)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Price: {2}", product.FirstName, product.LastName, product.Age);
            }
            Console.ReadLine();
        }
    }
}

