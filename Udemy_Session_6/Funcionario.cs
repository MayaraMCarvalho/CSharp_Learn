using System;
using System.Globalization;


namespace Udemy_Session_06
{
    public class Funcionario
    {
        public int  Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario( int id, string nome, double salario )
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario( double perc )
        {
            Salario += perc * Salario / 100;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, ${Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

    public class Empresa
    {
        public List<Funcionario> Quadro { get; set; } = new List<Funcionario>();

        public void Cadastro()
        {
            Console.Write("Quantos funcionários deseja registrar: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"\nFuncionário #{i}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Quadro.Add(new Funcionario(id, nome, salario));
            }
        }

        public void Aumento()
        {

            Console.Write("\nDigite o id do funcionário que deseja aumentar o salário: ");
            int idFunc = int.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem: ");
            double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario func = Quadro.Find(f => f.Id == idFunc);

            if (func == null)
            {
                Console.WriteLine("Esse id não existe!");
            }
            else
            {
                func.AumentarSalario(perc);
            }
        }

        public void Listar()
        {
            Console.WriteLine("\nLista atualizada dos funcionários:");
            foreach (Funcionario func in Quadro)
            {
                Console.WriteLine(func.ToString());
            }
        }
    }
}
