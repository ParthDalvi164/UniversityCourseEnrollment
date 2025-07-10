

namespace CourseEnrollApp;


public class Program
{
    public Student AddStudent(string course)
    {
        Console.WriteLine("Enter student name : ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Roll Number : ");
        string rollno = Console.ReadLine();

        Student student = new Student(name, rollno, course);
        return student;
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        bool exit = false;
        Student student;
        Online online = new Online("120", "C# Fundamentals", "80 HRS");
        InPerson inperson = new InPerson("130", "ASP.NET Fundamentals", "90 HRS");
        Lab lab = new Lab("140", "ANGULAR.JS Fundamentals", "100 HRS");

        while (!exit)
        {
            Console.WriteLine("STUDENT-COURSE ENROLLMENT FORM");
            Console.WriteLine("\n1. ONLINE MODE \n2. IN-PERSON MODE \n3. LAB MODE");
            Console.WriteLine("ENTER YOUR CHOICE : ");
            string userResp = Console.ReadLine();

            switch (userResp)
            {
                case "1":
                    student = p.AddStudent("Online");
                    online.EnrollStudent(student);
                    online.DisplayOnline();
                    break;
                case "2":
                    student = p.AddStudent("In-Person");
                    inperson.EnrollStudent(student);
                    inperson.DisplayInPerson();
                    break;
                case "3":
                    student = p.AddStudent("Lab");
                    lab.EnrollStudent(student);
                    lab.DisplayOnline();
                    break;
                case "4":
                    exit = true;
                    break;
            }
        }
    }
}