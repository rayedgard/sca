namespace asistencia
{
    partial class frmTipoPermiso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPermiso));
            this.dgvTiposDePermiso = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.chbGoce = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tbDetalles = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDePermiso)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvTiposDePermiso.Location = new System.Drawing.Point(0, 161);
            this.dgvTiposDePermiso.Name = "dgvTiposDePermiso";
            this.dgvTiposDePermiso.RowHeadersVisible = false;
            this.dgvTiposDePermiso.Size = new System.Drawing.Size(462, 216);
            this.dgvTiposDePermiso.TabIndex = 14;
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
            // gbDatos
            // 
            this.gbDatos.AutoSize = true;
            this.gbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDatos.Controls.Add(this.chbGoce);
            this.gbDatos.Controls.Add(this.label33);
            this.gbDatos.Controls.Add(this.tbDetalles);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.label29);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(8, 6);
            this.gbDatos.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(449, 108);
            this.gbDatos.TabIndex = 11;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "CONFIGURACIÓN DE PERMISOS";
            // 
            // chbGoce
            // 
            this.chbGoce.AutoSize = true;
            this.chbGoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGoce.Location = new System.Drawing.Point(150, 49);
            this.chbGoce.Name = "chbGoce";
            this.chbGoce.Size = new System.Drawing.Size(15, 14);
            this.chbGoce.TabIndex = 1;
            this.chbGoce.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(3, 26);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(134, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "NOMBRE TIPO PERMISO";
            // 
            // tbDetalles
            // 
            this.tbDetalles.BackColor = System.Drawing.Color.White;
            this.tbDetalles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalles.Location = new System.Drawing.Point(148, 69);
            this.tbDetalles.Name = "tbDetalles";
            this.tbDetalles.Size = new System.Drawing.Size(291, 20);
            this.tbDetalles.TabIndex = 2;
            this.tbDetalles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.White;
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(148, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(291, 20);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "CON GOCE DE HABER";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(3, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "DETALLE";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(353, 114);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(246, 114);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmTipoPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 377);
            this.Controls.Add(this.dgvTiposDePermiso);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE TIPOS DE PERMISOS DEL TRABAJADOR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDePermiso)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiposDePermiso;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.CheckBox chbGoce;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbDetalles;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label29;
    }
}