using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public class ControlStatements
    {

        public int ConditionOne()
        {
            int a = 10;
            int b = 30;
            while (a-- == 9)
            {
                return a;
            }
            return a + b;
        }

        public void SwitchCase(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Jan");

                    break;
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Not movin further");
                    break;

            }
        }
        public void ConditionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public void ListExample()
        {
            List<int> firstlist = new List<int>();

            // adding elements in firstlist
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);

            // Printing the Capacity of firstlist
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            // Adding some more
            // elements in firstlist
            firstlist.Add(5);
            firstlist.Add(6);

            // Printing the Capacity of firstlist
            // It will give output 8 as internally
            // List is resized
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);
        }

        public IEnumerable<Student> LINQExample()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;


            //where clause
            var filteredResult = studentList.Where((s, i) => {
                if (i % 2 == 0) // if it is even element
                    return true;

                return false;
            });
            return teenAgerStudent;
        }
    }
}
