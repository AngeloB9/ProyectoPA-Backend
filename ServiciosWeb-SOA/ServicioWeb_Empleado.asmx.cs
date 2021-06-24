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
    /// Descripción breve de ServicioWeb_Empleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_Empleado : System.Web.Services.WebService
    {
        LogicaEmpleado logica = new LogicaEmpleado();
        [WebMethod]
        public List<EMPLEADO> SeleccionarAllEmpleados()
        {
            return logica.Seleccionarempleados();
        }
        [WebMethod]
        public EMPLEADO SeleccionarEmpleadoPorID(int empid)
        {
            return logica.Seleccionarempleadoid(empid);
        }
        [WebMethod]
        public EMPLEADO InsertarEmpleado(EMPLEADO nuevoempleado)
        {
            return logica.InsertarEmpleado(nuevoempleado);
        }
        [WebMethod]
        public EMPLEADO ActualizarEmpleado(EMPLEADO actempleado)
        {
            return logica.ActualizarEmpleado(actempleado);
        }
        [WebMethod]
        public void EliminarEmpleado(int empid)
        {
            logica.EliminarEmpleado(empid);
        }
    }
}
