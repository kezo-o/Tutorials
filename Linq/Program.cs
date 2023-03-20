using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new List<Student>() {
                new Student(1, "John", 13) ,
                new Student(2, "Moin", 21) ,
                new Student(3, "Bill", 18) ,
                new Student(4, "Ram", 20) ,
                new Student(5, "Ron", 15)
            };

            #region Where

            // Query syntax
            IEnumerable<string> filteredResult;
            filteredResult = from s in studentList
                             where s.Age > 12 && s.Age < 20
                             select s.StudentName;

            // Method syntax
            filteredResult = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                             .Select(s => s.StudentName);

            // Query syntax
            filteredResult = from s in studentList
                             where IsTeenAger(s)
                             select s.StudentName;

            // Method syntax
            filteredResult = studentList.Where(s => IsTeenAger(s))
                                        .Select(s => s.StudentName);

            var students = studentList.Where((s, index) =>
            {
                if (index % 2 == 0) // if it is even element
                    return true;

                return false;
            });

            foreach (var std in students)
                Console.WriteLine(std.StudentName);

            Console.ReadKey();

            #endregion

            #region OrderBy

            #endregion

        }

        public static bool IsTeenAger(Student stud)
        {
            return stud.Age > 12 && stud.Age < 20;
        }
    }
}
