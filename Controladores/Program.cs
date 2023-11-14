using AltaCliente.Dto;
using AltaCliente.Servicios;

namespace AltaCliente.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            ClienteDto cliente1 = new ClienteDto();
            menuInterfaz mi = new menuImplementacion();
            operativaInterfaz oi = new operativaImplementacion();
            string respuesta = "";
            
            int opcionS;
            bool cerrarMenu = false;

            while (!cerrarMenu||respuesta == "s")
            {
                mi.MostrarMensajeBienvenida();

                opcionS = mi.MostrarMenuYSeleccion();

                

                switch (opcionS)
                {
                    case 0:
                        cerrarMenu = true;
                        break;

                    case 1:

                        oi.DarAltaCliente(listaClientes);
                                               
                        break;
                }

                respuesta = mi.NuevoAltaCliente();

            }
            

            
        }
    }
}
