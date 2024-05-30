using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class Despacho
    {
        private static int counter = 0;
        private int id;
        private string nombreCliente;
        private DateTime fechaDespacho;
        private string tipoLlenado;
        private decimal cantidadLitros;
        private decimal dineroPagado;
        private string bomba;

        public Despacho(int id, string nombreCliente, DateTime fechaDespacho, string tipoLlenado, decimal cantidadLitros, decimal dineroPagado, string bomba) {
            Id = id;
            NombreCliente = nombreCliente;
            FechaDespacho = fechaDespacho;
            TipoLlenado = tipoLlenado;
            CantidadLitros = cantidadLitros;
            DineroPagado = dineroPagado;
            Bomba = bomba;
        }

        public Despacho(string nombreCliente, string tipoLlenado, decimal cantidadLitros, decimal dineroPagado, string bomba)
        {
            Id = counter++;
            NombreCliente = nombreCliente;
            FechaDespacho = DateTime.Now;
            TipoLlenado = tipoLlenado;
            CantidadLitros = cantidadLitros;
            DineroPagado = dineroPagado;
            Bomba = bomba; 

        }

        public Despacho(string nombreCliente, string tipoLlenado, string bomba) {
            Id = counter++;
            NombreCliente = nombreCliente;
            FechaDespacho = DateTime.Now;
            TipoLlenado = tipoLlenado;
            Bomba = bomba;
        }

        public int Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public DateTime FechaDespacho { get => fechaDespacho; set => fechaDespacho = value; }
        public string TipoLlenado { get => tipoLlenado; set => tipoLlenado = value; }
        public decimal CantidadLitros { get => cantidadLitros; set => cantidadLitros = value; }
        public decimal DineroPagado { get => dineroPagado; set => dineroPagado = value; }
        public string Bomba { get => bomba; set => bomba = value; }
    }
}
