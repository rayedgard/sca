namespace asistencia
{
    partial class frmAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreas));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.tbDescripcionArea = new System.Windows.Forms.TextBox();
            this.tbNombreArea = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvAreasExistentes = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreasExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDatos.Controls.Add(this.tbDescripcionArea);
            this.gbDatos.Controls.Add(this.tbNombreArea);
            this.gbDatos.Controls.Add(this.label18);
            this.gbDatos.Controls.Add(this.label20);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(2, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(501, 79);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "CONFIGURACIÓN DE ÁREAS DE TRABAJO";
            // 
            // tbDescripcionArea
            // 
            this.tbDescripcionArea.BackColor = System.Drawing.Color.White;
            this.tbDescripcionArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescripcionArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcionArea.Location = new System.Drawing.Point(96, 50);
            this.tbDescripcionArea.Name = "tbDescripcionArea";
            this.tbDescripcionArea.Size = new System.Drawing.Size(397, 20);
            this.tbDescripcionArea.TabIndex = 1;
            this.tbDescripcionArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // tbNombreArea
            // 
            this.tbNombreArea.BackColor = System.Drawing.Color.White;
            this.tbNombreArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreArea.Location = new System.Drawing.Point(96, 23);
            this.tbNombreArea.Name = "tbNombreArea";
            this.tbNombreArea.Size = new System.Drawing.Size(397, 20);
            this.tbNombreArea.TabIndex = 0;
            this.tbNombreArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(6, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Descripción";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(6, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Nombre de área";
            // 
            // dgvAreasExistentes
            // 
            this.dgvAreasExistentes.AllowUserToAddRows = false;
            this.dgvAreasExistentes.AllowUserToDeleteRows = false;
            this.dgvAreasExistentes.AllowUserToResizeColumns = false;
            this.dgvAreasExistentes.AllowUserToResizeRows = false;
            this.dgvAreasExistentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAreasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreasExistentes.ColumnHeadersVisible = false;
            this.dgvAreasExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAreasExistentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAreasExistentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAreasExistentes.Location = new System.Drawing.Point(0, 142);
            this.dgvAreasExistentes.Name = "dgvAreasExistentes";
            this.dgvAreasExistentes.RowHeadersVisible = false;
            this.dgvAreasExistentes.Size = new System.Drawing.Size(508, 242);
            this.dgvAreasExistentes.TabIndex = 4;
            this.dgvAreasExistentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAreasExistentes_CellClick);
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
            this.Column11.HeaderText = "IdArea";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Area";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 190;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Descripcion";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 145;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(397, 95);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(290, 95);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 384);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAreasExistentes);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE ÁREAS";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreasExistentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox tbDescripcionArea;
        private System.Windows.Forms.TextBox tbNombreArea;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvAreasExistentes;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardar;
    }
}