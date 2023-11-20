using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCliente.Servicios
{
    internal interface menuInterfaz
    {

        public void MostrarMensajeBienvenida();
        public int MostrarMenuYSeleccion();

        public string NuevoAltaCliente();

        //una funcionalidad a partir de esta arquitectura.
        //crear funcionalidad de dar de alta una nueva cuenta bancaria
        //particularidad: dentro de cuenta bancaria tiene que haber un campo que identifique a que cliente 
        //pertenece esa cuenta bancaria(PK=FK)
        //campos: id, isban(identificador cuenta bancaria),codigo switch(constante), fch alta,fch baja,
        //campo indique a cliente
    }
}
