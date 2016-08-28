using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGroups;

namespace _09.StudentGroups
{
    public static class StudentsMethods
    {
       public static List<Student> GetListOfStudents()
       {
           var marks = new List<int>() { 3, 6, 2, 3, 6, 3, 3, 6, 5, 3, 5, 2 };
           return new List<Student>()
            {
                new Student("Pesho", "Goshov", 2, "696969", "0878696969", "sample@gmail.com", marks),
                new Student("Gosho", "Goshov", 3, "696969", "0878696969", "sample@abv.bg", marks),
                new Student("Tosho", "Goshov", 2, "696969", "0878696969", "sample@gmail.com", marks),
                new Student("Petkan", "Goshov", 1, "696969", "0878696969", "sample@gmail.com", marks),
                new Student("Orlin", "Goranov", 3, "696969", "0878696969", "sample@gmail.com", marks),
                new Student("Vesko", "Marinvo", 1, "696969", "0878696969", "sample@abv.bg", marks),
                new Student("Nasko", "Goshov", 2, "696969", "0878696969", "sample@gmail.com", marks),
                new Student("Sasho", "Goshov", 3, "696969", "0878696969", "sample@abv.bg", marks),
                new Student("Tsihp", "Goshov", 2, "696969", "0878696969", "sample@gmail.com", marks)
            };
       }

        public static void PrintStudents(this List<Student> studs)
        {
            foreach (var student in studs)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
