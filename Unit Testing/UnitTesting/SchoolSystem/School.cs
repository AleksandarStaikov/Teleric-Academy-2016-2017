using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class School
    {
        private const int StudentsMaxID = 99999;

        private int IDs = 10000;
        private string name;
        private List<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.students =  new List<Student>();
        }

        public string Name {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("School name can not be null or empty!");
                }
                this.name = value;
            } }

        public void AddStudent(Student actor)
        {
            if (this.IDs >= StudentsMaxID)
            {
                throw new InvalidOperationException("Max ID reached!");
            }
            actor.ID = this.IDs++;

            if (students.Contains(actor))
            {
                throw new InvalidOperationException("This student is already in the class");
            }
            this.students.Add(actor);
        }
    }
}
