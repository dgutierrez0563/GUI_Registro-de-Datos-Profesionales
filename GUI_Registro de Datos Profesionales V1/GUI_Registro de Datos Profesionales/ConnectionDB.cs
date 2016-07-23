using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_AdminstradorDeTareas
{
    class ConnectionDB
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public ConnectionDB() { }
        /// <summary>
        /// Metodo de coneccion que establece la ruta
        /// </summary>
        /// <returns></returns>
        public SqlConnection conncecion() {
            SqlConnection conectar = new SqlConnection("Data Source = WSULLIVAN - PC\\SQLEXPRESS; Initial Catalog = INFORMACION; Integrated Security = true");
            return conectar;
        }
    }
}
