using System;
using System.Globalization;

namespace List02
{
    public class Retangulo
    {
        public double   Largura;
        public double   Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }

    public class FuncionarioImposto
    {
        public string   Nome;
        public double   SalarioBruto;
        public double   Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario( double porcentagem )
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    public class Aluno
    {
        public string  Nome;
        public double  Nota1, Nota2, Nota3;
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void Situacao()
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

        public double NotaRestante()
        {
            return 60.0 - NotaFinal();
        }
    }
}
