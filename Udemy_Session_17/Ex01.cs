namespace Ex01
{
    public class Teste01
    {
        public static async Task TesteAsync01()
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();

            var tarefa1 = BaixaAsync(3000);
            var tarefa2 = BaixaAsync(2000);
            var tarefa3 = BaixaAsync(1000);

            var resultados = await Task.WhenAll(tarefa1, tarefa2, tarefa3);

            sw.Stop();

            foreach (var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }

            Console.WriteLine($"Total time: {sw.ElapsedMilliseconds} ms");
        }

        static async Task<string> BaixaAsync(int ms)
        {
            await Task.Delay(ms);

            return $"Download completed in: {ms} ms";
        }
    }
}