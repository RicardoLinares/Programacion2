using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase19.Entidades;
using System.Data;
namespace Clase19.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //AccesoDatos acceso = new AccesoDatos();
            //Persona otro = new Persona(1, "Tito", "Manazas", 69);
            //bool agregar = acceso.AgregarPersona(otro);
            //if (agregar)
            //    Console.WriteLine("SE AGREGO CORRECTAMENTE!!");
            //List<Persona> personas = acceso.TraerTodos();
            //foreach(Persona i in personas)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            //int idDelPrimero = personas[0]._id;

            //if(acceso.EliminarPersona(idDelPrimero))
            //{
            //    Console.WriteLine("Se borro el primero de la lista");
            //}

            //personas[2]._nombre = "Marcos";
            //personas[2]._apellido = "Vitali";
            //personas[2]._edad = 40;
            //personas[3]._nombre = "Mariano";
            //personas[3]._apellido = "Vitali";
            //personas[3]._edad = 20;
            //personas[4]._nombre = "Facundo";
            //personas[4]._apellido = "Mayordomo";
            //personas[4]._edad = 19;
            //personas[5]._nombre = "Ana";
            //personas[5]._apellido = "Suarez";
            //personas[5]._edad = 45;
            //acceso.ModificarPersona(personas[3]);
            //acceso.ModificarPersona(personas[4]);
            //acceso.ModificarPersona(personas[5]);

            //if (acceso.ModificarPersona(personas[2]))
            //{
            //    Console.WriteLine("Se modifico la persona con el id " + personas[2]._id);
            //}
            DataTable asd = new DataTable();
            asd.ReadXmlSchema("Persona_esquema.xml");
            asd.ReadXml("Persona_datos.xml");
            //foreach(DataRow row in asd.Rows)
            //{
            //    int id = (int)row[0];
            //    string nombre = (string)row[1];
            //    string apellido = (string)row[2];
            //    int edad = (int)row[3];
            //    Persona newPersona = new Persona(id, nombre, apellido, edad);

            //    Console.WriteLine(newPersona.ToString());
            //}
            //asd.WriteXmlSchema("Persona_esquema.xml");
            //asd.WriteXml("Persona_datos.xml");
            Console.ReadLine();
        }
    }
}
