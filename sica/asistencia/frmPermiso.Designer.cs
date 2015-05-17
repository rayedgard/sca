namespace asistencia
{
    partial class frmPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermiso));
            this.calend_CalendarioDiasConPermisos = new ClaseCalendario.Calendario();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMInutoFin1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinutoIni1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudHoraFIn1 = new System.Windows.Forms.NumericUpDown();
            this.nudHoraInicio1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeroDocumento1 = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNIper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMInutoFin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutoIni1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraFIn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio1)).BeginInit();
            this.SuspendLayout();
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
            this.calend_CalendarioDiasConPermisos.Location = new System.Drawing.Point(6, 151);
            this.calend_CalendarioDiasConPermisos.MaximumSize = new System.Drawing.Size(900, 831);
            this.calend_CalendarioDiasConPermisos.MesAnioFecha = new int[] {
        3,
        2011};
            this.calend_CalendarioDiasConPermisos.MinimumSize = new System.Drawing.Size(423, 383);
            this.calend_CalendarioDiasConPermisos.Name = "calend_CalendarioDiasConPermisos";
            this.calend_CalendarioDiasConPermisos.Size = new System.Drawing.Size(427, 384);
            this.calend_CalendarioDiasConPermisos.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.nudMInutoFin1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudMinutoIni1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nudHoraFIn1);
            this.groupBox1.Controls.Add(this.nudHoraInicio1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumeroDocumento1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDNIper);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // nudMInutoFin1
            // 
            this.nudMInutoFin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMInutoFin1.ForeColor = System.Drawing.Color.Black;
            this.nudMInutoFin1.Location = new System.Drawing.Point(180, 83);
            this.nudMInutoFin1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMInutoFin1.Name = "nudMInutoFin1";
            this.nudMInutoFin1.Size = new System.Drawing.Size(47, 20);
            this.nudMInutoFin1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Hora inicio de permiso";
            // 
            // nudMinutoIni1
            // 
            this.nudMinutoIni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutoIni1.ForeColor = System.Drawing.Color.Black;
            this.nudMinutoIni1.Location = new System.Drawing.Point(180, 61);
            this.nudMinutoIni1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutoIni1.Name = "nudMinutoIni1";
            this.nudMinutoIni1.Size = new System.Drawing.Size(47, 20);
            this.nudMinutoIni1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Hora fin de permiso";
            // 
            // nudHoraFIn1
            // 
            this.nudHoraFIn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoraFIn1.ForeColor = System.Drawing.Color.Black;
            this.nudHoraFIn1.Location = new System.Drawing.Point(122, 83);
            this.nudHoraFIn1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoraFIn1.Name = "nudHoraFIn1";
            this.nudHoraFIn1.Size = new System.Drawing.Size(47, 20);
            this.nudHoraFIn1.TabIndex = 3;
            // 
            // nudHoraInicio1
            // 
            this.nudHoraInicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoraInicio1.ForeColor = System.Drawing.Color.Black;
            this.nudHoraInicio1.Location = new System.Drawing.Point(122, 61);
            this.nudHoraInicio1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoraInicio1.Name = "nudHoraInicio1";
            this.nudHoraInicio1.Size = new System.Drawing.Size(47, 20);
            this.nudHoraInicio1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "N° documento";
            // 
            // tbNumeroDocumento1
            // 
            this.tbNumeroDocumento1.BackColor = System.Drawing.Color.White;
            this.tbNumeroDocumento1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNumeroDocumento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroDocumento1.Location = new System.Drawing.Point(86, 108);
            this.tbNumeroDocumento1.Name = "tbNumeroDocumento1";
            this.tbNumeroDocumento1.Size = new System.Drawing.Size(226, 20);
            this.tbNumeroDocumento1.TabIndex = 5;
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
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(322, 88);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // frmPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 544);
            this.Controls.Add(this.calend_CalendarioDiasConPermisos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIÓN DE PERMISOS DEL PERSONAL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMInutoFin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutoIni1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraFIn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClaseCalendario.Calendario calend_CalendarioDiasConPermisos;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeroDocumento1;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDNIper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMInutoFin1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinutoIni1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudHoraFIn1;
        private System.Windows.Forms.NumericUpDown nudHoraInicio1;
    }
}