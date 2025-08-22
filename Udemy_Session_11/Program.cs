using System.Globalization;
using Udemy_Session_11.Entities;

namespace Udemy_Session_9
{
    class Program
    {
        static void Main()
        {
            // Ex. 11.1
            Console.WriteLine("Enter file full path: ");
            string srcFilepath = Console.ReadLine()!;

            string path = Path.GetDirectoryName(srcFilepath) + Path.DirectorySeparatorChar;

            try
            {
                using StreamReader srcFile = File.OpenText(srcFilepath);
                string[] lines = File.ReadAllLines(srcFilepath);

                Directory.CreateDirectory(path + @"\out");

                using StreamWriter outFile = File.CreateText(path + @"\out\summary.csv");
                foreach (string line in lines)
                {
                    string[] columns = line.Split(',');

                    Product prod = new(
                        columns[0],
                        double.Parse(columns[1],CultureInfo.InvariantCulture),
                        int.Parse(columns[2]));

                    outFile.WriteLine($"{prod.Name},{prod.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
