using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EignacioDapper
{
    public class Resultado
    {
        public string Mensaje { get; set; }
        //DEVUELVE UNA LISTA POR QUE LOS DATOS SON DE DIRENTES TIPOS GETALL
        public List<object> Objetos { get; set; }
    }
}
