namespace asistencia
{
    partial class frmAgencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgencia));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbDistritos = new System.Windows.Forms.ComboBox();
            this.cbProvincias = new System.Windows.Forms.ComboBox();
            this.tbTelefonoAgencia = new System.Windows.Forms.TextBox();
            this.tbDireccionAgencia = new System.Windows.Forms.TextBox();
            this.tbNombreAgencia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.dgvAgenciasExistentes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenciasExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDatos.Controls.Add(this.cbDistritos);
            this.gbDatos.Controls.Add(this.cbProvincias);
            this.gbDatos.Controls.Add(this.tbTelefonoAgencia);
            this.gbDatos.Controls.Add(this.tbDireccionAgencia);
            this.gbDatos.Controls.Add(this.tbNombreAgencia);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.label61);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(7, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(523, 146);
            this.gbDatos.TabIndex = 8;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS DE AGENCIA";
            // 
            // cbDistritos
            // 
            this.cbDistritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDistritos.FormattingEnabled = true;
            this.cbDistritos.ItemHeight = 13;
            this.cbDistritos.Location = new System.Drawing.Point(116, 117);
            this.cbDistritos.Name = "cbDistritos";
            this.cbDistritos.Size = new System.Drawing.Size(395, 21);
            this.cbDistritos.TabIndex = 5;
            // 
            // cbProvincias
            // 
            this.cbProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincias.FormattingEnabled = true;
            this.cbProvincias.ItemHeight = 13;
            this.cbProvincias.Location = new System.Drawing.Point(117, 92);
            this.cbProvincias.Name = "cbProvincias";
            this.cbProvincias.Size = new System.Drawing.Size(394, 21);
            this.cbProvincias.TabIndex = 4;
            this.cbProvincias.SelectedIndexChanged += new System.EventHandler(this.cbProvincias_SelectedIndexChanged);
            // 
            // tbTelefonoAgencia
            // 
            this.tbTelefonoAgencia.BackColor = System.Drawing.Color.White;
            this.tbTelefonoAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTelefonoAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoAgencia.Location = new System.Drawing.Point(117, 44);
            this.tbTelefonoAgencia.Name = "tbTelefonoAgencia";
            this.tbTelefonoAgencia.Size = new System.Drawing.Size(394, 20);
            this.tbTelefonoAgencia.TabIndex = 1;
            this.tbTelefonoAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumeros);
            // 
            // tbDireccionAgencia
            // 
            this.tbDireccionAgencia.BackColor = System.Drawing.Color.White;
            this.tbDireccionAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccionAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccionAgencia.Location = new System.Drawing.Point(117, 68);
            this.tbDireccionAgencia.Name = "tbDireccionAgencia";
            this.tbDireccionAgencia.Size = new System.Drawing.Size(394, 20);
            this.tbDireccionAgencia.TabIndex = 2;
            this.tbDireccionAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // tbNombreAgencia
            // 
            this.tbNombreAgencia.BackColor = System.Drawing.Color.White;
            this.tbNombreAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreAgencia.Location = new System.Drawing.Point(117, 21);
            this.tbNombreAgencia.Name = "tbNombreAgencia";
            this.tbNombreAgencia.Size = new System.Drawing.Size(394, 20);
            this.tbNombreAgencia.TabIndex = 0;
            this.tbNombreAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(6, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "DISTRITO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "PROVINCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "TELÉFONO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DIRECCIÓN";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.DimGray;
            this.label61.Location = new System.Drawing.Point(6, 23);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(104, 13);
            this.label61.TabIndex = 17;
            this.label61.Text = "NOMBRE AGENCIA";
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
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenciasExistentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenciasExistentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAgenciasExistentes.Location = new System.Drawing.Point(0, 214);
            this.dgvAgenciasExistentes.Name = "dgvAgenciasExistentes";
            this.dgvAgenciasExistentes.RowHeadersVisible = false;
            this.dgvAgenciasExistentes.Size = new System.Drawing.Size(529, 162);
            this.dgvAgenciasExistentes.TabIndex = 7;
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
            this.Column3.HeaderText = "IdAgencia";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Agencia";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Direccion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "IdProvincia";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IdDistrito";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(420, 162);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(313, 162);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 376);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAgenciasExistentes);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE AGENCIAS";
            this.Load += new System.EventHandler(this.frmAgencia_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenciasExistentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ComboBox cbDistritos;
        private System.Windows.Forms.ComboBox cbProvincias;
        private System.Windows.Forms.TextBox tbTelefonoAgencia;
        private System.Windows.Forms.TextBox tbDireccionAgencia;
        private System.Windows.Forms.TextBox tbNombreAgencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.DataGridView dgvAgenciasExistentes;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardar;
    }
}