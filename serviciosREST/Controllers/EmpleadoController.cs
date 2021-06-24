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
    public class EmpleadoController : ApiController
    {
        LogicaEmpleado datos = new LogicaEmpleado();

        // GET: api/Empleado
        public List<EMPLEADO> Get()
        {
            return datos.Seleccionarempleados();
        }

        // GET: api/Empleado/5
        public EMPLEADO Get(int id)
        {
            return datos.Seleccionarempleadoid(id);
        }

        // POST: api/Empleado
        public EMPLEADO Post([FromBody]EMPLEADO newEmpleado)
        {
            return datos.InsertarEmpleado(newEmpleado);
        }

        // PUT: api/Empleado/5
        public EMPLEADO Put([FromBody] EMPLEADO updateEmpleado)
        {
            return datos.ActualizarEmpleado(updateEmpleado);
        }

        // DELETE: api/Empleado/5
        public void Delete(int id)
        {
            datos.EliminarEmpleado(id);
        }
    }
}
