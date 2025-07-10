namespace CourseEnrollApp;

public class Lab : Course
{
    public string LabNumber { get; set; }
    public int TotalCount { get; set; }
    public List<Student> LabStudents { get; set; }

    public Lab(string id, string name, string duration) : base(id, name, duration)
    {
        this.LabNumber = "LAB - 05";
        this.LabStudents = new List<Student>();
    }

    public override void EnrollStudent(object obj)
    {
        Student stu = (Student)obj;
        if (LabStudents.Count > 5)
        {
            Console.WriteLine("Course capacity full! Cannot accomodate more than 10 students");
            return;
        }
        LabStudents.Add(stu);
        Console.WriteLine("Student enrolled successfully");
    }

    public void DisplayOnline()
    {
        Console.WriteLine("Total online enrolled student : " + LabStudents.Count);
        foreach (Student stu in LabStudents)
        {
            stu.Display();
        }
    }
}
