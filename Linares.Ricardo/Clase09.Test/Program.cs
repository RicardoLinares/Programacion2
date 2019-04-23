using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;
using Clase09.Entidades;
namespace Clase09.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavandero lavandero = new Lavandero(10, 10, 10);
            Auto auto = new Auto(4, "DDD 66", EMarca.Honda, 4);
            Moto moto = new Moto(2f, "ABC 12", EMarca.Zanella, 2);
            Camion camion = new Camion(99f, "EWD 02", EMarca.Ford, 8);
            lavandero += auto;
            lavandero += moto;
            lavandero += camion;
            auto.Precio = 1000;
            Console.WriteLine(lavandero.MiLavandero);
            Console.WriteLine("Ingresos totales : " + lavandero.MostrarTotalFacturado());
            Console.WriteLine(auto.CalcularPrecioConIva());
            Console.ReadLine();
        }
    }
}
