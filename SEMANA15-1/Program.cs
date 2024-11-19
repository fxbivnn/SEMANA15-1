using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas;
            Random rnd = new Random();
            Console.Write("INGRESE EL NUMERO DE FILAS: ");
            filas=int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL NUMERO DE COLUMNAS: ");
            columnas=int.Parse(Console.ReadLine());

            int[,] matriz=new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(30, 50);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
