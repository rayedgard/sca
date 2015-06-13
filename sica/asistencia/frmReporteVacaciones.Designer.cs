namespace asistencia
{
    partial class frmReporteVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVacaciones));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnPDFModalidad = new System.Windows.Forms.Button();
            this.btnExcelModalidad = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbFiltrado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbEstadoPersonal = new System.Windows.Forms.GroupBox();
            this.rbtResumen = new System.Windows.Forms.RadioButton();
            this.rbtGeneral = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbEstadoPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDatos.Location = new System.Drawing.Point(0, 65);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(885, 267);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnPDFModalidad
            // 
            this.btnPDFModalidad.BackgroundImage = global::asistencia.Properties.Resources.PDF_Viewer;
            this.btnPDFModalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPDFModalidad.Location = new System.Drawing.Point(827, 5);
            this.btnPDFModalidad.Name = "btnPDFModalidad";
            this.btnPDFModalidad.Size = new System.Drawing.Size(55, 54);
            this.btnPDFModalidad.TabIndex = 30;
            this.btnPDFModalidad.UseVisualStyleBackColor = true;
            this.btnPDFModalidad.Click += new System.EventHandler(this.btnPDFModalidad_Click);
            // 
            // btnExcelModalidad
            // 
            this.btnExcelModalidad.BackgroundImage = global::asistencia.Properties.Resources.excel;
            this.btnExcelModalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcelModalidad.Location = new System.Drawing.Point(762, 5);
            this.btnExcelModalidad.Name = "btnExcelModalidad";
            this.btnExcelModalidad.Size = new System.Drawing.Size(59, 54);
            this.btnExcelModalidad.TabIndex = 31;
            this.btnExcelModalidad.UseVisualStyleBackColor = true;
            this.btnExcelModalidad.Click += new System.EventHandler(this.btnExcelModalidad_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(437, 13);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.Text = "Generar Reporte";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cbFiltrado
            // 
            this.cbFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrado.FormattingEnabled = true;
            this.cbFiltrado.Location = new System.Drawing.Point(126, 23);
            this.cbFiltrado.Name = "cbFiltrado";
            this.cbFiltrado.Size = new System.Drawing.Size(306, 21);
            this.cbFiltrado.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Seleccione Modalidad";
            // 
            // gbEstadoPersonal
            // 
            this.gbEstadoPersonal.Controls.Add(this.rbtResumen);
            this.gbEstadoPersonal.Controls.Add(this.rbtGeneral);
            this.gbEstadoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstadoPersonal.Location = new System.Drawing.Point(540, 7);
            this.gbEstadoPersonal.Name = "gbEstadoPersonal";
            this.gbEstadoPersonal.Size = new System.Drawing.Size(216, 50);
            this.gbEstadoPersonal.TabIndex = 67;
            this.gbEstadoPersonal.TabStop = false;
            // 
            // rbtResumen
            // 
            this.rbtResumen.AutoSize = true;
            this.rbtResumen.Location = new System.Drawing.Point(7, 28);
            this.rbtResumen.Name = "rbtResumen";
            this.rbtResumen.Size = new System.Drawing.Size(144, 17);
            this.rbtResumen.TabIndex = 1;
            this.rbtResumen.Text = "Reporte resumen general";
            this.rbtResumen.UseVisualStyleBackColor = true;
            // 
            // rbtGeneral
            // 
            this.rbtGeneral.AutoSize = true;
            this.rbtGeneral.Checked = true;
            this.rbtGeneral.Location = new System.Drawing.Point(7, 10);
            this.rbtGeneral.Name = "rbtGeneral";
            this.rbtGeneral.Size = new System.Drawing.Size(157, 17);
            this.rbtGeneral.TabIndex = 0;
            this.rbtGeneral.TabStop = true;
            this.rbtGeneral.Text = "Reporte general por fechas ";
            this.rbtGeneral.UseVisualStyleBackColor = true;
            // 
            // frmReporteVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 332);
            this.Controls.Add(this.gbEstadoPersonal);
            this.Controls.Add(this.cbFiltrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnPDFModalidad);
            this.Controls.Add(this.btnExcelModalidad);
            this.Controls.Add(this.dgvDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE VACIONES DEL PEROSNAL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbEstadoPersonal.ResumeLayout(false);
            this.gbEstadoPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnPDFModalidad;
        private System.Windows.Forms.Button btnExcelModalidad;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbFiltrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbEstadoPersonal;
        private System.Windows.Forms.RadioButton rbtResumen;
        private System.Windows.Forms.RadioButton rbtGeneral;
    }
}