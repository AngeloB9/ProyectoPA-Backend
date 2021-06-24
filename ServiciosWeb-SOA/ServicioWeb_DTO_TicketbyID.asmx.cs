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
    /// Descripción breve de ServicioWeb_DTO_TicketbyID
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_DTO_TicketbyID : System.Web.Services.WebService
    {
        DTO_Logica dto_logica = new DTO_Logica();
        
        [WebMethod]
        public DTO_TECC SeleccionarTciketbyID(int tikid)
        {
            return dto_logica.seleccionarTciketbyID(tikid);
        }
        [WebMethod]
        public List<DTO_TECC> SeleccionarAllTicket()
        {
            return dto_logica.seleccionarAllTciket();
        }
        [WebMethod]
        public List<DTO_TECC> SeleccionarAllTciketbyEmpleado(string empNombre)
        {
            return dto_logica.seleccionarTicketByEmpleado(empNombre);
        }
        [WebMethod]
        public List<DTO_TECC> SeleccionarAllTciketOrdenado()
        {
            return dto_logica.seleccionarTicketsOrdenado();
        }

    }
}
