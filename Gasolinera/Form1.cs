using Gasolinera.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gasolinera
{
    public partial class Form1 : Form
    {
        private static ArduinoCommmunication arduinoCom = new ArduinoCommmunication();
        private static ControlesGasolinera controles = new ControlesGasolinera();

        private decimal precioDelDia = 34m;
        private int tipoLlenado;

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
        }

        void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string dato = serialPort1.ReadLine();//Leer datos del puerto serial
            this.Invoke(new MethodInvoker(delegate//Mostrar datos en el formulario
            {
                if (dato.Trim() != "") {
                    deserializeJson(dato);
                }
            }));
        }

        private void deserializeJson(string json) {
            JSONMessage data = JsonConvert.DeserializeObject<JSONMessage>(json);//Deserializar el JSON

            if(data.message == null) { 
                decimal litrosActuales = Decimal.Parse(data.flowValue);
                int bombaSeleccionada = ObtenerBombaSeleccionada();
                SetLabelsValues(bombaSeleccionada, litrosActuales);
;            } 
            else
            {
                MessageBox.Show(data.message);
                if (data.message == "Ha finalizado el llenado") {
                    litrosBomba1.Text = "0.00";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void galonesRb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cantidad = cantidadTb.Text;
            decimal limite = Decimal.Parse(cantidad);
            string opcionSeleccionada = ObtenerOpcionSeleccionada();
            int bombaSeleccionada = ObtenerBombaSeleccionada();
            //IniciarValores(bombaSeleccionada, opcionSeleccionada == "L");
            arduinoCom.sendMessageArduino(serialPort1, tipoLlenado.ToString(), limite.ToString());
        }

        private string ObtenerOpcionSeleccionada() {
            if (quetzalesRb.Checked) return "Q";
            else if (litrosRb.Checked) return "L";
            return "";
        }

       private void SetLabelsValues(int numBomba, decimal litros)
        {
            switch (numBomba)
            {
                case 1:
                    litrosBomba1.Text = litros.ToString();
                    dineroBomba1.Text = controles.CantidadDineroToString(litros);
                    break;
                case 2:
                    litrosB2Tb.Text = litros.ToString();
                    dineroB2Tb.Text = controles.CantidadDineroToString(litros);
                    break;
                case 3:
                    litrosB3Tb.Text = litros.ToString();
                    dineroB3Tb.Text = controles.CantidadDineroToString(litros);
                    break;
                case 4:
                    litrosB4Tb.Text = litros.ToString();
                    dineroB4Tb.Text = controles.CantidadDineroToString(litros);
                    break;
            }
        }


        private int ObtenerBombaSeleccionada() {
            string bombaSeleccionada = bombasCb.SelectedItem.ToString();
            switch (bombaSeleccionada) {
                case "Bomba 1":
                    return 1;
                case "Bomba 2":
                    return 2;
                case "Bomba 3":
                    return 3;
                case "Bomba 4":
                    return 4;
                default:
                    return 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarTipoLlenado();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarTipoLlenado();
        }

        public void CambiarTipoLlenado()
        {
            prepagoGb.Enabled = prepagoRb.Checked;
            if (prepagoRb.Checked)
            {
                tipoLlenado = 0;
            }
            else if (tanquellenoRb.Checked)
            {
                tipoLlenado = 1;
            }
            else
            {
                tipoLlenado = -1;
            }
        }

        private void galsBomba1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void dineroBomba1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bombasCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void litrosB2Tb_Click(object sender, EventArgs e)
        {

        }
    }
}
