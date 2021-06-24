using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AccesoDatos;
using Logica;

namespace serviciosREST.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TicketController : ApiController
    {
        LogicaTicket datos = new LogicaTicket();
        // GET: api/Ticket
        public List<TICKET> Get()
        {
            return datos.seleccionarAllTickets();
        }

        // GET: api/Ticket/5
        public TICKET Get(int id)
        {
            return datos.Seleccionarticketid(id);
        }

        // POST: api/Ticket
        public TICKET Post([FromBody]TICKET nuevoTicket)
        {
            return datos.InsertarTicket(nuevoTicket);
        }

        // PUT: api/Ticket/5
        public TICKET Put([FromBody]TICKET updateTicket)
        {
            return datos.ActualizarTicket(updateTicket);
        }

        // DELETE: api/Ticket/5
        public void Delete(int id)
        {
            datos.EliminarTicket(id);
        }
    }
}
