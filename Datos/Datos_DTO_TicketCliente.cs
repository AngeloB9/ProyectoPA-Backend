using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_DTO_TicketCliente
    {
        TicketPAEntities contexto;
        public Datos_DTO_TicketCliente()
        {
            contexto = new TicketPAEntities();
            //No permite generar automaticamente los enlaces virtuales.
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        public List<DTO_TicketCliente> mostrarTicketsCliente()
        {
            var consulta = from cli_cliente in contexto.CLIENTE
                           join tic_ticket in contexto.TICKET on cli_cliente.CLIID equals tic_ticket.CLIID
                           select new DTO_TicketCliente
                           {
                               TIKTITULO = tic_ticket.TIKTITULO,
                               NOMBRECOMPLETO=cli_cliente.CLINOMBRES + " " + cli_cliente.CLIAPELLIDOS
                                
                           };
            List<DTO_TicketCliente> resultado = consulta.ToList();
            return resultado;
            
        }
        public List<DTO_TicketCliente> mostrarTicketClientePorApellido(string cliapellido)
        {
            var consulta = from cli_cliente in contexto.CLIENTE
                           join tic_ticket in contexto.TICKET on cli_cliente.CLIID equals tic_ticket.CLIID
                           where cli_cliente.CLIAPELLIDOS == cliapellido
                           select new DTO_TicketCliente
                           {
                               TIKTITULO = tic_ticket.TIKTITULO,
                               NOMBRECOMPLETO = cli_cliente.CLINOMBRES + " " + cli_cliente.CLIAPELLIDOS

                           };
            List<DTO_TicketCliente> resultado = consulta.ToList();
            return resultado;
        }
    }
}
