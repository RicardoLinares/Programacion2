using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Clase17.Entidades;
namespace Clase17.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //clase de xml
            //Serializacion: pasar un objeto de memoria a un objeto fisico

            //Deserializacion: pasar un objeto fisico a un objeto en memoria
            //Serializacion debe ser publico 
            //si es privado de be tener una propiedad de E/L publica
            //para las colecciones se puede usar una propiedad de Solo lectura

            // la clase debe tener un constructor por defecto

            // la clase debe ser publica

            // interfaces Puede generar codigo asociado a una clase y puede simular la herencia multiple
            // definir metodos o propiedades con carateristicas expeciales
            // no pueden tener implementacion de la metodo o propiedad,
            // no se puede poner el modificador abstract(redundancia) o modificador de visibilidad
            // no se puede llamar con Override
            // Debe haber implementacion de todos los metodos
            // La visibilidad Debe implementarse en publico en todos los metodos y de instancia.
            // no se puede definir Atributos
            Humano humano = new Humano();
            Persona persona = new Persona("Ricardo", "Linares");
            Profesor profesor = new Profesor();
            Alumno alumno = new Alumno();
            List<Humano> humanos = new List<Humano>();
            humanos.Add(humano);
            humanos.Add(persona);
            humanos.Add(profesor);
            humanos.Add(alumno);

            humano.Dni = 1;
            persona.Dni = 2;
            profesor.Dni = 3;
            alumno.Dni = 4;
            alumno.PATH = "lolazo.xml";
            profesor.Titulo = "Tecnico en Sistemas informatico";
            alumno.Legajo = 9000;
            Console.WriteLine(humano.ToString());
            Console.WriteLine(persona.ToString());
            Console.WriteLine(alumno.ToString());
            if (Program.SerializarHumanos(humanos))
            {
                Console.WriteLine("Serializacion Completa");
            }

            else
            {
                Console.WriteLine("Serializacion Fracasada");
            }

            if (Program.SerializarHumano((Humano)profesor))
            {
                Console.WriteLine("Serializacion Completa");
            }

            else
            {
                Console.WriteLine("Serializacion Fracasada");
            }

            if (Program.SerializarAlumno(alumno))
            {
                Console.WriteLine("Serializacion Completa");
            }

            else
            {
                Console.WriteLine("Serializacion Fracasada");
            }
            if (((ISerializableBinario)profesor).Serializar())
            {
                Console.WriteLine("Serializacion Completa");
            }

            else
            {
                Console.WriteLine("Serializacion Fracasada");
            }
            Console.WriteLine(profesor.ToString());

            Console.WriteLine(Program.DeserializarAlumno().ToString());
            Console.WriteLine(Program.DeserializarHumano().ToString());
            foreach(Humano h in Program.DeserializarHumanos())
            {
                Console.WriteLine(h.ToString());
            }
            Console.ReadLine();
            
        }
        public static bool SerializarXml(ISerializableXML o)
        {
            return o.Serializar();
        }
        public static bool SerializarHumano(Humano a)
        {
            bool resultado = false;
            try  // muchas de las lineas de este codigo pueden lanzar una excepcion
            {

                XmlSerializer serializer = new XmlSerializer(typeof(Humano));
                using (StreamWriter writer = new StreamWriter("Humanos.xml"))
                {
                    serializer.Serialize(writer, a);

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
        public static bool SerializarHumanos(List<Humano> a)
        {
            bool resultado = false;
            try  // muchas de las lineas de este codigo pueden lanzar una excepcion
            {

                XmlSerializer serializer = new XmlSerializer(typeof(List<Humano>));
                using (StreamWriter writer = new StreamWriter("lista.xml"))
                {
                    serializer.Serialize(writer, a);

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
        public static List<Humano> DeserializarHumanos()
        {
            List<Humano> humanos = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Humano>));

                using (StreamReader reader = new StreamReader("lista.xml"))
                {
                    humanos = (List<Humano>)serializer.Deserialize(reader);
 
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
            return humanos;
        }
        public static Humano DeserializarHumano()
        {
            Humano alumno = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Humano));

                using (StreamReader reader = new StreamReader("humanos.xml"))
                {
                    alumno = (Humano)serializer.Deserialize(reader);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
            return alumno;
        }
        public static bool SerializarAlumno(Alumno a)
        {
            bool resultado = false;
            try  // muchas de las lineas de este codigo pueden lanzar una excepcion
            {

                XmlSerializer serializer = new XmlSerializer(typeof(Alumno));
                using (StreamWriter writer = new StreamWriter("Pathos.xml"))
                {
                    serializer.Serialize(writer, a);

                }
                resultado = true;
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }

            return resultado;
        }
        public static Alumno DeserializarAlumno()
        {
            Alumno alumno = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Alumno));

                using (StreamReader reader = new StreamReader("Pathos.xml"))
                {
                    alumno = (Alumno)serializer.Deserialize(reader);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
            return alumno;
        }
    }


}
