using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DTO_TECC
    {
        //Atributos de Ticket
        public int TIKID { get; set; }
        public string TIKTITULO { get; set; }
        public string TIKDESCRIPCION { get; set; }
        public System.DateTime TIKFECHA { get; set; }
        public string TIKESTADO { get; set; }
        //Atributos de cliente
        public string NOMBRECOMPLETO { get; set; } //Debe concatenar nombre y apellido
        public string CLIDIRECCION { get; set; }
        public string CLICELULAR { get; set; }
        public string CLICORREO { get; set; }
        //Atributos de empleado
        public string NOMBRECOMPLETOEMP { get; set; }
        public string EMPCELULAR { get; set; }
        public string EMPCORREO { get; set; }
        //Atributos de categoria
        public string CATDESCRIPCION { get; set; }

    }
}
