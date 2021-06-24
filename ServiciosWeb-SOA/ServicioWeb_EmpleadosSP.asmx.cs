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
    /// Descripción breve de ServicioWeb_EmpleadosSP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_EmpleadosSP : System.Web.Services.WebService
    {
        LogicaEmpleado datos = new LogicaEmpleado();
        [WebMethod]
        public List<seleccionarEmpleados_SP_Result> MostrarAllEmpleadosSP()
        {
            return datos.MostrarAllEmpleadosbySP();
        }
        [WebMethod]
        public List<seleccionarEmpleadobyApellidoSP_Result> MostrarEmpleadosApellidosSP(string empapellidos)
        {
            return datos.MostrarEmpleadosByApellidos(empapellidos);
        }
    }
}
