
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Logica
{
    public class LogicaCategoria
    {
        Datos_Categoria datos = new Datos_Categoria();
        #region Metodos de seleccion

        //Mostar todos los empleados
        public List<CATEGORIA> SeleccionarCategorias()
        {
            return datos.seleccionarallcategorias();
        }
        //Mostar categoria por id
        public CATEGORIA SeleccionarCategoriaId(string catid)
        {
            return SeleccionarCategorias().Where(cat => cat.CATID == catid).SingleOrDefault();
        }
        #endregion
        #region Metodos de accion

        //Insertar una nueva categoria
        public CATEGORIA InsertarCategoria(CATEGORIA nuevoCategoria)
        {
            return datos.insertarcategoria(nuevoCategoria);
        }
        //Eliminar una categoria
        public void EliminarCategoria(string catid)
        {
            datos.eliminacat(catid);
        }
        //Actuailizar una categoria
        public CATEGORIA ActualizarCategoria(CATEGORIA actCategoria)
        {
            return datos.actualizarcategoria(actCategoria);
        }
        #endregion
    }
}
