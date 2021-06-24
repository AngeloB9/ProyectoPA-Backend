using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Datos
{
    public class Datos_DTO_TECC
    {
        public List<DTO_TECC> seleccionarAllTickets()
        {
            Datos_Ticket datostic = new Datos_Ticket();
            List<TICKET> lsttic = datostic.seleccionarAllTickets();

            List<DTO_TECC> lstDTO = new List<DTO_TECC>();
            foreach (var item in lsttic)
            {
                DTO_TECC dtodatos = new DTO_TECC();
                //Datos ticket
                dtodatos.TIKID = item.TIKID;
                dtodatos.TIKTITULO = item.TIKTITULO;
                dtodatos.TIKDESCRIPCION = item.TIKDESCRIPCION;
                dtodatos.TIKESTADO = item.TIKESTADO;
                dtodatos.TIKFECHA = item.TIKFECHA;
                //Datos Cliente
                CLIENTE datoscliente = new CLIENTE();

                Datos_Cliente data = new Datos_Cliente();

                datoscliente = data.seleccionarclientebyID(item.CLIID);

                dtodatos.NOMBRECOMPLETO = datoscliente.CLINOMBRES + " " + datoscliente.CLIAPELLIDOS;
                dtodatos.CLICELULAR = datoscliente.CLICELULAR;
                dtodatos.CLICORREO = datoscliente.CLICORREO;
                dtodatos.CLIDIRECCION = dtodatos.CLIDIRECCION;

                //Datos Empleado
                EMPLEADO datosempleado = new EMPLEADO();
                Datos_Empleado dataemp = new Datos_Empleado();
                datosempleado = dataemp.SeleccionarempleadobyID(item.EMPID);

                dtodatos.NOMBRECOMPLETOEMP = datosempleado.EMPNOMBRES + " " + datosempleado.EMPAPELLIDOS;
                dtodatos.EMPCELULAR = datosempleado.EMPCELULAR;
                dtodatos.EMPCORREO = datosempleado.EMPCORREO;

                //Datos Categoria
                CATEGORIA datoscategoria = new CATEGORIA();
                Datos_Categoria datacat = new Datos_Categoria();
                datoscategoria = datacat.seleccionarcategoriabyID(item.CATID);

                dtodatos.CATDESCRIPCION = datoscategoria.CATDESCRIPCION;

                lstDTO.Add(dtodatos);

            }
            return lstDTO;
        
        }
        public DTO_TECC seleccionarTciketbyID(int tikid)
        {
            Datos_Ticket datostic = new Datos_Ticket();
            TICKET ticket = datostic.seleccionarTicketByID(tikid);

            Datos_Empleado datosemp = new Datos_Empleado();
            EMPLEADO empleado = datosemp.SeleccionarempleadobyID(ticket.EMPID);

            Datos_Categoria datoscat = new Datos_Categoria();
            CATEGORIA categoria = datoscat.seleccionarcategoriabyID(ticket.CATID);

            Datos_Cliente datoscli = new Datos_Cliente();
            CLIENTE cliente = datoscli.seleccionarclientebyID(ticket.CLIID);

            DTO_TECC dto_datos = new DTO_TECC();
            //Tickets
            dto_datos.TIKID = ticket.TIKID;
            dto_datos.TIKTITULO = ticket.TIKTITULO;
            dto_datos.TIKDESCRIPCION = ticket.TIKDESCRIPCION;

            //Cliente
            dto_datos.NOMBRECOMPLETO = cliente.CLINOMBRES + " " + cliente.CLIAPELLIDOS;
            dto_datos.CLICELULAR = cliente.CLICELULAR;
            dto_datos.CLICORREO = cliente.CLICORREO;
            dto_datos.CLIDIRECCION = cliente.CLIDIRECCION;

            //Empleados
            dto_datos.NOMBRECOMPLETOEMP = empleado.EMPNOMBRES + " " + empleado.EMPAPELLIDOS;
            dto_datos.EMPCELULAR = empleado.EMPCELULAR;
            dto_datos.EMPCORREO = empleado.EMPCORREO;

            //Categorias
            dto_datos.CATDESCRIPCION = categoria.CATDESCRIPCION;

            return dto_datos;
        }
        //Buscar ticket por Nombre de empleado

    }
}
