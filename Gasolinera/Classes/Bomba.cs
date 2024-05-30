using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class Bomba
    {
        private decimal contador;
        private decimal limite;
        private bool sonLitros;

        public Bomba()
        {
            contador = 0;
        }

        public decimal Contador { get => contador; set => contador = value; }
        public decimal Limite { get => limite; set => limite = value; }
        public bool SonLitros { get => sonLitros; set => sonLitros = value; }

        public bool HaTerminado() {
            return this.Contador >= this.Limite;
        }
        public string ContadorToString() {
            return Math.Round(this.Contador, 2).ToString("F2");
        }

        public void IncrementarContador(decimal value) {
            Contador += value;
        }

        public decimal ObtenerCantidadDinero(decimal precioDelDia) {
            return Math.Round(Contador * precioDelDia, 2);
        }

        public decimal ObtenerCantidadLitros(decimal precioDelDia)
        {
            return Math.Round(Contador / precioDelDia, 2);
        }

        public string CantidadLitrosToString(decimal precioDelDia) {
            return ObtenerCantidadLitros(precioDelDia).ToString("F2");
        }
        public string CantidadDineroToString(decimal precioDelDia)
        {
            return ObtenerCantidadDinero(precioDelDia).ToString("F2");
        }
    }
}
