using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>(){
                new Student(){Fname = "Gosho", lname = "Goshov"},
                new Student(){Fname = "Gosho", lname = "Batkov"},
                new Student(){Fname = "Alex", lname = "Shmatkov"},
                new Student(){Fname = "Borislav", lname = "Aleksiev"},
                new Student(){Fname = "Pencho", lname = "Kostadinov"}
            };
            
            students = students.Where(x => lexComparioson(x.Fname, x.lname)).ToList();
            foreach (var item in students)
            {
                Console.WriteLine("{0} - {1}", item.Fname, item.lname);
            }
            
        }

        public static bool lexComparioson( string a, string b)
        {
            int shortestLen = Math.Min(a.Length, b.Length);
            for (int i = 0; i < shortestLen; i++)
            {
                if (a[i] > b[i])
                {
                    return true;
                }
                else if (a[i] < b[i])
                {
                    return false;
                }
            }
            return false;
        }


    }
}
