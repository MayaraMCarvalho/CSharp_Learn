using Udemy_Session_13.Entities;

namespace Udemy_Session_13
{
    class Program
    {
        static void Main()
        {
            // Ex 13.1 - HashSet
            //UseHashSet();

            // Ex 13.2 - Dictionary
            UseDictionary();

        }

        public static void UseHashSet()
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

        public static void UseDictionary()
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');

                        string name = fields[0];
                        int vote = int.Parse(fields[1]);

                        if (votes.ContainsKey(name))
                        {
                            votes[name] += vote;
                        }
                        else
                        {
                            votes[name] = vote;
                        }
                    }

                    foreach (var item in votes)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

