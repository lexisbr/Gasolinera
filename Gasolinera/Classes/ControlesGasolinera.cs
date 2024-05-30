using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class ControlesGasolinera
    {
        private static decimal precioDelDia;
        private static List<Despacho> listaDespachos = new List<Despacho>();

        public static decimal PrecioDelDia { get => precioDelDia; set => precioDelDia = value; }
        internal static List<Despacho> ListaDespachos { get => listaDespachos; set => listaDespachos = value; }

        public static decimal ObtenerCantidadLitros(decimal flowValue)
        {
            return Math.Round(flowValue / PrecioDelDia, 2);
        }

        public static decimal ObtenerCantidadDinero(decimal flowValue)
        {
            return Math.Round(flowValue * PrecioDelDia, 2);
        }

        public static string CantidadDineroToString(decimal flowValue)
        {
            return ObtenerCantidadDinero(flowValue).ToString("F2");
        }

        public static void AddDespacho(string nombreCliente, string tipoLlenado, decimal cantidadLitros, decimal dineroPagado, string bomba) {
            Despacho newDespacho = new Despacho(nombreCliente, tipoLlenado, cantidadLitros, dineroPagado, bomba);
            ListaDespachos.Add(newDespacho);
            try { 
                Archivos.WriteDespacho(newDespacho);
            } catch(Exception ex) {
                throw new Exception($"Error al escribir en archivo: {ex}");
            }
        }

        public static void AddDespacho(Despacho despacho) {
            ListaDespachos.Add(despacho);
            try
            {
                Archivos.WriteDespacho(despacho);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al escribir en archivo: {ex}");
            }

        }


    }
}
