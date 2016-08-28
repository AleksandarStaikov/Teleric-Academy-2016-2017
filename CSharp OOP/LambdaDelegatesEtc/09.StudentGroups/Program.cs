using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGroups;


namespace _09.StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentsMethods.GetListOfStudents();

            students = students
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToList();

            var students2 = from s in students
                where s.GroupNumber == 2
                select new {FullName=s.FirstName + " " + s.LastName};


            foreach (var stud in students)
            {
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
            }
        }
    }
}
