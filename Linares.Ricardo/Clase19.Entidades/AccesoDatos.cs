using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Clase19.Entidades
{
    public class AccesoDatos
    {
        private SqlConnection _connecxion;
        private SqlCommand _comando;
        public AccesoDatos()
        {
            // Necesita un string de connecxion... el codigo de connexion es sacado desde propiedades <-
            this._connecxion = new SqlConnection(Properties.Settings.Default.conecxion_BD);
        }
        public bool AgregarPersona(Persona p)
        {
            bool respuesta = false;
            //INIT DEL COMANDO
            this._comando = new SqlCommand();
            //ESTABLECER LA CONECCION
            this._comando.Connection = this._connecxion;
            // ESTABLECER TYPO DE COMANDO
            this._comando.CommandType = CommandType.Text;
            // EL COMANDO(EN CASO DE COMANDO TEXTO)
            this._comando.CommandText = "INSERT INTO [Padron].[dbo].[Personas] (nombre,apellido,edad) VALUES('" + p._nombre +"','" + p._apellido + "',"+p._edad.ToString()+")";
            try
            {
                this._connecxion.Open();
                int cantidad = this._comando.ExecuteNonQuery();
                if(cantidad > 0)
                {
                    respuesta = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(this._connecxion.State == ConnectionState.Open)
                {
                    this._connecxion.Close();
                }
            }
            return respuesta;
        }

        public bool EliminarPersona(int id)
        {
            bool respuesta = false;
            //INIT DEL COMANDO
            this._comando = new SqlCommand();
            //ESTABLECER LA CONECCION
            this._comando.Connection = this._connecxion;
            // ESTABLECER TYPO DE COMANDO
            this._comando.CommandType = CommandType.Text;
            // EL COMANDO(EN CASO DE COMANDO TEXTO)
            this._comando.CommandText = "Delete [Padron].[dbo].[Personas] Where id = "+ id.ToString();
            try
            {
                this._connecxion.Open();
                int cantidad = this._comando.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (this._connecxion.State == ConnectionState.Open)
                {
                    this._connecxion.Close();
                }
            }
            return respuesta;
        }
        //Update [Padron].[dbo].[Personas] SET nombre = 'Nombre', apellido = 'Apellido', edad = 69 Where id = 22

        public bool ModificarPersona(Persona persona)
        {
            bool respuesta = false;
            //INIT DEL COMANDO
            this._comando = new SqlCommand();
            //ESTABLECER LA CONECCION
            this._comando.Connection = this._connecxion;
            // ESTABLECER TYPO DE COMANDO
            this._comando.CommandType = CommandType.Text;
            // EL COMANDO(EN CASO DE COMANDO TEXTO)
            this._comando.CommandText = "UPDATE [Padron].[dbo].[Personas] SET nombre = '" + persona._nombre + "', apellido = '"+ persona._apellido +"', edad = "+ persona._edad+" Where id = "+persona._id;
            try
            {
                this._connecxion.Open();
                int cantidad = this._comando.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (this._connecxion.State == ConnectionState.Open)
                {
                    this._connecxion.Close();
                }
            }
            return respuesta;
        }
        public List<Persona> TraerTodos()
        {
            List<Persona> personas = new List<Persona>();
            //INIT DEL COMANDO
            this._comando = new SqlCommand();
            //ESTABLECER LA CONECCION
            this._comando.Connection = this._connecxion;
            // ESTABLECER TYPO DE COMANDO
            this._comando.CommandType = CommandType.Text;
            // EL COMANDO(EN CASO DE COMANDO TEXTO)
            this._comando.CommandText = "SELECT id, nombre, apellido,edad FROM[Padron].[dbo].[Personas] ";

            try
            {
                this._connecxion.Open();
                SqlDataReader sqlData = this._comando.ExecuteReader();
                while(sqlData.Read())
                {
                    int id = (int)sqlData[0];
                    string nombre = (string)sqlData[1];
                    string apellido = (string)sqlData[2];
                    int edad = (int)sqlData[3];
                    Persona newPersona = new Persona(id, nombre, apellido, edad);
                    personas.Add(newPersona);
                }
                this._connecxion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return personas;
        }
        public DataTable TraerTablaPersonas()
        {
            // Data table es de system.data;
            DataTable personas = new DataTable("Personas");
            //INIT DEL COMANDO
            this._comando = new SqlCommand();
            //ESTABLECER LA CONECCION
            this._comando.Connection = this._connecxion;
            // ESTABLECER TYPO DE COMANDO
            this._comando.CommandType = CommandType.Text;
            // EL COMANDO(EN CASO DE COMANDO TEXTO)
            this._comando.CommandText = "SELECT id, nombre, apellido,edad FROM[Padron].[dbo].[Personas] ";

            try
            {
                this._connecxion.Open();
                SqlDataReader sqlData = this._comando.ExecuteReader();
                personas.Load(sqlData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(this._connecxion.State == ConnectionState.Open)
                    this._connecxion.Close();
            }

            return personas;
        }
    }
}
