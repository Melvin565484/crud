using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SimpleCRUD
{
    class Crud
    {
        //instancia de la clase connection
        private connection conn = new connection();

        //metodos para seleccionar los registros de la base de datos
        public MySqlDataReader select(string query)
        {
            MySqlDataReader dataReader;

            //utilizar command de la clase connection
            conn.command = new MySqlCommand(query, conn.openconnection()); //prepara la consulta
            dataReader = conn.command.ExecuteReader();//ejecuta la consulta
            return dataReader;
        }
            //metodo que permitira las consultas para editar, modificar y eliminar

            public void executeQuery(string query)
            {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.command = new MySqlCommand(query, conn.openconnection());
            adapter.InsertCommand = conn.command;
            adapter.InsertCommand.ExecuteNonQuery();//ejecutamos la consulta
            conn.command.Dispose();
            conn.closeconnection();
            }
        
    }
}
