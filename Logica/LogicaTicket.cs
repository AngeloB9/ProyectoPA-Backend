using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class LogicaTicket
    {
        Datos_Ticket datos = new Datos_Ticket();

        //Mostar todos los tickets
        public List<TICKET> seleccionarAllTickets()
        {
            return datos.seleccionarAllTickets();
        }
        public List<TICKET> seleccionarTickets_Categorias()
        {
            return datos.seleccionarTickets_Categorias();
        }
        //Mostrar ticket por ID
        public TICKET Seleccionarticketid(int ticid)
        {
            return datos.seleccionarTicketByID(ticid);
        }
        
        //Insertar un nuevo ticket
        public TICKET InsertarTicket(TICKET nuevoTicket)
        {
            return datos.insertarTicket(nuevoTicket);
        }
        //Actualizar un ticket
        public TICKET ActualizarTicket(TICKET ticActualizar)
        {
            return datos.actualizarticket(ticActualizar);
        }
        //Eliminar un ticket
        public void EliminarTicket(int ticid)
        {
            datos.eliminarTicket(ticid);
        }
    }
}
