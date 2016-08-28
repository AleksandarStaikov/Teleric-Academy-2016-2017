using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.StudentGroups;
namespace _12.ExtractStudentsByPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentsMethods.GetListOfStudents();

            students = students.Where(x => x.Tel == "0878696969").ToList();

            students.PrintStudents();
        }
    }
}
