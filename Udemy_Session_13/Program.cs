using Udemy_Session_13.Entities;

namespace Udemy_Session_13
{
    class Program
    {
        static void Main()
        {
            HashSet<Course> courses = new HashSet<Course> { new Course { Name = "A" }, new Course { Name = "B" }, new Course { Name = "C" } };
            HashSet<Student> total = new HashSet<Student>();

            foreach (var course in courses)
            {
                Console.Write($"How many students for course {course.Name}? ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    int id = int.Parse(Console.ReadLine());
                    course.Students.Add(new Student { Id = id });
                }

                total.UnionWith(course.Students);
            }

            Console.WriteLine("Total students: " + total.Count);
        }
    }
}