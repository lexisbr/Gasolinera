using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class Archivos
    {
        private const string pathArchivo = "C:\\Users\\Alejandro Barrios\\source\\repos\\Gasolinera\\Gasolinera\\database.txt";
        public static void WriteDespacho(Despacho despacho) {
            try
            {
                using (StreamWriter writer = new StreamWriter(pathArchivo, append: true))
                {
                    writer.WriteLine($"{despacho.Id};{despacho.NombreCliente};{despacho.FechaDespacho};{despacho.Bomba};{despacho.TipoLlenado};{despacho.DineroPagado};{despacho.CantidadLitros};");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Despacho> LeerArchivo(string rutaArchivo)
        {
            List<Despacho> despachos = new List<Despacho>();
            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var linea in lineas.Skip(1))
            {
                var columnas = linea.Split(';');

                Despacho despacho = new Despacho(
                        int.Parse(columnas[0]),
                        columnas[1].ToString(),
                        DateTime.Parse(columnas[2]),
                        columnas[4].ToString(),
                        decimal.Parse(columnas[5]),
                        decimal.Parse(columnas[6]),
                        columnas[3].ToString()
                   );
                despachos.Add(despacho);
            }

            return despachos;
        }




    }
}
