using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy01
{

    //student
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }



        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }

    }

    //course
    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees;


        public Course(int id, string name, int dura, float fee)
        {
            this.Id = id;
            this.Name = name;
            this.duration = dura;
            this.fees = fee;
        }

    }
    public class Info
    {
        public void display(Student student)
        {
            Console.WriteLine($"The student details is student id : {student.Id}, student name : {student.Name}, student dob : {student.DOB}");

        }



        public void display(Course course)
        {
            Console.WriteLine($"The student id : {course.Id}, student name : {course.Name}, course duration is : {course.duration}, course fee is : {course.fees}");
        }
    }
    internal class App
    {
        Info info = new Info();


        //scenerio 1
        public void Scenerio1()
        {
            Student student = new Student(1061, "vinod", "05/09/1999");
            Student student1 = new Student(1062, "Bantu", "01/07/1998");

            info.display(student);
            info.display(student1);
        }



        //scenerio 2
        public void Scenerio2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(500, "ramu", "15/08/1999");
            students[1] = new Student(550, "sita", "01/01/2000");
            for (int i = 0; i < students.Length; i++)
            {
                info.display(students[i]);

            }
        }

        //scenerio 3
        public void Scenerio3()
        {
            Student[] student = new Student[3];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Student Id,Name and Date of Birth");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());


            }
            for (int i = 0; i < student.Length; i++)
            {
                info.display(student[i]);
            }
        }



        public void courseclass()
        {
            Course course = new Course(101, "Laxman", 25, 1500.00f);
            info.display(course);
        }
        static void Main(string[] args)
        {
            App app = new App();
            app.Scenerio1();
            app.Scenerio2();
            app.Scenerio3();
            app.courseclass();
            Console.Read();
        }
    }
}
