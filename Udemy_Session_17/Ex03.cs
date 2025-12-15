
namespace Ex03
{
    public class Teste03
    {
        public static async Task TesteAsync03()
        {
            using var cts = new CancellationTokenSource();
            cts.CancelAfter(700);

            try
            {
                var dados = await LerAsync(cts.Token);
                var processado = await ProcessarAsync(dados, cts.Token);
                await SalvarAsync(processado, cts.Token);
                Console.WriteLine("Pipeline concluído com sucesso!\n");

            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Pipeline cancelado (timeout ou usuário).");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro de validação: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Erro de negócio: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }

        }

        static async Task<string> LerAsync(CancellationToken token)
        {
            Console.WriteLine("Lendo dados...");
            await Task.Delay(500);
            token.ThrowIfCancellationRequested();

            var dados = "dados brutos";
            Console.WriteLine("Leitura concluída!\n");

            return dados;
        }

        static async Task<string> ProcessarAsync(string input, CancellationToken token)
        {
            Console.WriteLine("Processando dados...");
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Entrada vazia.");
            }

            var resultado = await Task.Run(() =>
            {
                token.ThrowIfCancellationRequested();

                if (input.Contains("lidos"))
                {
                    throw new InvalidOperationException("Formato de dados inválido para processamento.");
                }

                return input.Trim().ToUpperInvariant();
            });

            Console.WriteLine("Dados processados com sucesso!\n");
            return resultado;
        }

        static async Task SalvarAsync(string conteudo, CancellationToken token)
        {
            Console.WriteLine("Salvando dados...");
            await Task.Delay(800);
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Dados salvos: {conteudo}\n");
        }
    }
}