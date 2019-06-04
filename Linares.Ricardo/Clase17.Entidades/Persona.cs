using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Clase17.Entidades
{
    public class Persona : Humano, ISerializableXML , ISerializableBinario
    {
        private string _apellido;
        private string _nombre;
        private string _PATH;

        public Persona() : this("Nombre","Apellido")
        {

        }
        public Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public string PATH { 
            get
            {
                return this._PATH;
            }
            set
            {
                this._PATH = value;
            }
        }

        public bool Deserializar()
        {
            bool respuesta = false;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));

                using (StreamReader reader = new StreamReader(this.PATH))
                {
                    Persona algo = (Persona)serializer.Deserialize(reader);

                }
                respuesta = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
            return respuesta;
        }
        bool ISerializableBinario.Serializar()
        {
            return false;
        }
        bool ISerializableXML.Serializar()
        {
            bool resultado = false;
            try  // muchas de las lineas de este codigo pueden lanzar una excepcion
            {

                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                using (StreamWriter writer = new StreamWriter(this.PATH))
                {
                    serializer.Serialize(writer, this);

                }
                resultado = true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }

            return resultado;
        }

        public override string ToString()
        {
            return base.ToString() + "Nombre Completo: " + this._nombre + " " + this._apellido+ "\n";
        }
    }
}
