using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Categoria
    {
        TicketPAEntities contexto;
        public Datos_Categoria()
        {
            contexto = new TicketPAEntities();
            //No permite generar automaticamente los enlaces virtuales.
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        //mostrar todas las categorias
        public List<CATEGORIA> seleccionarallcategorias()
        {
            return contexto.CATEGORIA.ToList();
        }
        //mostrar categoria por ID
        public CATEGORIA seleccionarcategoriabyID(string catid)
        {
            return contexto.CATEGORIA.Where(c => c.CATID == catid).SingleOrDefault();
        }
        //Insertar una categoria
        public CATEGORIA insertarcategoria(CATEGORIA nuevacat)
        {
            contexto.CATEGORIA.Add(nuevacat);
            contexto.SaveChanges();
            return nuevacat;
        }
        //Eliminar una categoria
        public void eliminacat(string catit)
        {
            CATEGORIA categoriaexiste = seleccionarcategoriabyID(catit);
            if (categoriaexiste != null)
            {
                contexto.CATEGORIA.Remove(categoriaexiste);
            }
            contexto.SaveChanges();
        }
        public CATEGORIA actualizarcategoria(CATEGORIA actualizarcat)
        {
            CATEGORIA categoriaexiste = seleccionarcategoriabyID(actualizarcat.CATID);
            if (categoriaexiste != null)
            {
                categoriaexiste.CATNOMBRE = actualizarcat.CATNOMBRE;
                categoriaexiste.CATDESCRIPCION = actualizarcat.CATDESCRIPCION;
                contexto.SaveChanges();
            }
            else
            {
                return null;
            }


            return actualizarcat;
        }
    }
}
