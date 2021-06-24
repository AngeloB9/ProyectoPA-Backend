using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
namespace Logica
{
    public class DTO_Logica
    {
        Datos_DTO_TECC dto_datos = new Datos_DTO_TECC();
        public DTO_TECC seleccionarTciketbyID(int tikid)
        {
            return dto_datos.seleccionarTciketbyID(tikid);
        }
        public List<DTO_TECC> seleccionarAllTciket()
        {
            return dto_datos.seleccionarAllTickets();
        }

        public List<DTO_TECC> seleccionarTicketByEmpleado(string empnombre)
        {
            return dto_datos.seleccionarAllTickets().Where(e => e.NOMBRECOMPLETOEMP.Contains(empnombre)).ToList();
        }
        //Listas de tickets por orden alfabetico
        public List<DTO_TECC> seleccionarTicketsOrdenado()
        {
            return dto_datos.seleccionarAllTickets().OrderBy(t => t.TIKTITULO).ToList();
        }
    }
}
