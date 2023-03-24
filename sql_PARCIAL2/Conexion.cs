using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sql_PARCIAL2
{
    internal class Conexion
    {
        public static string conectar()
        {
            string conn = @"DATA SOURCE=DESKTOP-OL7M306; Initial Catalog=VENTAS ;Integrated Security=True ";
            return conn;
        }
    }
}
