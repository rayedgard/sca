namespace asistencia
{
    partial class frmOmisionesGrupales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOmisionesGrupales));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoOmision = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCargos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFiltrado = new System.Windows.Forms.ComboBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(334, 163);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.cbTipoOmision);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.tbDetalle);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.dtpFecha);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.cbCargos);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.cbFiltrado);
            this.gbDatos.ForeColor = System.Drawing.Color.Maroon;
            this.gbDatos.Location = new System.Drawing.Point(5, 6);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(431, 152);
            this.gbDatos.TabIndex = 92;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS DE LICENCIAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Seleccione tipo Omisión";
            // 
            // cbTipoOmision
            // 
            this.cbTipoOmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoOmision.FormattingEnabled = true;
            this.cbTipoOmision.Location = new System.Drawing.Point(147, 69);
            this.cbTipoOmision.Name = "cbTipoOmision";
            this.cbTipoOmision.Size = new System.Drawing.Size(280, 21);
            this.cbTipoOmision.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(5, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 108;
            this.label9.Text = "Documento";
            // 
            // tbDetalle
            // 
            this.tbDetalle.BackColor = System.Drawing.Color.White;
            this.tbDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalle.Location = new System.Drawing.Point(147, 121);
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Size = new System.Drawing.Size(280, 20);
            this.tbDetalle.TabIndex = 4;
            this.tbDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDetalle_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Seleccione fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(147, 95);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(280, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2014, 6, 26, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "Seleccione grupo";
            // 
            // cbCargos
            // 
            this.cbCargos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCargos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCargos.BackColor = System.Drawing.Color.White;
            this.cbCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.Location = new System.Drawing.Point(147, 44);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(280, 21);
            this.cbCargos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Filtrar por";
            // 
            // cbFiltrado
            // 
            this.cbFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrado.FormattingEnabled = true;
            this.cbFiltrado.Location = new System.Drawing.Point(147, 19);
            this.cbFiltrado.Name = "cbFiltrado";
            this.cbFiltrado.Size = new System.Drawing.Size(280, 21);
            this.cbFiltrado.TabIndex = 0;
            this.cbFiltrado.SelectedIndexChanged += new System.EventHandler(this.cbFiltrado_SelectedIndexChanged);
            // 
            // frmOmisionesGrupales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 215);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 253);
            this.MinimizeBox = false;
            this.Name = "frmOmisionesGrupales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE OMISIONES GRUPALES";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCargos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFiltrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoOmision;
    }
}