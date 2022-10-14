using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EignacioDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Delete();
            //Update();
            GetAll();
        }
        /*
        public static void Add()
        {
            Usuario usuario = new Usuario();

            Console.WriteLine("Inserte el nombre del Usuario");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Inserte el apellido Paterno");
            usuario.ApellidoP = Console.ReadLine();

            Console.WriteLine("Inserte el apellido Materno");
            usuario.ApellidoM = Console.ReadLine();

            Console.WriteLine("Inserte el Email");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Inserte tu sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Inserte tu edad");
            usuario.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el IdRol");
            usuario.IdRol = int.Parse(Console.ReadLine());

            Resultado resultado = Usuario.Add(usuario);

            if (resultado.Mensaje == "Error")
            {
                Console.WriteLine("Ocurrio un error al ingresar el registro");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Usuario insertado con exito");
                
            }
        }
        */
        /*

        public static void Delete()
        {
            Usuario usuario = new Usuario();

            Console.WriteLine("Inserte el Numero de Id que deseas eliminar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Resultado resultado = Usuario.Delete(usuario);

            if (resultado.Mensaje == "Error")
            {
                Console.WriteLine("Ocurrio un error al ingresar el registro");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Usuario insertado con exito");

            }
        }
        */
        public static void Update()

        {
            Usuario usuario = new Usuario();

            Console.WriteLine("Inserte el registro que vas a cambiar ");
            usuario.IdUsuario = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el nombre del Usuario1");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Inserte el apellido Paterno");
            usuario.ApellidoP = Console.ReadLine();

            Console.WriteLine("Inserte el apellido Materno");
            usuario.ApellidoM = Console.ReadLine();

            Console.WriteLine("Inserte el Email");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Inserte tu sexo");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Inserte tu edad");
            usuario.Edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el IdRol");
            usuario.IdRol = Int32.Parse(Console.ReadLine());


            //LLAMAMOS AL METODO RESULTADO
            Resultado resultado = Usuario.Update(usuario);

            if (resultado.Mensaje == "Error")
            {
                Console.WriteLine("Ocurrio un error al ingresar el registro");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Usuario Atualizado con exito");

            }
        }


        public static void GetAll()
        {
            Resultado resultado = Usuario.GetAll();
            if (resultado.Mensaje == "Correcto")
            {
                foreach (Usuario usuario in resultado.Objetos)
                {
                    Console.WriteLine("IdAlumno: " + usuario.IdUsuario);
                    Console.WriteLine("Nombre: " + usuario.Nombre);
                    Console.WriteLine("Apellido Paterno: " + usuario.ApellidoP);
                    Console.WriteLine("Apellido Materno: " + usuario.ApellidoM);
                    Console.WriteLine("Fecha de nacimiento: " + usuario.Email);
                    Console.WriteLine("Matricula: " + usuario.Sexo);
                    Console.WriteLine("Genero: " + usuario.Edad);
                    Console.WriteLine("Semestre: " + usuario.IdRol);

                    Console.WriteLine("*******************************************");
                }
            }
            else
            {
                Console.WriteLine("Ocurrió un error al consultar la información" + resultado.Mensaje);
            }

        }
    }
}
