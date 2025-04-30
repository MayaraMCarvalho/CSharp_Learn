using System;
using System.Globalization;

namespace Lists
{
    public class List03
    {
        public void Ex01()
        {
            int senhaCorreta = 2002;

            Console.WriteLine("*** Ex01 ***");
            Console.WriteLine("Digite a senha: ");

            int senha = int.Parse(Console.ReadLine());
            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }

        public void Ex02()
        {
            int X, Y;

            Console.WriteLine("*** Ex02 ***");
            Console.WriteLine("Digite as coordenadas: ");

            do
            {
                string[] vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0], CultureInfo.InvariantCulture);
                Y = int.Parse(vet[1], CultureInfo.InvariantCulture);

                if (X == 0 || Y == 0)
                    break;

                string result = (X, Y) switch
                {
                    (> 0, > 0) => "primeiro",
                    (< 0, > 0) => "segundo",
                    (< 0, < 0) => "terceiro",
                    (> 0, < 0) => "quarto",
                };

                Console.WriteLine(result);
            }
            while (X != 0 && Y != 0);
        }

        public void Ex03()
        {
            int codigo, alcool = 0, gasolina = 0, diesel = 0;

            Console.WriteLine("*** Ex03 ***");
            Console.WriteLine("Digite o código: ");

            do
            {
                codigo = int.Parse(Console.ReadLine());
                switch (codigo)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    default:
                        break;
                }
            }
            while (codigo != 4);

            Console.WriteLine($"MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }

    }
}