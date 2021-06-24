using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Empleado
    {
        TicketPAEntities contexto;
        public Datos_Empleado()
        {
            contexto = new TicketPAEntities();
            //No permite generar automaticamente los enlaces virtuales.
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        #region metodos de seleccion
        //mostrar todos los empleados
        public List<EMPLEADO> seleccionarallempleados()
        {
            return contexto.EMPLEADO.ToList();
        }
        //mostrar empleado por ID
        public EMPLEADO SeleccionarempleadobyID(int empid)
        {
            return contexto.EMPLEADO.Where(c => c.EMPID == empid).SingleOrDefault();
        }
        //Mostrar todos los empleados desde un procedimiento almacenado
        public List<seleccionarEmpleados_SP_Result> MostarAllEmpleadosSP()
        {
            return contexto.seleccionarEmpleados_SP().ToList();
        }
        //Mostrar empleados por apellido
        public List<seleccionarEmpleadobyApellidoSP_Result> MostrarEmpleadoApellidoSP(string empApellido)
        {
            return contexto.seleccionarEmpleadobyApellidoSP(empApellido).ToList();
        }
        #endregion

        //Insertar un empleado
        public EMPLEADO insertarempleado(EMPLEADO nuevoemp)
        {
            contexto.EMPLEADO.Add(nuevoemp);
            contexto.SaveChanges();
            return nuevoemp;
        }
        //Eliminar un emplado
        public void eliminarempleado(int empid)
        {
            EMPLEADO empleadoexiste = SeleccionarempleadobyID(empid);
            if (empleadoexiste != null)
            {
                contexto.EMPLEADO.Remove(empleadoexiste);
                
            }
            contexto.SaveChanges();

        }
        //Actualizar empleado -DEBER !!!!!
        public EMPLEADO actualizarempleado(EMPLEADO actualizaremp)
        {
            EMPLEADO empleadoexiste = SeleccionarempleadobyID(actualizaremp.EMPID);
            if (empleadoexiste != null)
            {
                empleadoexiste.EMPNOMBRES = actualizaremp.EMPNOMBRES;
                empleadoexiste.EMPAPELLIDOS = actualizaremp.EMPAPELLIDOS;
                empleadoexiste.EMPFECHANACIMIENTO = actualizaremp.EMPFECHANACIMIENTO;
                empleadoexiste.EMPCELULAR = actualizaremp.EMPCELULAR;
                empleadoexiste.EMPCORREO = actualizaremp.EMPCORREO;
                empleadoexiste.EMPDIRECCION = actualizaremp.EMPDIRECCION;
                contexto.SaveChanges();
            }
            else
            {
                return null;
            }


            return actualizaremp;
        }
        
    }
}
