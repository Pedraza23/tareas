using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tareas.entidades;

namespace Tareas.datos
{
    public class clIngresar
    {
        public clUsuario mtdIngrsar(clUsuario oData)
        {
            clConexion con = new clConexion();
            clUsuario oUsuario = null;
            SqlConnection conexion = con.mtdAbrirConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("spLogin", conexion))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", oData.email);
                    cmd.Parameters.AddWithValue("@password", oData.contraseña);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oUsuario = new clUsuario()
                            {
                                idUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario")),
                                nombre = reader.GetString(reader.GetOrdinal("nombre")),
                                apellido = reader.GetString(reader.GetOrdinal("apellido")),
                                email = reader.GetString(reader.GetOrdinal("email")),
                                contraseña = reader.GetString(reader.GetOrdinal("contraseña"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.mtdCerrarConexion();
            }
            return oUsuario;

        }
    }
}