namespace CourseEnrollApp;

public class Online : Course
{
    public string platformUrl { get; set; }
    public int TotalCount { get; set; }
    public List<Student> OnlineStudents { get; set; }

    public Online(string id, string name, string duration) : base(id, name, duration)
    {
        this.platformUrl = "https://swabhavtechlabs.com/studyonline";
        this.OnlineStudents = new List<Student>();
    }

    public override void EnrollStudent(object obj)
    {
        Student stu = (Student)obj;
        if (OnlineStudents.Count > 20)
        {
            Console.WriteLine("Course capacity full! Cannot accomodate more than 10 students");
            return;
        }
        OnlineStudents.Add(stu);
        Console.WriteLine("Student enrolled successfully");
    }

    public void DisplayOnline()
    {
        Console.WriteLine("Total online enrolled student : " + OnlineStudents.Count);
        foreach (Student stu in OnlineStudents)
        {
            stu.Display();
        }
    }
}
