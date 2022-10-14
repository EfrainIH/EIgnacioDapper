using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EignacioDapper
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public int IdRol { get; set; }

        /*public static Resultado Add(Usuario usuario)
        {
            Resultado resultado = new Resultado(); 

            try
            {
                using (var context = new SqlConnection(Conexion.GetConexion()))
                {

                    var query = context.Execute($"UsuarioAdd'{usuario.Nombre}','{usuario.ApellidoP}','{usuario.ApellidoM}','{usuario.Email}','{usuario.Edad }','{usuario.Sexo}','{usuario.IdRol}'");

                    if (query > 0)
                    {
                        resultado.Mensaje = "Correcto";
                    }
                    else
                    {
                        resultado.Mensaje = "Error";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Mensaje = "Ocurrio un error al insertar el registro" + ex;

            }

            return resultado;

        }


        */
        /*
        public static Resultado Delete(Usuario usuario)
        {
            Resultado resultado = new Resultado();

            try
            {
                using (var context = new SqlConnection(Conexion.GetConexion()))
                {

                    var query = context.Execute($"UsuarioDelete'{usuario.IdUsuario}'");

                    if (query > 0)
                    {
                        resultado.Mensaje = "Correcto";
                    }
                    else
                    {
                        resultado.Mensaje = "Error";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Mensaje = "Ocurrio un error al insertar el registro" + ex;

            }

            return resultado;

        }
        */

        public static Resultado Update(Usuario usuario)
        {
            Resultado resultado = new Resultado();

            try
            {
                using (var context = new SqlConnection(Conexion.GetConexion()))
                {

                    var query = context.Execute($"UsuarioUpdate '{usuario.IdUsuario}','{usuario.Nombre}','{usuario.ApellidoP}','{usuario.ApellidoM}','{usuario.Email}','{usuario.Edad}','{usuario.Sexo}','{usuario.IdRol}'");

                    if (query > 0)
                    {
                        resultado.Mensaje = "Correcto";
                    }
                    else
                    {
                        resultado.Mensaje = "Error";
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.Mensaje = "Ocurrio un error al insertar el registro" + ex;

            }

            return resultado;

        }



       public static Resultado GetAll()
        {
            Resultado resultado = new Resultado();

            try
            {
                using (var context = new SqlConnection(Conexion.GetConexion()))
                {

                    var query = context.Query<Usuario>("UsuarioGetAll").ToList();
                    resultado.Objetos = new List<object>();

                    foreach (var obj in query)
                    {
                        Usuario usuario = new Usuario();
                        usuario.IdUsuario = obj.IdUsuario;
                        usuario.Nombre = obj.Nombre;
                        usuario.ApellidoP = obj.ApellidoP;
                        usuario.ApellidoM = obj.ApellidoM;
                        usuario.Email = obj.Email;
                        usuario.Sexo = obj.Sexo;
                        usuario.Edad = obj.Edad;
                        usuario.IdRol = obj.IdRol;

                        resultado.Objetos.Add(usuario);
                    
                }

                        resultado.Mensaje = "Correcto";

                }
            }
            catch (Exception ex)
            {
                resultado.Mensaje = "Ocurrio un error al insertar el registro" + ex;

            }

            return resultado;

        }
    }
}
