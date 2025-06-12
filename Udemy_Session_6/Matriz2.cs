using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Session_6
{
    public class Matriz2
    {
        public int[,] Matriz { get; set; }

        public void CriarMatriz()
        {
            Console.WriteLine("Digite o tamanho da matriz: ");
            string[] tam = Console.ReadLine().Split(' ');
            int m = int.Parse(tam[0]);
            int n = int.Parse(tam[1]);

            Matriz = new int[m, n];
        }

        public void PreencherMatriz()
        {
            Console.WriteLine("\nDigite os valores da matriz: ");
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = int.Parse(line[j]);
                }
            }
        }

        public void Pesquisar()
        {
            bool control = false;

            Console.WriteLine("\nDigite o valor a ser pesquisado: ");
            int x = int.Parse(Console.ReadLine());

            int line = Matriz.GetLength(0);
            int column = Matriz.GetLength(1);

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (Matriz[i, j] == x)
                    {
                        Console.WriteLine($"\nPosição {i}, {j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: {Matriz[i, j - 1]}");
                        }
                        if (j < column - 1)
                        {
                            Console.WriteLine($"Direita: {Matriz[i, j + 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Acima: {Matriz[i - 1, j]}");
                        }
                        if (i < line - 1)
                        {
                            Console.WriteLine($"Abaixo: {Matriz[i + 1, j]}");
                        }
                        
                        control = true;
                    }
                }
            }
            if (!control)
            {
                Console.WriteLine("Valor não encontrado na matriz.");
            }
        }

        public void NovaMatriz()
        {
            CriarMatriz();
            PreencherMatriz();
            Pesquisar();
        }
    }
}
