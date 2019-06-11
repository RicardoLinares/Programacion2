using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase19.Entidades;
namespace Clase19.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos acceso = new AccesoDatos();
            Persona otro = new Persona(1, "Tito", "Manazas", 69);
            bool agregar = acceso.AgregarPersona(otro);
            if (agregar)
                Console.WriteLine("SE AGREGO CORRECTAMENTE!!");
            List<Persona> personas = acceso.TraerTodos();
            foreach(Persona i in personas)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
