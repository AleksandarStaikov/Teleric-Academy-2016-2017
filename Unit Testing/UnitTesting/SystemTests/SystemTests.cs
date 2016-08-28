using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;

namespace SystemTests
{
    [TestClass]
    public class SystemTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void CreatingStudentWithEmptyNameShouldThrow()
        {
            var stud = new Student("");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void CreatingStudentWithNullNameShouldThrow()
        {
            var student = new Student(null);
        }

        [TestMethod]
        public void CreatingStudentWithLongNameShouldWork()
        {
            var name = "Skalshsasasdasdsadasdasdasdasdasdasdasdasdasdasdasdkhasdkjshakjvhksljhfdlkjqwhiuwegfbkjvbx,mzncasjh,sjvbs,jvc,mz";
            var student = new Student(name);

            Assert.AreEqual(name, student.Name);
        }

        [TestMethod]
        public void CreateSchoolWithValidNameSholdWork()
        {
            var school = new School("SPGE");

            Assert.AreEqual("SPGE", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateSchoolWithNullNameShouldThrow()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingSchoolWithEmptyStringAsNameShouldThrow()
        {
            var school = new School("");
        }

        [TestMethod]
        public void CreatingCourseWithValidNameShouldWork()
        {
            var name = "Sistemno Programirane Bace";
            var course = new Course(name);

            Assert.AreEqual(name, course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingCourseWithEmptyStringAsNameShouldThrow()
        {
            var course = new Course("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingCourseWithNullAsNameShouldThrow()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingTheSameStudentToTheSameSchoolMoreThanOnceShouldThrow()
        {
            var student = new Student("pesho");
            var school = new School("SPGE");

            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        public void AddingMaxNumberOfStudentsToTheSameCourseShouldWork()
        {
            var course = new Course("Sistemno Programirane");
            var school = new School("SPGE");
            for (int i = 0; i < 30; i++)
            {
                var stud = new Student(1.ToString());
                school.AddStudent(stud);
                course.AddStudent(stud);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingTooMuchStudentsToTheSameCourseShouldThrow()
        {
            var course = new Course("Sistemno Programirane");
            var school = new School("SPGE");
            for (int i = 0; i < 31; i++)
            {
                var stud = new Student(1.ToString());
                school.AddStudent(stud);
                course.AddStudent(stud);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingMoreStudentsThanTheUniqueIdCombinationsShouldThrow()
        {
            var school = new School("SPGE");
            for (int i = 0; i < 90000; i++)
            {
                var stud = new Student(1.ToString());
                school.AddStudent(stud);
            }
        }

        [TestMethod]
        public void AddingMaxStudentsWithUniqueIdCombinationsShouldWork()
        {
            var school = new School("SPGE");
            for (int i = 0; i < 89999; i++)
            {
                var stud = new Student(1.ToString());
                school.AddStudent(stud);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingTheSameStudentToTheSameCourseTwiceShouldThrow()
        {
            var stud = new Student("Gosho");
            var school = new School("SPGE");
            var course = new Course("SYS Programing");

            school.AddStudent(stud);

            course.AddStudent(stud);
            course.AddStudent(stud);
        }

        [TestMethod]
        public void RemovingExistingStudentFromCourseShouldWork()
        {
            var stud = new Student("pak gosho");
            var school  = new School("TUES");
            var course = new Course("Neshto");

            school.AddStudent(stud);
            course.AddStudent(stud);
            course.RemoveStudent(stud);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemovingSameStudentFromCourseTwiceShouldThrow()
        {
            var stud = new Student("pak gosho");
            var school = new School("TUES");
            var course = new Course("Neshto");

            school.AddStudent(stud);
            course.AddStudent(stud);
            course.RemoveStudent(stud);
            course.RemoveStudent(stud);
        }
    }
}
