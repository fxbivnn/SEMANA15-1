using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    internal class Productos
    {       
       string[,] productos = new string[0, 3];
       int cantidad = 0;

            public void redimensionar(int nuevoTamano)
            {
                string[,] nuevoArreglo = new string[nuevoTamano, 3];

                for (int i = 0; i < cantidad; i++)
                {
                    for (int j = 0; j < productos.GetLength(1); j++)
                    {
                        nuevoArreglo[i, j] = productos[i, j];
                    }
                }
            }
            public void registrar()
            {
                redimensionar(cantidad + 1);
                Console.Write("INGRESE NOMBRE: ");
                productos[cantidad, 0] = Console.ReadLine();
                Console.Write("INGRESE PRECIO: ");
                productos[cantidad, 1] = Console.ReadLine();
                Console.Write("INGRESE STOCK: ");
                productos[cantidad, 2] = Console.ReadLine();

                cantidad++;
                Console.WriteLine("\nPRODUCTO REGISTRADO CORRECTAMENTE");

            }
            public void mostrar()
            {
                if (cantidad == 0)
                {
                    Console.WriteLine("\nNO EXITEN PRODUCTOS");
                    return;
                }
                else
                {
                    Console.WriteLine("PRODUCTOS REGISTRADOS: ");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine($"PRODUCTO {i + 1}: ");
                        Console.WriteLine($"NOMBRE: {productos[i, 0]}");
                        Console.WriteLine($"PRECIO: {productos[i, 1]}");
                        Console.WriteLine($"STOCK: {productos[i, 2]}");
                        Console.WriteLine();
                    }
                }
            }
        public void modificar()
        {
            Console.Write("\nINGRESE NUMERO A MODIFICAR: ");
            int indice=int.Parse( Console.ReadLine());

            Console.WriteLine("\nINGRESE NUEVO NOMBRE: ");
            productos[indice,0]=Console.ReadLine();
            Console.WriteLine("\nINGRESE NUEVO PRECIO: ");
            productos[indice, 1] = Console.ReadLine();
            Console.WriteLine("\nINGRESE NUEVO STOCK: ");
            productos[indice, 2] = Console.ReadLine();

            Console.WriteLine("\nPRODUCTO MODIFICADO CORRECTAMENTE");
        }
          
        
    }
}
    

