using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SimpleCRUD
{
    class connection
    {
        //propiedades
        private MySqlConnection conn =
            new MySqlConnection("Server=localhost;Databases=smis012021;Uid=root;" +
            "pdw=usbw SSL mode=none");

        public MySqlCommand command;

        //abrir conexion

        public MySqlConnection openconnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
         //cerrar la conexion

        public MySqlConnection closeconnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
        
    }
}
