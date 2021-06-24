using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Logica
{
    public class Logica_Cliente
    {
        Datos_Cliente datos = new Datos_Cliente();
        #region Metodos de seleccion
        //Mostar todos los clientes
        public List<CLIENTE> Seleccionarclientes()
        {
            return datos.seleccionarallclientes();
        }
        //Mostar cliente por id
        public CLIENTE Seleccionarclienteporid(int cliid)
        {
            return Seleccionarclientes().Where(cli => cli.CLIID == cliid).SingleOrDefault();
        }
        //Seleccionar clientes por Apellido
        public List<CLIENTE> SeleccionarclientesByApellido(string cliapellido)
        {
            return datos.seleccionarclientebyApellido(cliapellido);
        }
        #endregion
        #region Metodos de accion

        //Insertar un nuevo cliente
        public CLIENTE InsertarCliente(CLIENTE nuevoCliente)
        {
            return datos.insertarcliente(nuevoCliente);
        }
        //Eliminar un cliente
        public void EliminarCliente(int cliid)
        {
            datos.eliminacliente(cliid);
        }
        //Actualizar un cliente
        public CLIENTE ActualizarCliente(CLIENTE cliActualizar)
        {
            return datos.Actualizarcliente(cliActualizar);
        }
        #endregion
    }
}
