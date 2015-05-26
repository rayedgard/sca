namespace asistencia
{
    partial class frmReporteLicencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteLicencias));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbPermisos = new System.Windows.Forms.RadioButton();
            this.rbLicencias = new System.Windows.Forms.RadioButton();
            this.btnPDFModalidad = new System.Windows.Forms.Button();
            this.btnExcelModalidad = new System.Windows.Forms.Button();
            this.dgvReportePersonal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDNIPersonal = new System.Windows.Forms.TextBox();
            this.lbNombrePersonal = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.btnVerReportePersonal = new System.Windows.Forms.Button();
            this.dtpFechaFInPersonal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioPersonal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.prbCarga = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 448);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.prbCarga);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.rbPermisos);
            this.tabPage1.Controls.Add(this.rbLicencias);
            this.tabPage1.Controls.Add(this.btnPDFModalidad);
            this.tabPage1.Controls.Add(this.btnExcelModalidad);
            this.tabPage1.Controls.Add(this.dgvReportePersonal);
            this.tabPage1.Controls.Add(this.tbDNIPersonal);
            this.tabPage1.Controls.Add(this.lbNombrePersonal);
            this.tabPage1.Controls.Add(this.lbNombreUsuario);
            this.tabPage1.Controls.Add(this.btnVerReportePersonal);
            this.tabPage1.Controls.Add(this.dtpFechaFInPersonal);
            this.tabPage1.Controls.Add(this.dtpFechaInicioPersonal);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 422);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "GENERACIÓN DE REPORTES POR LICENCIA DE PERSONAL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbPermisos
            // 
            this.rbPermisos.AutoSize = true;
            this.rbPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbPermisos.Location = new System.Drawing.Point(128, 6);
            this.rbPermisos.Name = "rbPermisos";
            this.rbPermisos.Size = new System.Drawing.Size(97, 21);
            this.rbPermisos.TabIndex = 62;
            this.rbPermisos.Text = "PERMISOS";
            this.rbPermisos.UseVisualStyleBackColor = true;
            // 
            // rbLicencias
            // 
            this.rbLicencias.AutoSize = true;
            this.rbLicencias.Checked = true;
            this.rbLicencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLicencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbLicencias.Location = new System.Drawing.Point(27, 6);
            this.rbLicencias.Name = "rbLicencias";
            this.rbLicencias.Size = new System.Drawing.Size(95, 21);
            this.rbLicencias.TabIndex = 61;
            this.rbLicencias.TabStop = true;
            this.rbLicencias.Text = "LICENCIAS";
            this.rbLicencias.UseVisualStyleBackColor = true;
            // 
            // btnPDFModalidad
            // 
            this.btnPDFModalidad.BackgroundImage = global::asistencia.Properties.Resources.PDF_Viewer;
            this.btnPDFModalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPDFModalidad.Location = new System.Drawing.Point(719, 36);
            this.btnPDFModalidad.Name = "btnPDFModalidad";
            this.btnPDFModalidad.Size = new System.Drawing.Size(62, 57);
            this.btnPDFModalidad.TabIndex = 28;
            this.btnPDFModalidad.UseVisualStyleBackColor = true;
            this.btnPDFModalidad.Click += new System.EventHandler(this.btnPDFModalidad_Click);
            // 
            // btnExcelModalidad
            // 
            this.btnExcelModalidad.BackgroundImage = global::asistencia.Properties.Resources.excel;
            this.btnExcelModalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcelModalidad.Location = new System.Drawing.Point(787, 36);
            this.btnExcelModalidad.Name = "btnExcelModalidad";
            this.btnExcelModalidad.Size = new System.Drawing.Size(62, 57);
            this.btnExcelModalidad.TabIndex = 29;
            this.btnExcelModalidad.UseVisualStyleBackColor = true;
            this.btnExcelModalidad.Click += new System.EventHandler(this.btnExcelModalidad_Click);
            // 
            // dgvReportePersonal
            // 
            this.dgvReportePersonal.AllowUserToAddRows = false;
            this.dgvReportePersonal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportePersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvReportePersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Column6,
            this.dataGridViewTextBoxColumn8,
            this.Inicio,
            this.fin,
            this.total});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportePersonal.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvReportePersonal.Location = new System.Drawing.Point(2, 99);
            this.dgvReportePersonal.Name = "dgvReportePersonal";
            this.dgvReportePersonal.ReadOnly = true;
            this.dgvReportePersonal.RowHeadersVisible = false;
            this.dgvReportePersonal.Size = new System.Drawing.Size(846, 309);
            this.dgvReportePersonal.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 260;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Licencia / Permiso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // Column6
            // 
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Blue;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle26;
            this.Column6.HeaderText = "Goce de Haber";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn8.HeaderText = "Cod/Documento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "Hora Salida";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            this.Inicio.Width = 80;
            // 
            // fin
            // 
            this.fin.HeaderText = "Hora Retorno";
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            this.fin.Width = 80;
            // 
            // total
            // 
            this.total.HeaderText = "Total Horas";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 80;
            // 
            // tbDNIPersonal
            // 
            this.tbDNIPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNIPersonal.Location = new System.Drawing.Point(56, 33);
            this.tbDNIPersonal.MaxLength = 8;
            this.tbDNIPersonal.Name = "tbDNIPersonal";
            this.tbDNIPersonal.Size = new System.Drawing.Size(153, 20);
            this.tbDNIPersonal.TabIndex = 42;
            this.tbDNIPersonal.TextChanged += new System.EventHandler(this.tbDNIPersonal_TextChanged);
            this.tbDNIPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNIPersonal_KeyPress);
            // 
            // lbNombrePersonal
            // 
            this.lbNombrePersonal.AutoSize = true;
            this.lbNombrePersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePersonal.ForeColor = System.Drawing.Color.Firebrick;
            this.lbNombrePersonal.Location = new System.Drawing.Point(228, 36);
            this.lbNombrePersonal.Name = "lbNombrePersonal";
            this.lbNombrePersonal.Size = new System.Drawing.Size(0, 13);
            this.lbNombrePersonal.TabIndex = 30;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.Color.Red;
            this.lbNombreUsuario.Location = new System.Drawing.Point(271, 36);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(0, 13);
            this.lbNombreUsuario.TabIndex = 30;
            // 
            // btnVerReportePersonal
            // 
            this.btnVerReportePersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReportePersonal.Location = new System.Drawing.Point(27, 60);
            this.btnVerReportePersonal.Name = "btnVerReportePersonal";
            this.btnVerReportePersonal.Size = new System.Drawing.Size(328, 27);
            this.btnVerReportePersonal.TabIndex = 39;
            this.btnVerReportePersonal.Text = "GENERAR REPORTE GENERAL POR LICENCIA O PERMISO";
            this.btnVerReportePersonal.UseVisualStyleBackColor = true;
            this.btnVerReportePersonal.Click += new System.EventHandler(this.btnVerReportePersonal_Click);
            // 
            // dtpFechaFInPersonal
            // 
            this.dtpFechaFInPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFInPersonal.Location = new System.Drawing.Point(629, 7);
            this.dtpFechaFInPersonal.Name = "dtpFechaFInPersonal";
            this.dtpFechaFInPersonal.Size = new System.Drawing.Size(215, 20);
            this.dtpFechaFInPersonal.TabIndex = 33;
            // 
            // dtpFechaInicioPersonal
            // 
            this.dtpFechaInicioPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioPersonal.Location = new System.Drawing.Point(349, 7);
            this.dtpFechaInicioPersonal.Name = "dtpFechaInicioPersonal";
            this.dtpFechaInicioPersonal.Size = new System.Drawing.Size(222, 20);
            this.dtpFechaInicioPersonal.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(588, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(24, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(268, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Fecha Desde";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(214, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // prbCarga
            // 
            this.prbCarga.Location = new System.Drawing.Point(363, 64);
            this.prbCarga.Name = "prbCarga";
            this.prbCarga.Size = new System.Drawing.Size(345, 23);
            this.prbCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbCarga.TabIndex = 68;
            this.prbCarga.Visible = false;
            // 
            // frmReporteLicencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 455);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteLicencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE LIECNCIAS Y/O PERMISOS DEL PERSONAL";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbPermisos;
        private System.Windows.Forms.RadioButton rbLicencias;
        private System.Windows.Forms.Button btnPDFModalidad;
        private System.Windows.Forms.Button btnExcelModalidad;
        private System.Windows.Forms.DataGridView dgvReportePersonal;
        private System.Windows.Forms.TextBox tbDNIPersonal;
        private System.Windows.Forms.Label lbNombrePersonal;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Button btnVerReportePersonal;
        private System.Windows.Forms.DateTimePicker dtpFechaFInPersonal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ProgressBar prbCarga;
    }
}