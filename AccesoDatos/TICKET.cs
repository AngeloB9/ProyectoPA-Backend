//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TICKET
    {
        public int TIKID { get; set; }
        public int CLIID { get; set; }
        public int EMPID { get; set; }
        public string CATID { get; set; }
        public string TIKTITULO { get; set; }
        public string TIKDESCRIPCION { get; set; }
        public System.DateTime TIKFECHA { get; set; }
        public string TIKESTADO { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual EMPLEADO EMPLEADO { get; set; }
    }
}