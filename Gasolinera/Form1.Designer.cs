namespace Gasolinera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.litrosBomba1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dineroBomba1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.litrosB2Tb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dineroB2Tb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.litrosB3Tb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dineroB3Tb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.litrosB4Tb = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dineroB4Tb = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bombasCb = new System.Windows.Forms.ComboBox();
            this.prepagoGb = new System.Windows.Forms.GroupBox();
            this.cantidadTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quetzalesRb = new System.Windows.Forms.RadioButton();
            this.litrosRb = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tanquellenoRb = new System.Windows.Forms.RadioButton();
            this.prepagoRb = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.prepagoGb.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(60, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bomba 1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Detener";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.litrosBomba1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(6, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 49);
            this.panel2.TabIndex = 5;
            // 
            // litrosBomba1
            // 
            this.litrosBomba1.AutoSize = true;
            this.litrosBomba1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.litrosBomba1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litrosBomba1.ForeColor = System.Drawing.Color.SpringGreen;
            this.litrosBomba1.Location = new System.Drawing.Point(50, 3);
            this.litrosBomba1.Name = "litrosBomba1";
            this.litrosBomba1.Size = new System.Drawing.Size(99, 43);
            this.litrosBomba1.TabIndex = 1;
            this.litrosBomba1.Text = "0.00";
            this.litrosBomba1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.litrosBomba1.Click += new System.EventHandler(this.dineroBomba1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SpringGreen;
            this.label8.Location = new System.Drawing.Point(5, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 43);
            this.label8.TabIndex = 2;
            this.label8.Text = "L";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.dineroBomba1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(7, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 49);
            this.panel1.TabIndex = 4;
            // 
            // dineroBomba1
            // 
            this.dineroBomba1.AutoSize = true;
            this.dineroBomba1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dineroBomba1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineroBomba1.ForeColor = System.Drawing.Color.SpringGreen;
            this.dineroBomba1.Location = new System.Drawing.Point(49, 3);
            this.dineroBomba1.Name = "dineroBomba1";
            this.dineroBomba1.Size = new System.Drawing.Size(99, 43);
            this.dineroBomba1.TabIndex = 1;
            this.dineroBomba1.Text = "0.00";
            this.dineroBomba1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dineroBomba1.Click += new System.EventHandler(this.galsBomba1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "Q. ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(312, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bomba 2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.litrosB2Tb);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(6, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 49);
            this.panel4.TabIndex = 6;
            // 
            // litrosB2Tb
            // 
            this.litrosB2Tb.AutoSize = true;
            this.litrosB2Tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.litrosB2Tb.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litrosB2Tb.ForeColor = System.Drawing.Color.SpringGreen;
            this.litrosB2Tb.Location = new System.Drawing.Point(50, 3);
            this.litrosB2Tb.Name = "litrosB2Tb";
            this.litrosB2Tb.Size = new System.Drawing.Size(99, 43);
            this.litrosB2Tb.TabIndex = 1;
            this.litrosB2Tb.Text = "0.00";
            this.litrosB2Tb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.litrosB2Tb.Click += new System.EventHandler(this.litrosB2Tb_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SpringGreen;
            this.label7.Location = new System.Drawing.Point(5, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 43);
            this.label7.TabIndex = 2;
            this.label7.Text = "L";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.dineroB2Tb);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(7, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 49);
            this.panel3.TabIndex = 5;
            // 
            // dineroB2Tb
            // 
            this.dineroB2Tb.AutoSize = true;
            this.dineroB2Tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dineroB2Tb.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineroB2Tb.ForeColor = System.Drawing.Color.SpringGreen;
            this.dineroB2Tb.Location = new System.Drawing.Point(49, 3);
            this.dineroB2Tb.Name = "dineroB2Tb";
            this.dineroB2Tb.Size = new System.Drawing.Size(99, 43);
            this.dineroB2Tb.TabIndex = 1;
            this.dineroB2Tb.Text = "0.00";
            this.dineroB2Tb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 43);
            this.label5.TabIndex = 2;
            this.label5.Text = "Q. ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Location = new System.Drawing.Point(564, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 289);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bomba 3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.litrosB3Tb);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(6, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 49);
            this.panel5.TabIndex = 8;
            // 
            // litrosB3Tb
            // 
            this.litrosB3Tb.AutoSize = true;
            this.litrosB3Tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.litrosB3Tb.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litrosB3Tb.ForeColor = System.Drawing.Color.SpringGreen;
            this.litrosB3Tb.Location = new System.Drawing.Point(50, 3);
            this.litrosB3Tb.Name = "litrosB3Tb";
            this.litrosB3Tb.Size = new System.Drawing.Size(99, 43);
            this.litrosB3Tb.TabIndex = 1;
            this.litrosB3Tb.Text = "0.00";
            this.litrosB3Tb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SpringGreen;
            this.label10.Location = new System.Drawing.Point(5, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 43);
            this.label10.TabIndex = 2;
            this.label10.Text = "L";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Controls.Add(this.dineroB3Tb);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(7, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(233, 49);
            this.panel6.TabIndex = 7;
            // 
            // dineroB3Tb
            // 
            this.dineroB3Tb.AutoSize = true;
            this.dineroB3Tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dineroB3Tb.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineroB3Tb.ForeColor = System.Drawing.Color.SpringGreen;
            this.dineroB3Tb.Location = new System.Drawing.Point(49, 3);
            this.dineroB3Tb.Name = "dineroB3Tb";
            this.dineroB3Tb.Size = new System.Drawing.Size(99, 43);
            this.dineroB3Tb.TabIndex = 1;
            this.dineroB3Tb.Text = "0.00";
            this.dineroB3Tb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SpringGreen;
            this.label12.Location = new System.Drawing.Point(3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 43);
            this.label12.TabIndex = 2;
            this.label12.Text = "Q. ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel7);
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Location = new System.Drawing.Point(816, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 289);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bomba 4";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Controls.Add(this.litrosB4Tb);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(6, 74);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 49);
            this.panel7.TabIndex = 10;
            // 
            // litrosB4Tb
            // 
            this.litrosB4Tb.AutoSize = true;
            this.litrosB4Tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.litrosB4Tb.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litrosB4Tb.ForeColor = System.Drawing.Color.SpringGreen;
            this.litrosB4Tb.Location = new System.Drawing.Point(50, 3);
            this.litrosB4Tb.Name = "litrosB4Tb";
            this.litrosB4Tb.Size = new System.Drawing.Size(99, 43);
            this.litrosB4Tb.TabIndex = 1;
            this.litrosB4Tb.Text = "0.00";
            this.litrosB4Tb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SpringGreen;
            this.label14.Location = new System.Drawing.Point(5, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 43);
            this.label14.TabIndex = 2;
            this.label14.Text = "L";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Controls.Add(this.dineroB4Tb);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(7, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 49);
            this.panel8.TabIndex = 9;
            // 
            // dineroB4Tb
            // 
            this.dineroB4Tb.AutoSize = true;
            this.dineroB4Tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dineroB4Tb.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineroB4Tb.ForeColor = System.Drawing.Color.SpringGreen;
            this.dineroB4Tb.Location = new System.Drawing.Point(49, 3);
            this.dineroB4Tb.Name = "dineroB4Tb";
            this.dineroB4Tb.Size = new System.Drawing.Size(99, 43);
            this.dineroB4Tb.TabIndex = 1;
            this.dineroB4Tb.Text = "0.00";
            this.dineroB4Tb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SpringGreen;
            this.label16.Location = new System.Drawing.Point(3, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 43);
            this.label16.TabIndex = 2;
            this.label16.Text = "Q. ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.prepagoGb);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(60, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(641, 165);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Despachar";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.bombasCb);
            this.groupBox8.Location = new System.Drawing.Point(431, 30);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 100);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Seleccione una bomba";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Habilitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bombasCb
            // 
            this.bombasCb.FormattingEnabled = true;
            this.bombasCb.Items.AddRange(new object[] {
            "Bomba 1",
            "Bomba 2",
            "Bomba 3",
            "Bomba 4"});
            this.bombasCb.Location = new System.Drawing.Point(8, 24);
            this.bombasCb.Name = "bombasCb";
            this.bombasCb.Size = new System.Drawing.Size(186, 21);
            this.bombasCb.TabIndex = 4;
            this.bombasCb.SelectedIndexChanged += new System.EventHandler(this.bombasCb_SelectedIndexChanged);
            // 
            // prepagoGb
            // 
            this.prepagoGb.Controls.Add(this.cantidadTb);
            this.prepagoGb.Controls.Add(this.label1);
            this.prepagoGb.Controls.Add(this.quetzalesRb);
            this.prepagoGb.Controls.Add(this.litrosRb);
            this.prepagoGb.Location = new System.Drawing.Point(219, 30);
            this.prepagoGb.Name = "prepagoGb";
            this.prepagoGb.Size = new System.Drawing.Size(200, 100);
            this.prepagoGb.TabIndex = 8;
            this.prepagoGb.TabStop = false;
            this.prepagoGb.Text = "Prepago";
            // 
            // cantidadTb
            // 
            this.cantidadTb.Location = new System.Drawing.Point(26, 36);
            this.cantidadTb.Name = "cantidadTb";
            this.cantidadTb.Size = new System.Drawing.Size(165, 20);
            this.cantidadTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la cantidad (Q/V)";
            // 
            // quetzalesRb
            // 
            this.quetzalesRb.AutoSize = true;
            this.quetzalesRb.Location = new System.Drawing.Point(26, 62);
            this.quetzalesRb.Name = "quetzalesRb";
            this.quetzalesRb.Size = new System.Drawing.Size(72, 17);
            this.quetzalesRb.TabIndex = 2;
            this.quetzalesRb.TabStop = true;
            this.quetzalesRb.Text = "Quetzales";
            this.quetzalesRb.UseVisualStyleBackColor = true;
            // 
            // litrosRb
            // 
            this.litrosRb.AutoSize = true;
            this.litrosRb.Location = new System.Drawing.Point(104, 62);
            this.litrosRb.Name = "litrosRb";
            this.litrosRb.Size = new System.Drawing.Size(50, 17);
            this.litrosRb.TabIndex = 3;
            this.litrosRb.TabStop = true;
            this.litrosRb.Text = "Litros";
            this.litrosRb.UseVisualStyleBackColor = true;
            this.litrosRb.CheckedChanged += new System.EventHandler(this.galonesRb_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tanquellenoRb);
            this.groupBox6.Controls.Add(this.prepagoRb);
            this.groupBox6.Location = new System.Drawing.Point(19, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 100);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Llenado";
            // 
            // tanquellenoRb
            // 
            this.tanquellenoRb.AutoSize = true;
            this.tanquellenoRb.Location = new System.Drawing.Point(49, 60);
            this.tanquellenoRb.Name = "tanquellenoRb";
            this.tanquellenoRb.Size = new System.Drawing.Size(87, 17);
            this.tanquellenoRb.TabIndex = 1;
            this.tanquellenoRb.TabStop = true;
            this.tanquellenoRb.Text = "Tanque lleno";
            this.tanquellenoRb.UseVisualStyleBackColor = true;
            this.tanquellenoRb.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // prepagoRb
            // 
            this.prepagoRb.AutoSize = true;
            this.prepagoRb.Location = new System.Drawing.Point(49, 30);
            this.prepagoRb.Name = "prepagoRb";
            this.prepagoRb.Size = new System.Drawing.Size(65, 17);
            this.prepagoRb.TabIndex = 0;
            this.prepagoRb.TabStop = true;
            this.prepagoRb.Text = "Prepago";
            this.prepagoRb.UseVisualStyleBackColor = true;
            this.prepagoRb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 521);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.prepagoGb.ResumeLayout(false);
            this.prepagoGb.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox cantidadTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox bombasCb;
        private System.Windows.Forms.RadioButton litrosRb;
        private System.Windows.Forms.RadioButton quetzalesRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dineroBomba1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label litrosBomba1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label litrosB2Tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label dineroB2Tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label litrosB3Tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label dineroB3Tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label litrosB4Tb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label dineroB4Tb;
        private System.Windows.Forms.Label label16;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton tanquellenoRb;
        private System.Windows.Forms.RadioButton prepagoRb;
        private System.Windows.Forms.GroupBox prepagoGb;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button2;
    }
}

