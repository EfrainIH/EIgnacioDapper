using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EignacioDapper
{
    public class Conexion
    {
        public static String GetConexion()
        {
            return "Data Source=.;Initial Catalog=EIgnacioDapper1;Integrated Security=True";
        }

    }
}
