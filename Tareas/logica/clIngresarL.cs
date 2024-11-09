using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tareas.datos;
using Tareas.entidades;

namespace Tareas.logica
{
    public class clIngresarL
    {
        public clUsuario mtdIngreso(clUsuario odata)
        {
            clIngresar oDatos = new clIngresar();
            clUsuario oIngreso = oDatos.mtdIngrsar(odata);
            return oIngreso;
        }
    }
}