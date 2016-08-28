using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.StudentGroups;
namespace _11.ExtractStudentsByEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentsMethods.GetListOfStudents();

            students = students.Where(x => GetEmailDomain(x.Emai) == "abv.bg").ToList();
            
            students.PrintStudents();
        }

        public static string GetEmailDomain(string email)
        {
            return email.Split('@').ToArray()[1];
        }
    }
}
