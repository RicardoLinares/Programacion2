using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.Entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public string Mostrar()
        {
            return this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToShortDateString();
        }

        public static string Mostrar(Cosa cosa)
        {
            return cosa.Mostrar();
        }

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void EstablecerValor(DateTime time)
        {
            this.fecha = time;
        }


        public Cosa()// constructor de cosa
        {
            this.entero = 10;
            this.fecha = DateTime.Now;
            this.cadena = "sinvalor";
        }
        public Cosa(int entero) : this() // llama al contructor "base"
        {
            this.entero = entero;
        }
        public Cosa(int entero, DateTime fecha) : this(entero)// llama a la sobrecarga que inicializa entero
        {
            this.fecha = fecha;
        }
        public Cosa(int entero, DateTime fecha, string cadena) : this(entero, fecha)  // llama a la sobrecarga que inicializa fecha
        {
            this.cadena = cadena;
        }
    }
}
