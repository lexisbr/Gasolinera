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

        private decimal precioDelDia = 34m;
        private string tipoLlenado;
        private int bombaSeleccionada;
        private string tipoCantidad;
        private Despacho despachoTanqueLlenoB1;
        private Despacho despachoTanqueLlenoB2;
        private Despacho despachoTanqueLlenoB3;
        private Despacho despachoTanqueLlenoB4;

        public Form1()
        {
            InitializeComponent();
            ControlesGasolinera.FillListaDespachos();
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
                SetLabelsValues(litrosActuales);
;            } 
            else
            {
                MessageBox.Show(data.message);
                if (data.message == "Ha finalizado el llenado") {
                    if (tipoLlenado == "Tanque lleno") {
                        CerrarDespachoTanqueLleno();
                    }
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
            
            try {
                
                bombaSeleccionada = ObtenerBombaSeleccionada();
                tipoLlenado = ObtenerTipoLlenado();
                string cliente = nombreClienteTb.Text;
                ResetBombas();
                if (cliente.Trim().Length > 0)
                {
                    if (tipoLlenado == "Prepago")
                    {
                        tipoCantidad = ObtenerCantidadSeleccionada();
                        decimal limiteLitros = ObtenerLimiteLitros(tipoCantidad);
                        decimal cantidadDinero = ControlesGasolinera.ObtenerCantidadDinero(limiteLitros);
                        ControlesGasolinera.AddDespacho(cliente, tipoLlenado, limiteLitros, cantidadDinero, $"Bomba {bombaSeleccionada}");
                        arduinoCom.sendMessageArduino(serialPort1, tipoLlenado.ToString(), limiteLitros.ToString());
                    }
                    else
                    {
                        arduinoCom.sendMessageArduino(serialPort1, tipoLlenado.ToString(), 0.ToString());
                        GenerarDespachoTanqueLleno(cliente);

                    }
                }
                else {
                    MessageBox.Show("Debes ingresar un nombre para el cliente");
                }

               
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private decimal ObtenerLimiteLitros(string tipoCantidad) {
            try {
                decimal limite = Decimal.Parse(cantidadTb.Text);
                if (tipoCantidad == "Q")
                {
                    return ControlesGasolinera.ObtenerCantidadLitros(limite);
                }
                return limite;
            } catch(Exception ex) {
                throw ex; 
            }
        }


        private string ObtenerCantidadSeleccionada() {
            if (quetzalesRb.Checked) return "Q";
            else if (litrosRb.Checked) return "L";
            return "";
        }

       private void SetLabelsValues(decimal litros)
        {
            switch (bombaSeleccionada)
            {
                case 1:
                    litrosBomba1.Text = litros.ToString();
                    dineroBomba1.Text = ControlesGasolinera.CantidadDineroToString(litros);
                    break;
                case 2:
                    litrosB2Tb.Text = litros.ToString();
                    dineroB2Tb.Text = ControlesGasolinera.CantidadDineroToString(litros);
                    break;
                case 3:
                    litrosB3Tb.Text = litros.ToString();
                    dineroB3Tb.Text = ControlesGasolinera.CantidadDineroToString(litros);
                    break;
                case 4:
                    litrosB4Tb.Text = litros.ToString();
                    dineroB4Tb.Text = ControlesGasolinera.CantidadDineroToString(litros);
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

        private void ResetBombas() {
            switch (bombaSeleccionada)
            {
                case 1:
                    litrosBomba1.Text = "0.00";
                    dineroBomba1.Text = "0.00";
                    break;
                case 2:
                    litrosB2Tb.Text = "0.00";
                    dineroB2Tb.Text = "0.00";
                    break;
                case 3:
                    despachoTanqueLlenoB3.CantidadLitros = Decimal.Parse(litrosB3Tb.Text);
                    despachoTanqueLlenoB3.DineroPagado = Decimal.Parse(dineroB3Tb.Text);
                    ControlesGasolinera.AddDespacho(despachoTanqueLlenoB3);
                    break;
                case 4:
                    despachoTanqueLlenoB4.CantidadLitros = Decimal.Parse(litrosB4Tb.Text);
                    despachoTanqueLlenoB4.DineroPagado = Decimal.Parse(dineroB4Tb.Text);
                    ControlesGasolinera.AddDespacho(despachoTanqueLlenoB4);
                    break;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            prepagoGb.Enabled = prepagoRb.Checked;
        }

        public string ObtenerTipoLlenado()
        {
            
            if (prepagoRb.Checked)
            {
                return "Prepago";
            }
            else if (tanquellenoRb.Checked)
            {
                return "Tanque lleno";
            }
            else
            {
                return "";
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
            habilitarBt.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void litrosB2Tb_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (precioDiaTb.Enabled == true)
            {
                try
                {
                    decimal precioDia = Decimal.Parse(precioDiaTb.Text);
                    ControlesGasolinera.PrecioDelDia = precioDia;
                    MessageBox.Show("Se ha guardado el precio del día");
                    precioDiaTb.Enabled = false;
                    tipoLlenadoGb.Enabled = true;
                    bombaGb.Enabled = true;
                    precioDiaBtn.Text = "Editar";
                    prepagoRb.Select();
                }
                catch
                {
                    MessageBox.Show("Ingresa un valor valido");
                }
            }
            else {
                precioDiaTb.Enabled = true;
                precioDiaBtn.Text = "Guardar";
            }
            
        }

        private void GenerarDespachoTanqueLleno(string cliente) {
            switch (bombaSeleccionada) {
                case 1:
                    despachoTanqueLlenoB1 = new Despacho(cliente, tipoLlenado, $"Bomba {bombaSeleccionada}");
                    break;
                case 2:
                    despachoTanqueLlenoB2 = new Despacho(cliente, tipoLlenado, $"Bomba {bombaSeleccionada}");
                    break;
                case 3:
                    despachoTanqueLlenoB3 = new Despacho(cliente, tipoLlenado, $"Bomba {bombaSeleccionada}");
                    break;
                case 4:
                    despachoTanqueLlenoB4 = new Despacho(cliente, tipoLlenado, $"Bomba {bombaSeleccionada}");
                    break;
            }

            

        }

        private void CerrarDespachoTanqueLleno() {
            switch (bombaSeleccionada)
            {
                case 1:
                    despachoTanqueLlenoB1.CantidadLitros = Decimal.Parse(litrosBomba1.Text);
                    despachoTanqueLlenoB1.DineroPagado = Decimal.Parse(dineroBomba1.Text);
                    ControlesGasolinera.AddDespacho(despachoTanqueLlenoB1);
                    break;
                case 2:
                    despachoTanqueLlenoB2.CantidadLitros = Decimal.Parse(litrosB2Tb.Text);
                    despachoTanqueLlenoB2.DineroPagado = Decimal.Parse(dineroB2Tb.Text);
                    ControlesGasolinera.AddDespacho(despachoTanqueLlenoB2);
                    break;
                case 3:
                    despachoTanqueLlenoB3.CantidadLitros = Decimal.Parse(litrosB3Tb.Text);
                    despachoTanqueLlenoB3.DineroPagado = Decimal.Parse(dineroB3Tb.Text);
                    ControlesGasolinera.AddDespacho(despachoTanqueLlenoB3);
                    break;
                case 4:
                    despachoTanqueLlenoB4.CantidadLitros = Decimal.Parse(litrosB4Tb.Text);
                    despachoTanqueLlenoB4.DineroPagado = Decimal.Parse(dineroB4Tb.Text);
                    ControlesGasolinera.AddDespacho(despachoTanqueLlenoB4);
                    break;
            }
        }

        private void LoadReportes(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) {
                List<Despacho> listaDespachos = ControlesGasolinera.ListaDespachos;
                List<Despacho> cierreCajaDiario = Reportes.CierresDeCajaDiarios(listaDespachos, DateTime.Today);
                List<Despacho> despachosPrepago = Reportes.DespachosPrepago(listaDespachos);
                List<Despacho> despachosTLleno = Reportes.DespachosTanqueLleno(listaDespachos);
                (string bombaMasUsada, string bombaMenosUsada) = Reportes.ObtenerUsoBombas(listaDespachos);

                despachosDiaGr.DataSource = cierreCajaDiario;
                despachosPrepagoGr.DataSource = despachosPrepago;
                despachosTLlenoGr.DataSource = despachosTLleno;
                bombasGr.Rows.Clear();
                bombasGr.Rows.Add("Bomba menos usada", bombaMenosUsada);
                bombasGr.Rows.Add("Bomba más usada", bombaMasUsada);
            }
           
        }
    }
}
