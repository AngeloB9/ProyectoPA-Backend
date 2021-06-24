using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{

    public class Datos_Cliente
    {
        TicketPAEntities contexto;
        public Datos_Cliente()
        {
            contexto = new TicketPAEntities();
            //No permite generar automaticamente los enlaces virtuales.
            contexto.Configuration.ProxyCreationEnabled = false;
        } 

        //mostrar todos los clientes
        public List<CLIENTE> seleccionarallclientes()
        {
            return contexto.CLIENTE.ToList();
        }
        //mostrar cliente por ID
        public CLIENTE seleccionarclientebyID(int cliid)
        {
            return contexto.CLIENTE.Where(c=>c.CLIID==cliid).SingleOrDefault();
        }
        
        //seleccionar cliente por Apellido
        public List<CLIENTE> seleccionarclientebyApellido(string cliapellido)
        {
            return contexto.CLIENTE.Where(c => c.CLIAPELLIDOS.Contains(cliapellido)).ToList();
        }
       
        //Insertar un cliente
        public CLIENTE insertarcliente(CLIENTE nuevocli)
        {
            contexto.CLIENTE.Add(nuevocli);
            contexto.SaveChanges();
            return nuevocli;
        }
        //Eliminar un cliente
        public void eliminacliente(int cliid)
        {
            CLIENTE clienteexiste = seleccionarclientebyID(cliid);
            if (clienteexiste != null)
            {
                contexto.CLIENTE.Remove(clienteexiste);
            }
            contexto.SaveChanges();
        }
        //Actualizar cliente -DEBER !!!!!
        public CLIENTE Actualizarcliente(CLIENTE actualizarcli)
        {
            CLIENTE clienteexiste = seleccionarclientebyID(actualizarcli.CLIID);
            if (clienteexiste != null)
            {
                clienteexiste.CLIID = actualizarcli.CLIID;
                clienteexiste.CLINOMBRES = actualizarcli.CLINOMBRES;
                clienteexiste.CLIAPELLIDOS = actualizarcli.CLIAPELLIDOS;
                clienteexiste.CLIDIRECCION = actualizarcli.CLIDIRECCION;
                clienteexiste.CLICELULAR = actualizarcli.CLICELULAR;
                clienteexiste.CLICORREO = actualizarcli.CLICORREO;
                contexto.SaveChanges();
            }
            else
            {
                return null;
            }
            

            return actualizarcli;
        }

    }
}
