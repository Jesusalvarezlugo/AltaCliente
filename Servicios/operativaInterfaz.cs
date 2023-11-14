using AltaCliente.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCliente.Servicios
{
    internal interface operativaInterfaz
    {
        public void DarAltaCliente(List<ClienteDto> listaAntigua);
              
    }
}
