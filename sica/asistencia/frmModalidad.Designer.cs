namespace asistencia
{
    partial class frmModalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModalidad));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombreCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.dgvAgenciasExistentes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenciasExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDatos.Controls.Add(this.tbDescripcion);
            this.gbDatos.Controls.Add(this.tbNombreCargo);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label61);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(7, 11);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(451, 81);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS DE MODALIDAD";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.White;
            this.tbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(78, 46);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(369, 20);
            this.tbDescripcion.TabIndex = 3;
            this.tbDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // tbNombreCargo
            // 
            this.tbNombreCargo.BackColor = System.Drawing.Color.White;
            this.tbNombreCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCargo.Location = new System.Drawing.Point(78, 20);
            this.tbNombreCargo.Name = "tbNombreCargo";
            this.tbNombreCargo.Size = new System.Drawing.Size(369, 20);
            this.tbNombreCargo.TabIndex = 1;
            this.tbNombreCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Detalles";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.DimGray;
            this.label61.Location = new System.Drawing.Point(6, 20);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(56, 13);
            this.label61.TabIndex = 17;
            this.label61.Text = "Modalidad";
            // 
            // dgvAgenciasExistentes
            // 
            this.dgvAgenciasExistentes.AllowUserToAddRows = false;
            this.dgvAgenciasExistentes.AllowUserToDeleteRows = false;
            this.dgvAgenciasExistentes.AllowUserToResizeColumns = false;
            this.dgvAgenciasExistentes.AllowUserToResizeRows = false;
            this.dgvAgenciasExistentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgenciasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenciasExistentes.ColumnHeadersVisible = false;
            this.dgvAgenciasExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenciasExistentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenciasExistentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAgenciasExistentes.Location = new System.Drawing.Point(0, 147);
            this.dgvAgenciasExistentes.Name = "dgvAgenciasExistentes";
            this.dgvAgenciasExistentes.RowHeadersVisible = false;
            this.dgvAgenciasExistentes.Size = new System.Drawing.Size(464, 199);
            this.dgvAgenciasExistentes.TabIndex = 21;
            this.dgvAgenciasExistentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenciasExistentes_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "E";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 19;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 19;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IdCargo";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cargo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Detalles";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(356, 100);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(249, 100);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 346);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAgenciasExistentes);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 384);
            this.Name = "frmModalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE MODALIDADES DE CONTRATO";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenciasExistentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombreCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.DataGridView dgvAgenciasExistentes;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}