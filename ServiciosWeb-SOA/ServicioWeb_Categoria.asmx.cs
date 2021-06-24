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
    /// Descripción breve de ServicioWeb_Categoria
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb_Categoria : System.Web.Services.WebService
    {
        LogicaCategoria logica = new LogicaCategoria();
        [WebMethod]
        public List<CATEGORIA> SeleccionarAllCategorias()
        {
            return logica.SeleccionarCategorias();
        }
        [WebMethod]
        public CATEGORIA SeleccionarCategoriaPorID(string catid)
        {
            return logica.SeleccionarCategoriaId(catid);
        }
        [WebMethod]
        public CATEGORIA InsertarCategoria(CATEGORIA nuevaCat)
        {
            return logica.InsertarCategoria(nuevaCat);
        }
        [WebMethod]
        public CATEGORIA ActualizarCategoria(CATEGORIA actCat)
        {
            return logica.ActualizarCategoria(actCat);
        }
        [WebMethod]
        public void EliminarCategoria(string catid)
        {
            logica.EliminarCategoria(catid);
        }

    }
}
