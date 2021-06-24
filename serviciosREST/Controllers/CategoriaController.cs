using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AccesoDatos;
using Logica;

namespace serviciosREST.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoriaController : ApiController
    {
        LogicaCategoria datos = new LogicaCategoria();
        // GET: api/Categoria
        public List<CATEGORIA> Get()
        {
            return datos.SeleccionarCategorias();
        }

        // GET: api/Categoria/5
        public CATEGORIA Get(string id)
        {
            return datos.SeleccionarCategoriaId(id);
        }

        // POST: api/Categoria
        public CATEGORIA Post([FromBody]CATEGORIA nuevacat)
        {
            return datos.InsertarCategoria(nuevacat);
        }

        // PUT: api/Categoria/5
        public CATEGORIA Put([FromBody]CATEGORIA updateCategoria)
        {
            return datos.ActualizarCategoria(updateCategoria);
        }

        // DELETE: api/Categoria/5
        public void Delete(string id)
        {
            datos.EliminarCategoria(id);
        }
    }
}
