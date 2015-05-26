namespace asistencia
{
    partial class frmImportExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportExcel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.gbArchivo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHojas = new System.Windows.Forms.Button();
            this.cbHojas = new System.Windows.Forms.ComboBox();
            this.tbNomabreArchivo = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.Abrir = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.gbArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExcel);
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 442);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXCEL";
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
            this.gbArchivo.Controls.Add(this.label1);
            this.gbArchivo.Controls.Add(this.btnHojas);
            this.gbArchivo.Controls.Add(this.cbHojas);
            this.gbArchivo.Controls.Add(this.tbNomabreArchivo);
            this.gbArchivo.Controls.Add(this.btnAbrir);
            this.gbArchivo.Location = new System.Drawing.Point(4, 8);
            this.gbArchivo.Name = "gbArchivo";
            this.gbArchivo.Size = new System.Drawing.Size(752, 53);
            this.gbArchivo.TabIndex = 65;
            this.gbArchivo.TabStop = false;
            this.gbArchivo.Text = "SELECCIONE EL ARCHIVO EXCEL PARA IMPORTAR LOS REGISTROS DE ASISTENCIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de hojas";
            // 
            // btnHojas
            // 
            this.btnHojas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHojas.ForeColor = System.Drawing.Color.Transparent;
            this.btnHojas.Location = new System.Drawing.Point(713, 21);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(28, 25);
            this.btnHojas.TabIndex = 18;
            this.btnHojas.UseVisualStyleBackColor = false;
            // 
            // cbHojas
            // 
            this.cbHojas.FormattingEnabled = true;
            this.cbHojas.Location = new System.Drawing.Point(577, 22);
            this.cbHojas.Name = "cbHojas";
            this.cbHojas.Size = new System.Drawing.Size(130, 21);
            this.cbHojas.TabIndex = 17;
            // 
            // tbNomabreArchivo
            // 
            this.tbNomabreArchivo.Enabled = false;
            this.tbNomabreArchivo.Location = new System.Drawing.Point(9, 22);
            this.tbNomabreArchivo.Name = "tbNomabreArchivo";
            this.tbNomabreArchivo.Size = new System.Drawing.Size(378, 20);
            this.tbNomabreArchivo.TabIndex = 16;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(393, 21);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(85, 21);
            this.btnAbrir.TabIndex = 14;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // Abrir
            // 
            this.Abrir.FileName = "openFileDialog1";
            // 
            // frmImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPORTA ASISTENCIA DESDE UN ARCHIVO EXCEL";
            this.Load += new System.EventHandler(this.frmImportExcel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.gbArchivo.ResumeLayout(false);
            this.gbArchivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.GroupBox gbArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.ComboBox cbHojas;
        private System.Windows.Forms.TextBox tbNomabreArchivo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog Abrir;
    }
}