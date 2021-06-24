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
    /// Descripción breve de ServicioWeb_Ticket
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]

    public class ServicioWeb_Ticket : System.Web.Services.WebService
    {
        LogicaTicket logica = new LogicaTicket();


        [WebMethod]
        public List<TICKET> SeleccionarTickets_Categorias()
        {
            return logica.seleccionarTickets_Categorias();
        }
        [WebMethod]
        public List<TICKET> SeleccionarAllTickets()
        {
            return logica.seleccionarAllTickets();
        }
        [WebMethod]
        public TICKET SeleccionarTicketPorID(int tikid)
        {
            return logica.Seleccionarticketid(tikid);
        }
        [WebMethod]
        public TICKET InsertarTicket(TICKET nuevoticket)
        {
            return logica.InsertarTicket(nuevoticket);
        }
        [WebMethod]
        public TICKET ActualizarTicket(TICKET updticket)
        {
            return logica.ActualizarTicket(updticket);
        }
        [WebMethod]
        public void EliminarTicket(int tikid)
        {
            logica.EliminarTicket(tikid);
        }
    }
}
