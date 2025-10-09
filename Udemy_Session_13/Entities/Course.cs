namespace Udemy_Session_13.Entities
{
    public class Course
    {
        public string Name { get; set; }
        public HashSet<Student> Students { get; set; } = new HashSet<Student>();
    }
}
