using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Tareas.datos
{
    public class clConexion
    {
        SqlConnection conn;

        public clConexion()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=dbTareas;Integrated Security=True;"); 
        }
        public SqlConnection mtdAbrirConexion()
        {
            conn.Open();
            return conn;
        }
        public SqlConnection mtdCerrarConexion()
        {
            conn.Close();
            return conn;
        }
    }
}