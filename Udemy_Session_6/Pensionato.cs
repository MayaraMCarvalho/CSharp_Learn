using System;
using System.Globalization;

namespace Udemy_Session_06
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Aluno( string nome, string email )
        {
            this.Nome = nome;
            this.Email = email;
        }
    }

    class Pensionato
    {
        public void Alugar()
        {
            Aluno[] pensionato = new Aluno[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse( Console.ReadLine() );

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nAluguel #{i + 1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Aluno aluno = new Aluno(nome, email);

                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse( Console.ReadLine() );
                pensionato[numeroQuarto] = aluno;
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < pensionato.Length; i++)
            {
                if (pensionato[i] != null)
                {
                    Console.WriteLine($"{i}: {pensionato[i].Nome}, {pensionato[i].Email}");
                }
            }
        }
    }
}
