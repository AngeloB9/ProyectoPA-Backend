using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;

namespace ServiciosWeb_SOA
{
    /// <summary>
    /// Descripción breve de ServicioWeb_Suma
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_Suma : System.Web.Services.WebService
    {

        LogicaOperaciones logicaoperaciones = new LogicaOperaciones();
        [WebMethod]
        public decimal sumar(decimal v1, decimal v2)
        {
            return logicaoperaciones.sumar(v1, v2);
        }
    }
}
