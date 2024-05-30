using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class Reportes
    {
        public static List<Despacho> CierresDeCajaDiarios(List<Despacho> abastecimientos, DateTime dia)
        {
            return abastecimientos.Where(a => a.FechaDespacho.Date == dia.Date).ToList();
        }

        public static List<Despacho> AbastecimientosPrepago(List<Despacho> abastecimientos)
        {
            return abastecimientos.Where(a => a.TipoLlenado.Equals("Prepago", StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Despacho> AbastecimientosTanqueLleno(List<Despacho> abastecimientos)
        {
            return abastecimientos.Where(a => a.TipoLlenado.Equals("Tanque lleno", StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static (string bombaMasUsada, string bombaMenosUsada) ObtenerUsoBombas(List<Despacho> abastecimientos)
        {
            var grupoBombas = abastecimientos.GroupBy(a => a.Bomba)
                                             .Select(g => new { Bomba = g.Key, Conteo = g.Count() })
                                             .OrderByDescending(g => g.Conteo).ToList();

            var bombaMasUsada = grupoBombas.FirstOrDefault()?.Bomba;
            var bombaMenosUsada = grupoBombas.LastOrDefault()?.Bomba;

            return (bombaMasUsada, bombaMenosUsada);
        }
    }
}
