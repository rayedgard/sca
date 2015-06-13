namespace asistencia
{
    partial class frmOmision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOmision));
            this.btnGrupales = new System.Windows.Forms.Button();
            this.calend_CalendarioDiasConPermisos = new ClaseCalendario.Calendario();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTomadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoOmision = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeroDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNIper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrupales
            // 
            this.btnGrupales.BackColor = System.Drawing.Color.Red;
            this.btnGrupales.ForeColor = System.Drawing.Color.White;
            this.btnGrupales.Location = new System.Drawing.Point(71, 500);
            this.btnGrupales.Name = "btnGrupales";
            this.btnGrupales.Size = new System.Drawing.Size(299, 23);
            this.btnGrupales.TabIndex = 11;
            this.btnGrupales.Text = "ASIGNAR OMISIONES GRUPALES";
            this.btnGrupales.UseVisualStyleBackColor = false;
            this.btnGrupales.Click += new System.EventHandler(this.btnGrupales_Click);
            // 
            // calend_CalendarioDiasConPermisos
            // 
            this.calend_CalendarioDiasConPermisos.AutoSize = true;
            this.calend_CalendarioDiasConPermisos.BackColor = System.Drawing.Color.DodgerBlue;
            this.calend_CalendarioDiasConPermisos.BackColorMonthYearValue = System.Drawing.Color.WhiteSmoke;
            this.calend_CalendarioDiasConPermisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calend_CalendarioDiasConPermisos.ColorTextoDia = System.Drawing.SystemColors.ControlDark;
            this.calend_CalendarioDiasConPermisos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calend_CalendarioDiasConPermisos.DiasMesConOpciones = new string[] {
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.calend_CalendarioDiasConPermisos.Enabled = false;
            this.calend_CalendarioDiasConPermisos.FechaActualHoy = new System.DateTime(((long)(0)));
            this.calend_CalendarioDiasConPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calend_CalendarioDiasConPermisos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calend_CalendarioDiasConPermisos.ListaOpcionesFeriados = ((System.Collections.ArrayList)(resources.GetObject("calend_CalendarioDiasConPermisos.ListaOpcionesFeriados")));
            this.calend_CalendarioDiasConPermisos.Location = new System.Drawing.Point(6, 114);
            this.calend_CalendarioDiasConPermisos.MaximumSize = new System.Drawing.Size(900, 831);
            this.calend_CalendarioDiasConPermisos.MesAnioFecha = new int[] {
        3,
        2011};
            this.calend_CalendarioDiasConPermisos.MinimumSize = new System.Drawing.Size(423, 383);
            this.calend_CalendarioDiasConPermisos.Name = "calend_CalendarioDiasConPermisos";
            this.calend_CalendarioDiasConPermisos.Size = new System.Drawing.Size(427, 384);
            this.calend_CalendarioDiasConPermisos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTomadas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoOmision);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumeroDocumento);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDNIper);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(378, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Omisiones tomadas";
            // 
            // lbTomadas
            // 
            this.lbTomadas.AutoSize = true;
            this.lbTomadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTomadas.ForeColor = System.Drawing.Color.Red;
            this.lbTomadas.Location = new System.Drawing.Point(479, 10);
            this.lbTomadas.Name = "lbTomadas";
            this.lbTomadas.Size = new System.Drawing.Size(30, 22);
            this.lbTomadas.TabIndex = 58;
            this.lbTomadas.Text = "29";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo de omisión";
            // 
            // cbTipoOmision
            // 
            this.cbTipoOmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoOmision.FormattingEnabled = true;
            this.cbTipoOmision.Location = new System.Drawing.Point(86, 61);
            this.cbTipoOmision.Name = "cbTipoOmision";
            this.cbTipoOmision.Size = new System.Drawing.Size(341, 21);
            this.cbTipoOmision.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(435, 64);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "N° documento";
            // 
            // tbNumeroDocumento
            // 
            this.tbNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.tbNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroDocumento.Location = new System.Drawing.Point(86, 88);
            this.tbNumeroDocumento.Name = "tbNumeroDocumento";
            this.tbNumeroDocumento.Size = new System.Drawing.Size(341, 20);
            this.tbNumeroDocumento.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(191, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Brown;
            this.lbNombre.Location = new System.Drawing.Point(89, 38);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 15);
            this.lbNombre.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Empleado";
            // 
            // tbDNIper
            // 
            this.tbDNIper.BackColor = System.Drawing.Color.White;
            this.tbDNIper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDNIper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNIper.Location = new System.Drawing.Point(86, 11);
            this.tbDNIper.MaxLength = 8;
            this.tbDNIper.Name = "tbDNIper";
            this.tbDNIper.Size = new System.Drawing.Size(100, 20);
            this.tbDNIper.TabIndex = 0;
            this.tbDNIper.TextChanged += new System.EventHandler(this.tbDNIper_TextChanged);
            this.tbDNIper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNIper_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(23, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "LEYENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(437, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 384);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(32, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 36);
            this.panel4.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Location = new System.Drawing.Point(32, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 36);
            this.panel3.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(32, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 36);
            this.panel2.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(21, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "de refrigerio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(23, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "a refrigerio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(32, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 36);
            this.panel1.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(7, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Omisión de salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(2, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Omisión de entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(7, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Omisión de salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(2, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Omisión de entrada";
            // 
            // frmOmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGrupales);
            this.Controls.Add(this.calend_CalendarioDiasConPermisos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(563, 563);
            this.Name = "frmOmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACIÓN DE OMISIONES DE PICADO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrupales;
        private ClaseCalendario.Calendario calend_CalendarioDiasConPermisos;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeroDocumento;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDNIper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoOmision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTomadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}