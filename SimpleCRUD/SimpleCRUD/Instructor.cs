using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SimpleCRUD
{
    class Instructor
    {
        //propiedades
        public int _idInstructor { get; set; }

        public string _nombre { get; set; }

        public string _direccion { get; set; }

        public string _numerodetelefono { get; set; }

        public string _certificacion { get; set; }


        //instancia en la clase crud
        private Crud crud = new Crud();

        //metodos para retornar los registros de la tabla instructor
        public MySqlDataReader getAllInstructor()
        {
            string query = "SELECT idInstructor,nombre,direccion,numerodetelefono,certificacion from Instructor";

            //llamado al metodo select de la clase crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditInstructor(string action)
        {
            if (action == "new")
            {
                string query = "Insert Into Instructor(idInstructor,nombre,direccion,numerodetelefono,certificacion) " +
                    "VALUES ('" + _idInstructor + "', '" + _nombre + "','" + _direccion + "','" + _numerodetelefono + "','" + _certificacion + "')";
                crud.executeQuery(query);//llamado al metodo executequery de la clase crud
                return true;
            }


         else if (action == "edit")
         {
                string query = "UPDATE book SET "
                    + "idInstructor='" + _idInstructor + "' ,"
                    + "nombre='" + _nombre + "',"
                    + "direccion='" + _direccion + "',"
                    + "numerodetelefono='" + _numerodetelefono + "'"
                    + "WHERE "
                    + "certificado='" + _certificacion + "'";
                crud.executeQuery(query);
                return true;
         }
            return false;
        }

        //metodo para eliminar
        public Boolean deleteBook()
        {
            string query = "DELETE FROM book WHERE bookId='" + _certificacion + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}
