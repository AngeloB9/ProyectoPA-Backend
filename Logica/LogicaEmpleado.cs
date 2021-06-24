using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Logica
{
    public class LogicaEmpleado
    {
        Datos_Empleado datos = new Datos_Empleado();
        #region Metodos de seleccion

        //Mostar todos los empleados
        public List<EMPLEADO> Seleccionarempleados()
        {
            return datos.seleccionarallempleados();
        }
        //Mostar empleado por id
        public EMPLEADO Seleccionarempleadoid(int empid)
        {
            return Seleccionarempleados().Where(emp => emp.EMPID == empid).SingleOrDefault();
        }
        //Mostrar todos los empleados desde un procedimiento almacenado
        public List<seleccionarEmpleados_SP_Result> MostrarAllEmpleadosbySP()
        {
            return datos.MostarAllEmpleadosSP();
        }
        //Mostrar empleados por apellido desde un SP
        public List<seleccionarEmpleadobyApellidoSP_Result> MostrarEmpleadosByApellidos(string empapellidos)
        {
            return datos.MostrarEmpleadoApellidoSP(empapellidos);
        }
        #endregion
        #region Metodos de accion

        //Insertar un nuevo empleado
        public EMPLEADO InsertarEmpleado(EMPLEADO nuevoEmpleado)
        {
            return datos.insertarempleado(nuevoEmpleado);
        }
        //Eliminar un empleado
        public void EliminarEmpleado(int empid)
        {
            datos.eliminarempleado(empid);
        }
        //Actualizar un empleado
        public EMPLEADO ActualizarEmpleado(EMPLEADO actEmpleado)
        {
            return datos.actualizarempleado(actEmpleado);
        }
        #endregion
    }
}
