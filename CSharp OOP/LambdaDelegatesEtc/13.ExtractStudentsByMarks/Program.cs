using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.StudentGroups;
namespace _13.ExtractStudentsByMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentsMethods.GetListOfStudents();

            students = students.Where(x => x.Marks.Contains(6)).ToList();

            students.PrintStudents();
        }
    }
}
