using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace ClaseEspecial
{
    [TestClass] // atributo de clase
    public class UnitTest1
    {
        [TestMethod] // atributo de metodo
        public void TestMethod1()
        {
            Estacionamiento estacionamiento = new Estacionamiento(5);
            Assert.IsNotNull(estacionamiento.Autos);
        }
        [TestMethod]
        public void EspacioEstacionamientoIncorrecto()
        {
            int espacios = 101;
            Estacionamiento estacionamiento = new Estacionamiento(espacios);
            if(estacionamiento.EspacioDisponible != espacios)
            {
                Assert.Fail("El Espacio disponible debe ser " + espacios);
            }

            Estacionamiento estacionamiento2 = new Estacionamiento(0);
            Assert.AreNotEqual(estacionamiento2.EspacioDisponible, 1);


            if(estacionamiento.EspacioDisponible == 0)
            {
                Assert.Fail("La propiedad es distinta al valor dado");
            }
        }

        [TestMethod]
        public void AgregarAutos()
        {
            Estacionamiento estacionamiento = new Estacionamiento(2);
            Auto auto1 = new Auto("Ricardudo", ConsoleColor.Blue);
            Auto auto2 = new Auto("Peado", ConsoleColor.Red);
            Auto auto3 = new Auto("Creado", ConsoleColor.Red);
            try
            {
                estacionamiento += auto1;
                estacionamiento += auto2;
                estacionamiento += auto3;
                Assert.Fail("NO SE DEBERIA PODER AÑADIR 3 AUTOS");
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(EstacionamientoLlenoException));
            }

        }
        [TestMethod]
        public void SubstracionDeEspacio()
        {
            Estacionamiento estacionamiento = new Estacionamiento(2);
            Auto auto1 = new Auto("AAAAA", ConsoleColor.Blue);
            Auto auto2 = new Auto("ZZZZZ", ConsoleColor.Red);

            estacionamiento += auto1;
            Assert.AreEqual(1, estacionamiento.EspacioDisponible);

            estacionamiento += auto2;
            Assert.AreEqual(0, estacionamiento.EspacioDisponible);
        }
    }
}
