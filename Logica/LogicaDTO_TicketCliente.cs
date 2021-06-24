using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class LogicaDTO_TicketCliente
    {
        Datos_DTO_TicketCliente datos = new Datos_DTO_TicketCliente();
        
        public List<DTO_TicketCliente> mostrarTicketCliente()
        {
            return datos.mostrarTicketsCliente();
        }
        public List<DTO_TicketCliente> mostrarTicketClienteByApellido(string cliapellido)
        {
            return datos.mostrarTicketClientePorApellido(cliapellido);
        }

    }
}
