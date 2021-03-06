﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;
namespace Clase09.Entidades
{
    public class Lavandero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;


        public string Vehiculos
        {
            get
            {
                string vehiculosStr = "";

                foreach (Vehiculo transporte in _vehiculos)
                {
                    vehiculosStr += transporte;
                    vehiculosStr += "\n\n";
                    //    if(transporte is Moto)
                    //    {
                    //        vehiculos += ((Moto)transporte).MostrarMoto();
                    //    }
                    //    else if(transporte is Auto)
                    //    {
                    //        vehiculos += ((Auto)transporte).MostrarAuto();
                    //    }
                    //    else  if(transporte is Camion)
                    //    {
                    //        vehiculos +=  ((Camion)transporte).MostrarCamion();
                    //    }
                    //    vehiculos += "\n";
                }
                    return vehiculosStr;
            }
        }
        public string MiLavandero
        {
            get
            {
                string infoLavandero;
                infoLavandero = "Precio por Auto: " + this._precioAuto.ToString()+"\n";
                infoLavandero += "Precio por Moto: " + this._precioMoto.ToString()+ "\n";
                infoLavandero += "Precio por Camion: " + this._precioCamion.ToString()+ "\n";
                infoLavandero += this.Vehiculos + "\n";
                return infoLavandero;
            }
        }
        public Lavandero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        private Lavandero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public static bool operator ==(Lavandero lavandero, Vehiculo vehiculo)
        {
            bool respuesta = false;
            if(lavandero._vehiculos.IndexOf(vehiculo) != -1)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator !=(Lavandero lavandero, Vehiculo vehiculo)
        {
            return !(lavandero == vehiculo);
        }

        public static Lavandero operator +(Lavandero lavandero, Vehiculo vehiculo)
        {
            if(lavandero != vehiculo)
            {
                lavandero._vehiculos.Add(vehiculo);
            }
            return lavandero;
        }

        public static Lavandero operator -(Lavandero lavandero, Vehiculo vehiculo)
        {
            if(lavandero == vehiculo)
            {
                lavandero._vehiculos.Remove(vehiculo);
            }
            return lavandero;
        }

        public double MostrarTotalFacturado()
        {
            double resultado = 0;
            resultado += MostrarTotalFacturado(EVehiculos.Auto);
            resultado += MostrarTotalFacturado(EVehiculos.Camion);
            resultado += MostrarTotalFacturado(EVehiculos.Moto);

            return resultado;
        }

        public double MostrarTotalFacturado(EVehiculos tipoDeVehiculo)
        {

            double resultado = 0;

            foreach (Vehiculo cliente in this._vehiculos)
            {
                if (cliente is Auto && tipoDeVehiculo == EVehiculos.Auto)
                {
                        resultado += _precioAuto;
                }
                else if (cliente is Moto && tipoDeVehiculo == EVehiculos.Moto)
                {
                        resultado += _precioMoto;

                }
                else if (cliente is Camion && tipoDeVehiculo == EVehiculos.Camion)
                {
                        resultado += _precioCamion;
                }
            }

            return resultado;
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            return String.Compare(vehiculoA.Patente, vehiculoB.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            return String.Compare(vehiculoA.Marca.ToString(), vehiculoB.Marca.ToString());
        }
    }
}
