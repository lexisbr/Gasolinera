using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class ControlesGasolinera
    {
        private decimal precioDelDia;

        public decimal ObtenerCantidadLitros(decimal flowValue)
        {
            return Math.Round(flowValue / precioDelDia, 2);
        }

        public decimal ObtenerCantidadDinero(decimal flowValue)
        {
            return Math.Round(flowValue * precioDelDia, 2);
        }

        public string CantidadDineroToString(decimal flowValue)
        {
            return ObtenerCantidadDinero(flowValue).ToString("F2");
        }


    }
}
