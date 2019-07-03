using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias necesarias
using System.Data.SqlClient;
using System.Data;

namespace BaseDeDatos
{
    public class Sql
    {
        // Atributos necesarios
        private SqlConnection _conneccion;
        private SqlCommand _comando;

        #region Esqueleto
        public bool Commando(Object p)
        {
            bool respuesta = false;
            //INIT DEL COMANDO
            this._comando = new SqlCommand();
            //ESTABLECER LA CONECCION
            this._comando.Connection = this._conneccion;
            // ESTABLECER TYPO DE COMANDO
            this._comando.CommandType = CommandType.Text;
            // EL COMANDO(EN CASO DE COMANDO TEXTO)
            this._comando.CommandText = "Commando";
            try
            {
                this._conneccion.Open();
                int cantidad = this._comando.ExecuteNonQuery(); // devuelve la cantidad de lineas afectadas
                if (cantidad > 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (this._conneccion.State == ConnectionState.Open)
                {
                    this._conneccion.Close();
                }
            }
            return respuesta;
        }
        #endregion

        #region ComandosSql
        //Tablas pueden haber cantida no limitada de atributos
        //Los atributos de solo lectura como id no debe ser nombrados a la hora de escribir datos
        // Atributos:
        // Strings = 'Atributo' // Va entre '' 
        // Int = Numero // va el numero directo


        //AGREGAR
        //"INSERT INTO [NombreTabla] ([Atributo1],[Atributo2],[AtributoN]) VALUES('Atributo1','Atributo2','AtributoN')"
        // se Ejecuta con ExecuteNonQuery() devolviendo las lineas afectadas

        //QUITAR / Generico como se puede tener
        //"Delete [NombreTabla] Where id = "+ id.ToString()"
        // se Ejecuta con ExecuteNonQuery() devolviendo las lineas afectadas

        //Modificar
        //UPDATE [NombreTabla] SET Atributo1 = 'Atributo1', Atributo2 = 'Atributo2', AtributoN = AtributoN WHERE id = " + id.ToString()")"
        #endregion


    }
}
