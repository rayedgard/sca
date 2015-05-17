namespace asistencia
{
    partial class frmTipoPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPersonal));
            this.dgvAgenciasExistentes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCargos = new System.Windows.Forms.GroupBox();
            this.rbRotativo = new System.Windows.Forms.RadioButton();
            this.rbEstatico = new System.Windows.Forms.RadioButton();
            this.tbNombreCargo = new System.Windows.Forms.TextBox();
            this.tbSueldoDefault = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHorarioDefault = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenciasExistentes)).BeginInit();
            this.gbCargos.SuspendLayout();
            this.SuspendLayout();
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
            this.Column8});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgenciasExistentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenciasExistentes.Location = new System.Drawing.Point(0, 217);
            this.dgvAgenciasExistentes.Name = "dgvAgenciasExistentes";
            this.dgvAgenciasExistentes.RowHeadersVisible = false;
            this.dgvAgenciasExistentes.Size = new System.Drawing.Size(596, 174);
            this.dgvAgenciasExistentes.TabIndex = 7;
            this.dgvAgenciasExistentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenciasExistentes_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "E";
            this.Column1.Name = "Column1";
            this.Column1.Width = 19;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
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
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sueldo";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Detalles";
            this.Column6.Name = "Column6";
            this.Column6.Width = 240;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "IdHorario";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // gbCargos
            // 
            this.gbCargos.Controls.Add(this.rbRotativo);
            this.gbCargos.Controls.Add(this.rbEstatico);
            this.gbCargos.Controls.Add(this.tbNombreCargo);
            this.gbCargos.Controls.Add(this.tbSueldoDefault);
            this.gbCargos.Controls.Add(this.tbDescripcion);
            this.gbCargos.Controls.Add(this.label5);
            this.gbCargos.Controls.Add(this.label4);
            this.gbCargos.Controls.Add(this.label3);
            this.gbCargos.Controls.Add(this.label2);
            this.gbCargos.Controls.Add(this.label1);
            this.gbCargos.Controls.Add(this.cbHorarioDefault);
            this.gbCargos.Enabled = false;
            this.gbCargos.Location = new System.Drawing.Point(5, 12);
            this.gbCargos.Name = "gbCargos";
            this.gbCargos.Size = new System.Drawing.Size(586, 151);
            this.gbCargos.TabIndex = 22;
            this.gbCargos.TabStop = false;
            this.gbCargos.Text = "CARGOS";
            // 
            // rbRotativo
            // 
            this.rbRotativo.AutoSize = true;
            this.rbRotativo.Location = new System.Drawing.Point(292, 95);
            this.rbRotativo.Name = "rbRotativo";
            this.rbRotativo.Size = new System.Drawing.Size(133, 17);
            this.rbRotativo.TabIndex = 4;
            this.rbRotativo.Text = "HORARIO ROTATIVO";
            this.rbRotativo.UseVisualStyleBackColor = true;
            this.rbRotativo.Click += new System.EventHandler(this.rbRotativo_Click);
            // 
            // rbEstatico
            // 
            this.rbEstatico.AutoSize = true;
            this.rbEstatico.Checked = true;
            this.rbEstatico.Location = new System.Drawing.Point(140, 96);
            this.rbEstatico.Name = "rbEstatico";
            this.rbEstatico.Size = new System.Drawing.Size(124, 17);
            this.rbEstatico.TabIndex = 3;
            this.rbEstatico.TabStop = true;
            this.rbEstatico.Text = "HORARIO NORMAL";
            this.rbEstatico.UseVisualStyleBackColor = true;
            this.rbEstatico.Click += new System.EventHandler(this.rbEstatico_Click);
            // 
            // tbNombreCargo
            // 
            this.tbNombreCargo.Location = new System.Drawing.Point(140, 20);
            this.tbNombreCargo.Name = "tbNombreCargo";
            this.tbNombreCargo.Size = new System.Drawing.Size(435, 20);
            this.tbNombreCargo.TabIndex = 0;
            this.tbNombreCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // tbSueldoDefault
            // 
            this.tbSueldoDefault.Location = new System.Drawing.Point(140, 46);
            this.tbSueldoDefault.Name = "tbSueldoDefault";
            this.tbSueldoDefault.Size = new System.Drawing.Size(435, 20);
            this.tbSueldoDefault.TabIndex = 1;
            this.tbSueldoDefault.Text = "0";
            this.tbSueldoDefault.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaDecimales);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(140, 70);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(435, 20);
            this.tbDescripcion.TabIndex = 2;
            this.tbDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "HORRIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "TIPO DE HORARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "DETALLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "SUELDO REFERENCIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "NOMBRE DEL CARGO";
            // 
            // cbHorarioDefault
            // 
            this.cbHorarioDefault.FormattingEnabled = true;
            this.cbHorarioDefault.Location = new System.Drawing.Point(140, 118);
            this.cbHorarioDefault.Name = "cbHorarioDefault";
            this.cbHorarioDefault.Size = new System.Drawing.Size(435, 21);
            this.cbHorarioDefault.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(373, 170);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarAgencia_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(482, 170);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevaAgencia_Click);
            // 
            // frmTipoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 391);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbCargos);
            this.Controls.Add(this.dgvAgenciasExistentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE CARGOS";
            this.Load += new System.EventHandler(this.frmTipoPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenciasExistentes)).EndInit();
            this.gbCargos.ResumeLayout(false);
            this.gbCargos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgenciasExistentes;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox gbCargos;
        private System.Windows.Forms.RadioButton rbRotativo;
        private System.Windows.Forms.RadioButton rbEstatico;
        private System.Windows.Forms.TextBox tbNombreCargo;
        private System.Windows.Forms.TextBox tbSueldoDefault;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHorarioDefault;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
    }
}