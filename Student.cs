using System.ComponentModel.DataAnnotations;

namespace CourseEnrollApp;

public class Student
{
    public string Name { get; set; }
    public string RollNo { get; set; }
    public string Course { get; set; }

    public Student(string name, string rollNo, string course)
    {
        this.Name = name;
        this.RollNo = rollNo;
        this.Course = course;
    }

    public void Display()
    {
        Console.WriteLine("Student Name : " + this.Name);
        Console.WriteLine("Student Roll Number : " + this.RollNo);
        Console.WriteLine("Enrolled Course Name : " + this.Course);
    }
}
