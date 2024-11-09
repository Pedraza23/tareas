using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tareas.entidades
{
    public class clTarea : clUsuario

    {
        public int idTarea { get; set; }
        public string descripcion  { get; set; }
        public string completada { get; set; }
       
    }
}