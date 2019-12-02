namespace Banco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxFrecuencia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxMedia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxSimular = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndADondeVa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDondeVa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndAtencionCajero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoAtencionCajero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finAtencionCajero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndAtencionCajero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoAtencionCajero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finAtencionCajero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCajero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaCajero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorClientesCajero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumuladorTiempoOciosoCajero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCajero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaCajero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorClientesCajero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumuladorTiempoOciosoCajero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumuladorTiempoClienteEnSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorClientesConFinAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEstadisticaACajero1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblEstadisticaACajero2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEstadisticaB = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.asda = new System.Windows.Forms.Label();
            this.lblEstadisticaCCajero1 = new System.Windows.Forms.Label();
            this.lblEstadisticaCCajero2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtBoxDesde = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(300, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llegada de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(953, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atención de Cajeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1107, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cajero 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(875, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cajero 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(600, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Banco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "(Exponencial negativa)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(852, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "(Exponencial negativa)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1120, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "(Uniforme)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Frecuencia: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Clientes/h";
            // 
            // txtBoxFrecuencia
            // 
            this.txtBoxFrecuencia.Location = new System.Drawing.Point(321, 128);
            this.txtBoxFrecuencia.Name = "txtBoxFrecuencia";
            this.txtBoxFrecuencia.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFrecuencia.TabIndex = 10;
            this.txtBoxFrecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFrecuencia_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1120, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "A:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1120, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "B:";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(1140, 122);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(71, 20);
            this.txtBoxA.TabIndex = 13;
            this.txtBoxA.TextChanged += new System.EventHandler(this.txtBoxA_TextChanged);
            this.txtBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxA_KeyPress);
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(1140, 147);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(71, 20);
            this.txtBoxB.TabIndex = 14;
            this.txtBoxB.TextChanged += new System.EventHandler(this.txtBoxB_TextChanged);
            this.txtBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxB_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(852, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Media: ";
            // 
            // txtBoxMedia
            // 
            this.txtBoxMedia.Location = new System.Drawing.Point(900, 125);
            this.txtBoxMedia.Name = "txtBoxMedia";
            this.txtBoxMedia.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMedia.TabIndex = 16;
            this.txtBoxMedia.TextChanged += new System.EventHandler(this.txtBoxMedia_TextChanged);
            this.txtBoxMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMedia_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(538, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Hasta el minuto: ";
            // 
            // txtBoxSimular
            // 
            this.txtBoxSimular.Location = new System.Drawing.Point(630, 205);
            this.txtBoxSimular.Name = "txtBoxSimular";
            this.txtBoxSimular.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSimular.TabIndex = 18;
            this.txtBoxSimular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSimular_KeyPress);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(736, 188);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 19;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.evento,
            this.rndLlegadas,
            this.tiempoLlegadas,
            this.proximaLlegada,
            this.rndADondeVa,
            this.aDondeVa,
            this.rndAtencionCajero1,
            this.tiempoAtencionCajero1,
            this.finAtencionCajero1,
            this.rndAtencionCajero2,
            this.tiempoAtencionCajero2,
            this.finAtencionCajero2,
            this.estadoCajero1,
            this.colaCajero1,
            this.contadorClientesCajero1,
            this.acumuladorTiempoOciosoCajero1,
            this.estadoCajero2,
            this.colaCajero2,
            this.contadorClientesCajero2,
            this.acumuladorTiempoOciosoCajero2,
            this.acumuladorTiempoClienteEnSistema,
            this.contadorClientesConFinAtencion});
            this.dgv.Location = new System.Drawing.Point(12, 404);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1343, 284);
            this.dgv.TabIndex = 20;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Width = 56;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Width = 66;
            // 
            // rndLlegadas
            // 
            this.rndLlegadas.HeaderText = "RND";
            this.rndLlegadas.Name = "rndLlegadas";
            this.rndLlegadas.ReadOnly = true;
            this.rndLlegadas.Width = 56;
            // 
            // tiempoLlegadas
            // 
            this.tiempoLlegadas.HeaderText = "Tiempo entre llegadas";
            this.tiempoLlegadas.Name = "tiempoLlegadas";
            this.tiempoLlegadas.ReadOnly = true;
            this.tiempoLlegadas.Width = 124;
            // 
            // proximaLlegada
            // 
            this.proximaLlegada.HeaderText = "Próxima llegada";
            this.proximaLlegada.Name = "proximaLlegada";
            this.proximaLlegada.ReadOnly = true;
            this.proximaLlegada.Width = 97;
            // 
            // rndADondeVa
            // 
            this.rndADondeVa.HeaderText = "RND Montecarlo";
            this.rndADondeVa.Name = "rndADondeVa";
            this.rndADondeVa.ReadOnly = true;
            this.rndADondeVa.Width = 103;
            // 
            // aDondeVa
            // 
            this.aDondeVa.HeaderText = "A donde va?";
            this.aDondeVa.Name = "aDondeVa";
            this.aDondeVa.ReadOnly = true;
            this.aDondeVa.Width = 86;
            // 
            // rndAtencionCajero1
            // 
            this.rndAtencionCajero1.HeaderText = "RND";
            this.rndAtencionCajero1.Name = "rndAtencionCajero1";
            this.rndAtencionCajero1.ReadOnly = true;
            this.rndAtencionCajero1.Width = 56;
            // 
            // tiempoAtencionCajero1
            // 
            this.tiempoAtencionCajero1.HeaderText = "Tiempo de atención Cajero 1";
            this.tiempoAtencionCajero1.Name = "tiempoAtencionCajero1";
            this.tiempoAtencionCajero1.ReadOnly = true;
            this.tiempoAtencionCajero1.Width = 118;
            // 
            // finAtencionCajero1
            // 
            this.finAtencionCajero1.HeaderText = "Fin de atención Cajero 1";
            this.finAtencionCajero1.Name = "finAtencionCajero1";
            this.finAtencionCajero1.ReadOnly = true;
            this.finAtencionCajero1.Width = 134;
            // 
            // rndAtencionCajero2
            // 
            this.rndAtencionCajero2.HeaderText = "RND";
            this.rndAtencionCajero2.Name = "rndAtencionCajero2";
            this.rndAtencionCajero2.ReadOnly = true;
            this.rndAtencionCajero2.Width = 56;
            // 
            // tiempoAtencionCajero2
            // 
            this.tiempoAtencionCajero2.HeaderText = "Tiempo de atención Cajero 2";
            this.tiempoAtencionCajero2.Name = "tiempoAtencionCajero2";
            this.tiempoAtencionCajero2.ReadOnly = true;
            this.tiempoAtencionCajero2.Width = 118;
            // 
            // finAtencionCajero2
            // 
            this.finAtencionCajero2.HeaderText = "Fin de atención Cajero 2";
            this.finAtencionCajero2.Name = "finAtencionCajero2";
            this.finAtencionCajero2.ReadOnly = true;
            this.finAtencionCajero2.Width = 134;
            // 
            // estadoCajero1
            // 
            this.estadoCajero1.HeaderText = "Estado Cajero 1";
            this.estadoCajero1.Name = "estadoCajero1";
            this.estadoCajero1.ReadOnly = true;
            this.estadoCajero1.Width = 90;
            // 
            // colaCajero1
            // 
            this.colaCajero1.HeaderText = "Cola Cajero 1";
            this.colaCajero1.Name = "colaCajero1";
            this.colaCajero1.ReadOnly = true;
            this.colaCajero1.Width = 79;
            // 
            // contadorClientesCajero1
            // 
            this.contadorClientesCajero1.HeaderText = "Contador de clientes Cajero 1";
            this.contadorClientesCajero1.Name = "contadorClientesCajero1";
            this.contadorClientesCajero1.ReadOnly = true;
            this.contadorClientesCajero1.Width = 121;
            // 
            // acumuladorTiempoOciosoCajero1
            // 
            this.acumuladorTiempoOciosoCajero1.HeaderText = "Acumulador de tiempo ocioso Cajero 1";
            this.acumuladorTiempoOciosoCajero1.Name = "acumuladorTiempoOciosoCajero1";
            this.acumuladorTiempoOciosoCajero1.ReadOnly = true;
            this.acumuladorTiempoOciosoCajero1.Width = 159;
            // 
            // estadoCajero2
            // 
            this.estadoCajero2.HeaderText = "Estado Cajero 2";
            this.estadoCajero2.Name = "estadoCajero2";
            this.estadoCajero2.ReadOnly = true;
            this.estadoCajero2.Width = 90;
            // 
            // colaCajero2
            // 
            this.colaCajero2.HeaderText = "Cola Cajero 2";
            this.colaCajero2.Name = "colaCajero2";
            this.colaCajero2.ReadOnly = true;
            this.colaCajero2.Width = 79;
            // 
            // contadorClientesCajero2
            // 
            this.contadorClientesCajero2.HeaderText = "Contador de clientes Cajero 2";
            this.contadorClientesCajero2.Name = "contadorClientesCajero2";
            this.contadorClientesCajero2.ReadOnly = true;
            this.contadorClientesCajero2.Width = 121;
            // 
            // acumuladorTiempoOciosoCajero2
            // 
            this.acumuladorTiempoOciosoCajero2.HeaderText = "Acumulador de tiempo ocioso Cajero 2";
            this.acumuladorTiempoOciosoCajero2.Name = "acumuladorTiempoOciosoCajero2";
            this.acumuladorTiempoOciosoCajero2.ReadOnly = true;
            this.acumuladorTiempoOciosoCajero2.Width = 159;
            // 
            // acumuladorTiempoClienteEnSistema
            // 
            this.acumuladorTiempoClienteEnSistema.HeaderText = "Acumulador de tiempo de clientes en banco";
            this.acumuladorTiempoClienteEnSistema.Name = "acumuladorTiempoClienteEnSistema";
            this.acumuladorTiempoClienteEnSistema.ReadOnly = true;
            this.acumuladorTiempoClienteEnSistema.Width = 141;
            // 
            // contadorClientesConFinAtencion
            // 
            this.contadorClientesConFinAtencion.HeaderText = "Contador de clientes con atención finalizada";
            this.contadorClientesConFinAtencion.Name = "contadorClientesConFinAtencion";
            this.contadorClientesConFinAtencion.ReadOnly = true;
            this.contadorClientesConFinAtencion.Width = 179;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label15.Location = new System.Drawing.Point(60, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Estadísticas:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(65, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(283, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "Clientes atendidos por hora por el Cajero 1:";
            // 
            // lblEstadisticaACajero1
            // 
            this.lblEstadisticaACajero1.AutoSize = true;
            this.lblEstadisticaACajero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstadisticaACajero1.Location = new System.Drawing.Point(354, 277);
            this.lblEstadisticaACajero1.Name = "lblEstadisticaACajero1";
            this.lblEstadisticaACajero1.Size = new System.Drawing.Size(0, 17);
            this.lblEstadisticaACajero1.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(65, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(283, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Clientes atendidos por hora por el Cajero 2:";
            // 
            // lblEstadisticaACajero2
            // 
            this.lblEstadisticaACajero2.AutoSize = true;
            this.lblEstadisticaACajero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstadisticaACajero2.Location = new System.Drawing.Point(354, 294);
            this.lblEstadisticaACajero2.Name = "lblEstadisticaACajero2";
            this.lblEstadisticaACajero2.Size = new System.Drawing.Size(0, 17);
            this.lblEstadisticaACajero2.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(65, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(285, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Tiempo promedio de un cliente en el banco:";
            // 
            // lblEstadisticaB
            // 
            this.lblEstadisticaB.AutoSize = true;
            this.lblEstadisticaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstadisticaB.Location = new System.Drawing.Point(354, 323);
            this.lblEstadisticaB.Name = "lblEstadisticaB";
            this.lblEstadisticaB.Size = new System.Drawing.Size(0, 17);
            this.lblEstadisticaB.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(65, 354);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(184, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "Tiempo ocioso del Cajero 1:";
            // 
            // asda
            // 
            this.asda.AutoSize = true;
            this.asda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.asda.Location = new System.Drawing.Point(65, 371);
            this.asda.Name = "asda";
            this.asda.Size = new System.Drawing.Size(184, 17);
            this.asda.TabIndex = 29;
            this.asda.Text = "Tiempo ocioso del Cajero 2:";
            // 
            // lblEstadisticaCCajero1
            // 
            this.lblEstadisticaCCajero1.AutoSize = true;
            this.lblEstadisticaCCajero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstadisticaCCajero1.Location = new System.Drawing.Point(244, 354);
            this.lblEstadisticaCCajero1.Name = "lblEstadisticaCCajero1";
            this.lblEstadisticaCCajero1.Size = new System.Drawing.Size(0, 17);
            this.lblEstadisticaCCajero1.TabIndex = 30;
            // 
            // lblEstadisticaCCajero2
            // 
            this.lblEstadisticaCCajero2.AutoSize = true;
            this.lblEstadisticaCCajero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstadisticaCCajero2.Location = new System.Drawing.Point(244, 371);
            this.lblEstadisticaCCajero2.Name = "lblEstadisticaCCajero2";
            this.lblEstadisticaCCajero2.Size = new System.Drawing.Size(0, 17);
            this.lblEstadisticaCCajero2.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label20.Location = new System.Drawing.Point(594, 237);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 25);
            this.label20.TabIndex = 32;
            this.label20.Text = "Abreviaturas:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(596, 275);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(249, 17);
            this.label21.TabIndex = 33;
            this.label21.Text = "EA1: Esperando atención del Cajero 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.Location = new System.Drawing.Point(596, 294);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(249, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "EA2: Esperando atención del Cajero 2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.Location = new System.Drawing.Point(596, 311);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(242, 17);
            this.label23.TabIndex = 35;
            this.label23.Text = "SA1: Siendo atendido por el Cajero 1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.Location = new System.Drawing.Point(596, 328);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(242, 17);
            this.label24.TabIndex = 36;
            this.label24.Text = "SA2: Siendo atendido por el Cajero 2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.Location = new System.Drawing.Point(596, 345);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(152, 17);
            this.label25.TabIndex = 37;
            this.label25.Text = "AF: Atención finalizada";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label26.Location = new System.Drawing.Point(898, 237);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 25);
            this.label26.TabIndex = 38;
            this.label26.Text = "Notas:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label27.Location = new System.Drawing.Point(897, 275);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(423, 17);
            this.label27.TabIndex = 39;
            this.label27.Text = "-RND Montecarlo: Se genera cuando están los dos cajeros Libres";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label28.Location = new System.Drawing.Point(900, 292);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(367, 17);
            this.label28.TabIndex = 40;
            this.label28.Text = "u ocupados con la misma cantidad de clientes en la cola.";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label29.Location = new System.Drawing.Point(900, 309);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(339, 17);
            this.label29.TabIndex = 41;
            this.label29.Text = "Si es menor a 0.5 se va al Cajero 1, sino al Cajero 2.";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(447, 177);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(177, 13);
            this.label30.TabIndex = 42;
            this.label30.Text = "Mostrar simulación desde el minuto: ";
            // 
            // txtBoxDesde
            // 
            this.txtBoxDesde.Location = new System.Drawing.Point(630, 174);
            this.txtBoxDesde.Name = "txtBoxDesde";
            this.txtBoxDesde.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDesde.TabIndex = 43;
            this.txtBoxDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDesde_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 700);
            this.Controls.Add(this.txtBoxDesde);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblEstadisticaCCajero2);
            this.Controls.Add(this.lblEstadisticaCCajero1);
            this.Controls.Add(this.asda);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblEstadisticaB);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblEstadisticaACajero2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblEstadisticaACajero1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtBoxSimular);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxMedia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxFrecuencia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxFrecuencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxMedia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxSimular;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEstadisticaACajero1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblEstadisticaACajero2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEstadisticaB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label asda;
        private System.Windows.Forms.Label lblEstadisticaCCajero1;
        private System.Windows.Forms.Label lblEstadisticaCCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndADondeVa;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDondeVa;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndAtencionCajero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoAtencionCajero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finAtencionCajero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndAtencionCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoAtencionCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn finAtencionCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCajero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaCajero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorClientesCajero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumuladorTiempoOciosoCajero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorClientesCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumuladorTiempoOciosoCajero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumuladorTiempoClienteEnSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorClientesConFinAtencion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtBoxDesde;
    }
}

