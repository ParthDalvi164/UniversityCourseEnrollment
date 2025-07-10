namespace CourseEnrollApp;

public abstract class Course
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Duration { get; set; }

    public Course(string id, string name, string duration)
    {
        this.Id = id;
        this.Name = name;
        this.Duration = duration;
    }

    public abstract void EnrollStudent(object obj);
}
