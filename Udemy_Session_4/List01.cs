using System.Globalization;

namespace List01
{
    public class Pessoa
    {
        string   Nome;
        int      Idade;

        public static void Cadastro()
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


    }

    public class Funcionario
    {
        string   Nome;
        double   Salario;

        public static void Cadastro()
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
    }
}