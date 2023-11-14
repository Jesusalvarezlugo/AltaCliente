using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCliente.Servicios
{
    internal class menuImplementacion : menuInterfaz
    {
        public void MostrarMensajeBienvenida()
        {
            string mensaje = "Banco CSI1";

            Console.WriteLine(mensaje);
        }

        public int MostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("\t\t\t╔══════════════════════════════╗");
            Console.WriteLine("\t\t\t║             MENU             ║");
            Console.WriteLine("\t\t\t╠══════════════════════════════╣");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║    1.- Darse de alta         ║");
            Console.WriteLine("\t\t\t║    2.- Ingresar dinero       ║");
            Console.WriteLine("\t\t\t║    3.- Sacar dinero          ║");
            Console.WriteLine("\t\t\t║    4.- Transferir dinero     ║");
            Console.WriteLine("\t\t\t║    5.- Historial operaciones ║");
            Console.WriteLine("\t\t\t║          0) Salir            ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t╚══════════════════════════════╝");
            Console.WriteLine("\t\tIntroduce una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public string NuevoAltaCliente()
        {
            string respuesta;

            Console.WriteLine("Desea hacer un nuevo alta de cliente(s/n)");
            respuesta = Console.ReadLine();

            return respuesta;
        }
    }
}
