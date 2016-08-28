using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNumber { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Emai { get; set; }
        public List<int> Marks { get; set; }

        public Student(string firstName, string lastName, int groupNumber, string fn, string tel, string emai, List<int> marks)
        {
            FirstName = firstName;
            LastName = lastName;
            GroupNumber = groupNumber;
            FN = fn;
            Tel = tel;
            Emai = emai;
            Marks = marks;
        }
    }
}
