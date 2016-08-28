using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Course
    {
        private List<Student> students;

        private string name;

        public Course(string name)
        {
            this.students = new List<Student>();
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name can not be null or empty!");
                }
                
                name = value;
            }
        }

        public void AddStudent(Student actor)
        {
            if (students.Any(x => x.ID == actor.ID))
            {
                throw new InvalidOperationException("This student is already in the class");
            }
            if (this.students.Count >= 30)
            {
                throw new InvalidOperationException("Course is full!");
            }

            this.students.Add(actor);
        }

        public void RemoveStudent(Student actor)
        {
            if (!this.students.Contains(actor))
            {
                throw new NullReferenceException("In this course there is no such student!");
            }

            this.students.Remove(actor);
        }

    }
}
