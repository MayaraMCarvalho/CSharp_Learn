
namespace Ex02
{
    public class Teste02
    {
        public static async Task TesteAsync02()
        {
            var cts = new CancellationTokenSource();
            var tarefa = TesteTimeout(cts.Token);

            cts.CancelAfter(1000);

            try
            {
                var result = await tarefa;
                Console.WriteLine(result);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("The operation was canceled.");
            }

        }

        static async Task<string> TesteTimeout(CancellationToken token)
        {
            await Task.Delay(2000, token);
            return "TesteTimeout completed!";
        }
    }
}