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

    public class Teacher
    {
        Student student = new Student();
        List<Student> students = new List<Student>();
      
       // List<Student> students;
        public void PrintProperties()
        {

            //foreach(var i in students)
            //{
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

            foreach( var i in studentList)
            {
                Console.WriteLine(i.StudentID);
                Console.WriteLine(i.StudentName);
               
            }
            student.StudentID = 101;
            student.StudentName = "Vijay";
            //student.Age = 55;
         
            Console.WriteLine(student.StudentID);
            Console.WriteLine(student.StudentName);
            //Console.WriteLine(student.StudentAge);
            Console.ReadLine();
           // }
            
        }
    }
    public class ControlStatements
    {

        public int ConditionOne()
        {
            int a = 10;
            int b = 30;
            while (--a == 9)
            {
                return a;
            }
            return a + b;
        }
        public void ConditionThree()
        {
            int[] arr = { 10, 20, 30, 40 };
            foreach(object i in arr)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
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
            List<string> stringList;
            List<int> firstlist = new List<int>();
            Console.WriteLine(firstlist.Capacity);
            Console.WriteLine();
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
            firstlist.Remove(5);
            firstlist.Remove(6);
            firstlist.TrimExcess();

            
            // Printing the Capacity of firstlist
            // It will give output 8 as internally
            // List is resized
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);
            firstlist.Clear();
            Console.WriteLine("Count after clear is " + firstlist.Count);
            Console.WriteLine("Capacity after clear is " + firstlist.Capacity);
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

            foreach(var i in studentList)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20 && s.StudentName=="Bob"
                                  select s;


            //where clause
            var filteredResult = studentList.Where((s, i) =>
            {
                if (i % 2 == 0) // if it is even element
                    return true;

                return false;
            });

            //var result = from s in studentList where s.StudentName =="Bob" 
            return teenAgerStudent;
        }
    }
}
