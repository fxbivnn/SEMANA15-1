using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String regresar;
            Productos p=new Productos();
            do
            {
                Console.WriteLine("1. REGISTRAR");
                Console.WriteLine("2. MOSTRAR");
                Console.WriteLine("3. MODIFICAR");

                Console.Write("\nINGRESE OPCION: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:p.registrar();
                        break;
                    case 2:p.mostrar();
                        break;
                    case 3:p.modificar();
                        break;
                }
                Console.WriteLine("\nDESEA REGRESAR AL MENU? [si]: ");
                regresar=Console.ReadLine();
            }while (regresar=="si");
        }  
    }
}
