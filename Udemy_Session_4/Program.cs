using System;
using System.Globalization;
using List01;
using List02;
using List03;

namespace Udemy_Session_4
{
    class Program
    {
        static void Main( string[] args )
        {
            // Exs List01
            //Pessoas();
            //Funcionarios();

            // Exs List02
            //Retangulos();
            //Impostos();
            //Notas();

            // Exs List03
            //Cotações();
            Produtos();
        }

        // "Mains" Exs List01
        static void Pessoas()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade == p2.Idade)
            {
                Console.WriteLine($"\n{p1.Nome} e {p2.Nome} têm a mesma idade.");
            }
            else if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("\nPessoa mais velha: " + p2.Nome);
            }
        }

        static void Funcionarios()
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("\nSalário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }

        // "Mains" Exs List02
        static void Retangulos()
        {
            Retangulo r1 = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nAREA = {r1.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static void Impostos()
        {
            FuncionarioImposto func = new FuncionarioImposto();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nFuncionário: {func}");

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            Console.WriteLine($"\nDados atualizados: {func}");
        }

        static void Notas()
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"\nNOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            aluno.Situacao();
        }

        // "Mains" Exs List03
        static void Cotações()
        {
            Cotacao cotacao = new Cotacao();
            Console.Write("Qual é a cotação do dolar? ");
            cotacao.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            cotacao.QuantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cotacao.ValorTotal();
        }

        static void Produtos()
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {produto}");

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            produto.AdcionarProdutos(quantity);
            Console.WriteLine($"\nDados atualizados: {produto}");

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            quantity = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantity);

            Console.WriteLine($"\nDados atualizados: {produto}");
        }
    }
}