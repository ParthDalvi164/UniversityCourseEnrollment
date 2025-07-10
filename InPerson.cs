namespace CourseEnrollApp;

public class InPerson : Course
{
    public string Location { get; set; }
    public int TotalCount { get; set; }
    public List<Student> InPersonStudents { get; set; }

    public InPerson(string id, string name, string duration) : base(id, name, duration)
    {
        this.Location = "ROOM - 209[A]";
        this.InPersonStudents = new List<Student>();
    }

    public override void EnrollStudent(object obj)
    {
        Student stu = (Student)obj;
        if (InPersonStudents.Count > 10)
        {
            Console.WriteLine("Course capacity full! Cannot accomodate more than 10 students");
            return;
        }
        InPersonStudents.Add(stu);
        Console.WriteLine("Student enrolled successfully");
    }

    public void DisplayInPerson()
    {
        Console.WriteLine("Total online enrolled student : " + InPersonStudents.Count);
        foreach (Student stu in InPersonStudents)
        {
            stu.Display();
        }
    }
}
