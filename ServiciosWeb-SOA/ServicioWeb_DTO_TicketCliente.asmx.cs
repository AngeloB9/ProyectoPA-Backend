using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using Logica;

namespace ServiciosWeb_SOA
{
    /// <summary>
    /// Descripción breve de ServicioWeb_DTO_TicketCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_DTO_TicketCliente : System.Web.Services.WebService
    {
        LogicaDTO_TicketCliente logica = new LogicaDTO_TicketCliente();
        
       [WebMethod]
       public List<DTO_TicketCliente> MostrarTicketCliente()
       {
            return logica.mostrarTicketCliente();
       }
        [WebMethod]
        public List<DTO_TicketCliente> MostrarTicketClientePorApellido(string cliapellido)
        {
            return logica.mostrarTicketClienteByApellido(cliapellido);
        }
    }
}
