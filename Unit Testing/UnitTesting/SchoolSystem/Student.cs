using System;

namespace SchoolSystem
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null or empty!");
                }
                
                name = value;
            }
        }

        public int ID { get; set; }
    }
}
