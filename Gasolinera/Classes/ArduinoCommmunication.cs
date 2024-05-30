using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class ArduinoCommmunication
    {

        public void sendMessageArduino(SerialPort serialPort, string tipoLlenado, string litros)
        {
            JSONMessage message = new JSONMessage();
            message.tipoLlenado = tipoLlenado;
            message.litros = litros;
            string json = JsonConvert.SerializeObject(message);

            serialPort.WriteLine(json);
        }
    }
}
