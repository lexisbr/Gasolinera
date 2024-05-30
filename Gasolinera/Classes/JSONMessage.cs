using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Classes
{
    internal class JSONMessage
    {
        public string tipoLlenado { get; set; }

        public string litros { get; set; }

        public string flowValue { get; set; }

        public string message { get; set; }


        public JSONMessage() { }
    }
}
