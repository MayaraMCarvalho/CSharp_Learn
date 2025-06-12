using System;
using System.Globalization;


namespace Udemy_Session_6
{
    public class Matriz1
    {
        public int[,] Matriz { get; set; }

        public void CriarMatriz()
        {
            Console.WriteLine("Digite o tamanho da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());
            Matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    Matriz[i, j] = int.Parse(line[j]);
                }
            }
        }

        public void Diagonal()
        {
            Console.WriteLine("Diagonal da Matriz: ");
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {               
               Console.Write(Matriz[i, i] + " ");  
            }
        }

        public void Negativos()
        {
            int count = 0;

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    if (Matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"\nNúmeros Negativo = {count}");
        }

        public void MatrizQuadrada()
        {
            CriarMatriz();
            Diagonal();
            Negativos();
        }

    }
}
