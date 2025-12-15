using Ex01;
using Ex02;
using Ex03;

namespace Udemy_Session_17
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Udemy - Session 17 - Async/Await - Part 01");
            await Teste01.TesteAsync01();

            Console.WriteLine("\n\nAsync/Await - Part 02");
            await Teste02.TesteAsync02();

            Console.WriteLine("\n\nAsync/Await - Part 03");
            await Teste03.TesteAsync03();
        }
    }
}
