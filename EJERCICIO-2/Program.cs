using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Random rnd = new Random();
            Console.WriteLine("INGRESE NUMERO DE MATRIZ: ");
            num=int.Parse(Console.ReadLine());

            int[,] matriz= new int[num,num];
            int[,] transpuesta= new int[num,num];

            Console.WriteLine("\nMATRIZ ORIGINAL: ");
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    matriz[i, j] = rnd.Next(40, 51);
                    Console.WriteLine(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            Console.WriteLine("\nMATRIZ TRANSPUESTA: \n");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    transpuesta[j, i] = matriz[i, j];                 
                }         
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {               
                    Console.WriteLine(transpuesta[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
