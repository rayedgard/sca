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
            this.lbTomadas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(427, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo de Omisión";
            // 
            // cbTipoOmision
            // 
            this.cbTipoOmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoOmision.FormattingEnabled = true;
            this.cbTipoOmision.Location = new System.Drawing.Point(86, 61);
            this.cbTipoOmision.Name = "cbTipoOmision";
            this.cbTipoOmision.Size = new System.Drawing.Size(226, 21);
            this.cbTipoOmision.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(322, 68);
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
            this.tbNumeroDocumento.Size = new System.Drawing.Size(226, 20);
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
            // lbTomadas
            // 
            this.lbTomadas.AutoSize = true;
            this.lbTomadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTomadas.ForeColor = System.Drawing.Color.Red;
            this.lbTomadas.Location = new System.Drawing.Point(392, 9);
            this.lbTomadas.Name = "lbTomadas";
            this.lbTomadas.Size = new System.Drawing.Size(30, 22);
            this.lbTomadas.TabIndex = 58;
            this.lbTomadas.Text = "29";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(284, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Omisiones Tomadas";
            // 
            // frmOmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 525);
            this.Controls.Add(this.btnGrupales);
            this.Controls.Add(this.calend_CalendarioDiasConPermisos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACIÓN DE OMISIONES DE PICADO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}