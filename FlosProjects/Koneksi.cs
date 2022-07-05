using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace FlosProjects
{
    class Koneksi
    {

        public static MySqlConnection conn = new MySqlConnection
            ("server = localhost; uid = root; " + "password=''; database = flosproject; Convert Zero Datetime=True;");
       
    }
}
