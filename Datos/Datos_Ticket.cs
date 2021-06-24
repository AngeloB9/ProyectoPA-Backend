using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Ticket
    {
        TicketPAEntities contexto;
        public Datos_Ticket()
        {
            contexto = new TicketPAEntities();
            //No permite generar automaticamente los enlaces virtuales.
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        //Mostar todos los tickets por categoria
        public List<TICKET> seleccionarTicketsCategoria(string catid)
        {
            return contexto.TICKET.Where(t => t.CATID == catid).ToList();
        }
        //Mostar Tickets y Categorias
        public List<TICKET> seleccionarTickets_Categorias()
        {
            return contexto.TICKET.Include("CATEGORIA").Include("CLIENTE").Include("EMPLEADO").ToList();
            //return contexto.TICKET.Include("CATEGORIA").Include("CATEGORIA.CLIENTE").Include("CATEGORIA.CLIENTE.EMPLEADO").ToList();
        }
        //Mostar todos los tickets
        public List<TICKET> seleccionarAllTickets()
        {
            return contexto.TICKET.ToList();
        }
        //Seleccionar ticket por id
        public TICKET seleccionarTicketByID(int tikid)
        {
            return contexto.TICKET.Where(t => t.TIKID == tikid).SingleOrDefault();
        }
        //Insertar un ticket
        public TICKET insertarTicket(TICKET nuevoTic)
        {
            contexto.TICKET.Add(nuevoTic);
            contexto.SaveChanges();
            return nuevoTic;
        }
        //Eliminar un ticket
        public void eliminarTicket(int ticid)
        {
            TICKET ticketexiste = seleccionarTicketByID(ticid);
            if (ticketexiste != null)
            {
                contexto.TICKET.Remove(ticketexiste);
            }
            contexto.SaveChanges();
        }
        //Actualizar un ticket
        public TICKET actualizarticket(TICKET actualizarTic)
        {
            TICKET Ticketexiste = seleccionarTicketByID(actualizarTic.TIKID);
            if (Ticketexiste != null)
            {
                Ticketexiste.CLIID = actualizarTic.CLIID;
                Ticketexiste.EMPID = actualizarTic.EMPID;
                Ticketexiste.CATID = actualizarTic.CATID;
                Ticketexiste.TIKTITULO= actualizarTic.TIKTITULO;
                Ticketexiste.TIKDESCRIPCION = actualizarTic.TIKDESCRIPCION;
                Ticketexiste.TIKESTADO = actualizarTic.TIKESTADO;
                Ticketexiste.TIKFECHA = actualizarTic.TIKFECHA;
                contexto.SaveChanges();
            }
            else
            {
                return null;
            }


            return actualizarTic;
        }
    }
}
