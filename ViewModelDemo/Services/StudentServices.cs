using System.Collections.Generic;
using ViewModelDemo.Models;

namespace ViewModelDemo.Services
{
    public static class StudentServices
    {
        static List<Student> students = new List<Student>();
        public static void AddStudents()
        {
            Student student = new Student();
            student.Id=1;
            student.Name = "Florian";
            student.City = "Brussel";
            students.Add(student);

            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "Fatih";
            student2.City = "Louvain";
            students.Add(student2);

            Student student3 = new Student();
            student3.Id = 3;
            student3.Name = "Sagar";
            student3.City = "Antwerpen";
            students.Add(student3);
        }
        public static List<Student> GetAllStudent()
        {
            AddStudents();
            return students;
        }
    }
}
