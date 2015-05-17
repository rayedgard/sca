namespace asistencia
{
    partial class frmTipoLIcencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoLIcencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label29 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNombreNuevoTipoPermiso = new System.Windows.Forms.TextBox();
            this.tbDetallesPermisos = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.chbGoce = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudLimite = new System.Windows.Forms.NumericUpDown();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvTiposDePermiso = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimite)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDePermiso)).BeginInit();
            this.SuspendLayout();
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(3, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "DETALLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "CON GOCE DE HABER";
            // 
            // tbNombreNuevoTipoPermiso
            // 
            this.tbNombreNuevoTipoPermiso.BackColor = System.Drawing.Color.White;
            this.tbNombreNuevoTipoPermiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreNuevoTipoPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreNuevoTipoPermiso.Location = new System.Drawing.Point(148, 18);
            this.tbNombreNuevoTipoPermiso.Name = "tbNombreNuevoTipoPermiso";
            this.tbNombreNuevoTipoPermiso.Size = new System.Drawing.Size(291, 20);
            this.tbNombreNuevoTipoPermiso.TabIndex = 0;
            this.tbNombreNuevoTipoPermiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // tbDetallesPermisos
            // 
            this.tbDetallesPermisos.BackColor = System.Drawing.Color.White;
            this.tbDetallesPermisos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDetallesPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetallesPermisos.Location = new System.Drawing.Point(148, 64);
            this.tbDetallesPermisos.Name = "tbDetallesPermisos";
            this.tbDetallesPermisos.Size = new System.Drawing.Size(291, 20);
            this.tbDetallesPermisos.TabIndex = 2;
            this.tbDetallesPermisos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(3, 21);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "NOMBRE TIPO LICENCIA";
            // 
            // chbGoce
            // 
            this.chbGoce.AutoSize = true;
            this.chbGoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGoce.Location = new System.Drawing.Point(150, 44);
            this.chbGoce.Name = "chbGoce";
            this.chbGoce.Size = new System.Drawing.Size(15, 14);
            this.chbGoce.TabIndex = 1;
            this.chbGoce.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "LIMITE EN DIAS";
            // 
            // nudLimite
            // 
            this.nudLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLimite.ForeColor = System.Drawing.Color.Black;
            this.nudLimite.Location = new System.Drawing.Point(148, 90);
            this.nudLimite.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudLimite.Name = "nudLimite";
            this.nudLimite.Size = new System.Drawing.Size(47, 20);
            this.nudLimite.TabIndex = 3;
            // 
            // gbDatos
            // 
            this.gbDatos.AutoSize = true;
            this.gbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDatos.Controls.Add(this.nudLimite);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.chbGoce);
            this.gbDatos.Controls.Add(this.label33);
            this.gbDatos.Controls.Add(this.tbDetallesPermisos);
            this.gbDatos.Controls.Add(this.tbNombreNuevoTipoPermiso);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label29);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(8, 12);
            this.gbDatos.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(449, 129);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "CONFIGURACIÓN DE LICENCIA";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(353, 146);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(246, 146);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvTiposDePermiso
            // 
            this.dgvTiposDePermiso.AllowUserToAddRows = false;
            this.dgvTiposDePermiso.AllowUserToDeleteRows = false;
            this.dgvTiposDePermiso.AllowUserToResizeColumns = false;
            this.dgvTiposDePermiso.AllowUserToResizeRows = false;
            this.dgvTiposDePermiso.BackgroundColor = System.Drawing.Color.White;
            this.dgvTiposDePermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposDePermiso.ColumnHeadersVisible = false;
            this.dgvTiposDePermiso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTiposDePermiso.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTiposDePermiso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTiposDePermiso.Location = new System.Drawing.Point(0, 193);
            this.dgvTiposDePermiso.Name = "dgvTiposDePermiso";
            this.dgvTiposDePermiso.RowHeadersVisible = false;
            this.dgvTiposDePermiso.Size = new System.Drawing.Size(462, 203);
            this.dgvTiposDePermiso.TabIndex = 10;
            this.dgvTiposDePermiso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiposDePermiso_CellClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "E";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 19;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "X";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 19;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "IDTipoDePermiso";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "NOMBRE PERMISO";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 200;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "DESCUENTO";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DETALLES";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LIMITE/Dias";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // frmTipoLIcencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 396);
            this.Controls.Add(this.dgvTiposDePermiso);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoLIcencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE TIPOS DE LICENCIA DEL TRABAJADOR";
            ((System.ComponentModel.ISupportInitialize)(this.nudLimite)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDePermiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNombreNuevoTipoPermiso;
        private System.Windows.Forms.TextBox tbDetallesPermisos;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox chbGoce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudLimite;
        private System.Windows.Forms.GroupBox gbDatos;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvTiposDePermiso;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

    }
}