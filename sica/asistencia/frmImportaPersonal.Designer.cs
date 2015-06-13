namespace asistencia
{
    partial class frmImportaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportaPersonal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.gbArchivo = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbNomabreArchivo = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.gbArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.dgvExcel);
            this.groupBox1.Location = new System.Drawing.Point(7, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 442);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORMATO DE COLUMNAS EXCEL-->Dni-->Nombres-->Ap paterno-->Ap materno-->Sexo-->Area" +
    " ID-->Modalidad ID=7 COLUMNAS TOTAL";
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Image = global::asistencia.Properties.Resources.siluetaPersona;
            this.pbFoto.Location = new System.Drawing.Point(103, 97);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(110, 130);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 24;
            this.pbFoto.TabStop = false;
            this.pbFoto.Visible = false;
            // 
            // dgvExcel
            // 
            this.dgvExcel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(9, 19);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.Size = new System.Drawing.Size(737, 417);
            this.dgvExcel.TabIndex = 17;
            // 
            // gbArchivo
            // 
            this.gbArchivo.Controls.Add(this.btnGuardar);
            this.gbArchivo.Controls.Add(this.tbNomabreArchivo);
            this.gbArchivo.Controls.Add(this.btnAbrir);
            this.gbArchivo.Location = new System.Drawing.Point(7, 11);
            this.gbArchivo.Name = "gbArchivo";
            this.gbArchivo.Size = new System.Drawing.Size(752, 60);
            this.gbArchivo.TabIndex = 67;
            this.gbArchivo.TabStop = false;
            this.gbArchivo.Text = "SELECCIONE EL ARCHIVO EXCEL PARA IMPORTAR LOS DATOS DEL PERSONAL";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(647, 10);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbNomabreArchivo
            // 
            this.tbNomabreArchivo.Enabled = false;
            this.tbNomabreArchivo.Location = new System.Drawing.Point(9, 22);
            this.tbNomabreArchivo.Name = "tbNomabreArchivo";
            this.tbNomabreArchivo.Size = new System.Drawing.Size(503, 20);
            this.tbNomabreArchivo.TabIndex = 16;
            this.tbNomabreArchivo.TextChanged += new System.EventHandler(this.tbNomabreArchivo_TextChanged);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(518, 22);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(85, 21);
            this.btnAbrir.TabIndex = 14;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click_1);
            // 
            // frmImportaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPORTACIÓN DE DATOS DEL PERSONAL";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.gbArchivo.ResumeLayout(false);
            this.gbArchivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.GroupBox gbArchivo;
        private System.Windows.Forms.TextBox tbNomabreArchivo;
        private System.Windows.Forms.Button btnAbrir;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}