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
    [EnableCors(origins: "*", headers:"*",methods:"*")]
    public class ClienteController : ApiController
    {
        Logica_Cliente datos = new Logica_Cliente();
        // GET: api/Cliente
        public List<CLIENTE> Get()
        {
            return datos.Seleccionarclientes();
        }

        // GET: api/Cliente/5
        public CLIENTE Get(int id)
        {
            return datos.Seleccionarclienteporid(id);
        }
        [HttpGet]
        [Route("api/ClienteApellidos/{apellido}")]
        public List<CLIENTE> GetClienteApellidos(string apellido)
        {
            return datos.SeleccionarclientesByApellido(apellido);
        }
        // POST: api/Cliente
        public CLIENTE Post([FromBody]CLIENTE newCliente)
        {
            return datos.InsertarCliente(newCliente);
        }

        // PUT: api/Cliente/5
        public CLIENTE Put(CLIENTE updateCliente)
        {
            return datos.ActualizarCliente(updateCliente);
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
            datos.EliminarCliente(id);
        }
    }
}
