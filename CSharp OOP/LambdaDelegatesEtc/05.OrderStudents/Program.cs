using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OrderStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>(){
                new Student(){Fname = "Gosho", lname = "Goshov", Age = 14},
                new Student(){Fname = "Gosho", lname = "Batkov", Age = 19},
                new Student(){Fname = "Borislav", lname = "Shmatkov", Age = 32},
                new Student(){Fname = "Borislav", lname = "Aleksiev", Age = 18},
                new Student(){Fname = "Pencho", lname = "Kostadinov", Age = 21},
                new Student(){Fname = "Pencho", lname = "Genchov", Age = 21}
            };

            students = students.OrderBy(x => x.Fname).ThenBy(x=>x.lname).ToList();

            foreach (var student in students)
            {
                Console.WriteLine("{0} - {1}", student.Fname, student.lname);
            }
        }
    }
}
