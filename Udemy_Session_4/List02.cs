using System;
using System.Globalization;

namespace List02
{
    public class Retangulo
    {
        double   Largura;
        double   Altura;

        double Area()
        {
            return Largura * Altura;
        }
        double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public static void Medidas()
        {
            Retangulo r1 = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nAREA = {r1.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }

    public class FuncionarioImposto
    {
        string   Nome;
        double   SalarioBruto;
        double   Imposto;

        double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        void AumentarSalario( double porcentagem )
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public static void Impostos()
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

       
    }

    public class Aluno
    {
        string  Nome;
        double  Nota1, Nota2, Nota3;
        double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        void Situacao()
        {
            if (NotaFinal() >= 60.0)
            {
                 Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");

            }
        }

        double NotaRestante()
        {
            return 60.0 - NotaFinal();
        }

        public static void Notas()
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
    }
}
