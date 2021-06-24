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
    /// Descripción breve de ServicioWeb_Cliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_Cliente : System.Web.Services.WebService
    {

        Logica_Cliente logica = new Logica_Cliente();
        [WebMethod]
        public List<CLIENTE> SeleccionarAllClientes()
        {
            return logica.Seleccionarclientes();
        }
        [WebMethod]
        public CLIENTE SeleccionarClientePorID(int cliid)
        {
            return logica.Seleccionarclienteporid(cliid);
        }
        [WebMethod]
        public CLIENTE InsertarCliente(CLIENTE nuevocliente)
        {
            return logica.InsertarCliente(nuevocliente);
        }
        [WebMethod]
        public CLIENTE ActualizarCliente(CLIENTE actcliente)
        {
            return logica.ActualizarCliente(actcliente);
        }
        [WebMethod]
        public void EliminarCliente(int cliid)
        {
            logica.EliminarCliente(cliid);
        }
    }
}
