namespace asistencia
{
    partial class frmHorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorario));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbPonerMismoHorario = new System.Windows.Forms.CheckBox();
            this.cbDomingo = new System.Windows.Forms.ComboBox();
            this.cbSabado = new System.Windows.Forms.ComboBox();
            this.cbViernes = new System.Windows.Forms.ComboBox();
            this.cbJueves = new System.Windows.Forms.ComboBox();
            this.cbMiercoles = new System.Windows.Forms.ComboBox();
            this.cbMartes = new System.Windows.Forms.ComboBox();
            this.cbLunes = new System.Windows.Forms.ComboBox();
            this.tbObservacionesHorario = new System.Windows.Forms.TextBox();
            this.tbNombreHorario = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.dgvHorariosExistentes = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDatos.Controls.Add(this.cbPonerMismoHorario);
            this.gbDatos.Controls.Add(this.cbDomingo);
            this.gbDatos.Controls.Add(this.cbSabado);
            this.gbDatos.Controls.Add(this.cbViernes);
            this.gbDatos.Controls.Add(this.cbJueves);
            this.gbDatos.Controls.Add(this.cbMiercoles);
            this.gbDatos.Controls.Add(this.cbMartes);
            this.gbDatos.Controls.Add(this.cbLunes);
            this.gbDatos.Controls.Add(this.tbObservacionesHorario);
            this.gbDatos.Controls.Add(this.tbNombreHorario);
            this.gbDatos.Controls.Add(this.label35);
            this.gbDatos.Controls.Add(this.label61);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.label56);
            this.gbDatos.Controls.Add(this.label57);
            this.gbDatos.Controls.Add(this.label59);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(9, 5);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(477, 264);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "CONFIGURACIÓN DE HORARIOS";
            // 
            // cbPonerMismoHorario
            // 
            this.cbPonerMismoHorario.AutoSize = true;
            this.cbPonerMismoHorario.Checked = true;
            this.cbPonerMismoHorario.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPonerMismoHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPonerMismoHorario.ForeColor = System.Drawing.Color.Firebrick;
            this.cbPonerMismoHorario.Location = new System.Drawing.Point(105, 44);
            this.cbPonerMismoHorario.Name = "cbPonerMismoHorario";
            this.cbPonerMismoHorario.Size = new System.Drawing.Size(230, 17);
            this.cbPonerMismoHorario.TabIndex = 2;
            this.cbPonerMismoHorario.Text = "LUNES A VIERNES EL MISMO HORARIO";
            this.cbPonerMismoHorario.UseVisualStyleBackColor = true;
            this.cbPonerMismoHorario.CheckedChanged += new System.EventHandler(this.cbPonerMismoHorario_CheckedChanged);
            // 
            // cbDomingo
            // 
            this.cbDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDomingo.FormattingEnabled = true;
            this.cbDomingo.Location = new System.Drawing.Point(104, 210);
            this.cbDomingo.Name = "cbDomingo";
            this.cbDomingo.Size = new System.Drawing.Size(361, 21);
            this.cbDomingo.TabIndex = 9;
            // 
            // cbSabado
            // 
            this.cbSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSabado.FormattingEnabled = true;
            this.cbSabado.Location = new System.Drawing.Point(104, 186);
            this.cbSabado.Name = "cbSabado";
            this.cbSabado.Size = new System.Drawing.Size(361, 21);
            this.cbSabado.TabIndex = 8;
            // 
            // cbViernes
            // 
            this.cbViernes.Enabled = false;
            this.cbViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViernes.FormattingEnabled = true;
            this.cbViernes.Location = new System.Drawing.Point(104, 162);
            this.cbViernes.Name = "cbViernes";
            this.cbViernes.Size = new System.Drawing.Size(361, 21);
            this.cbViernes.TabIndex = 7;
            // 
            // cbJueves
            // 
            this.cbJueves.Enabled = false;
            this.cbJueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJueves.FormattingEnabled = true;
            this.cbJueves.Location = new System.Drawing.Point(104, 138);
            this.cbJueves.Name = "cbJueves";
            this.cbJueves.Size = new System.Drawing.Size(361, 21);
            this.cbJueves.TabIndex = 6;
            // 
            // cbMiercoles
            // 
            this.cbMiercoles.Enabled = false;
            this.cbMiercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMiercoles.FormattingEnabled = true;
            this.cbMiercoles.Location = new System.Drawing.Point(104, 113);
            this.cbMiercoles.Name = "cbMiercoles";
            this.cbMiercoles.Size = new System.Drawing.Size(361, 21);
            this.cbMiercoles.TabIndex = 5;
            // 
            // cbMartes
            // 
            this.cbMartes.Enabled = false;
            this.cbMartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMartes.FormattingEnabled = true;
            this.cbMartes.Location = new System.Drawing.Point(104, 88);
            this.cbMartes.Name = "cbMartes";
            this.cbMartes.Size = new System.Drawing.Size(361, 21);
            this.cbMartes.TabIndex = 4;
            // 
            // cbLunes
            // 
            this.cbLunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLunes.FormattingEnabled = true;
            this.cbLunes.Location = new System.Drawing.Point(104, 64);
            this.cbLunes.Name = "cbLunes";
            this.cbLunes.Size = new System.Drawing.Size(361, 21);
            this.cbLunes.TabIndex = 3;
            this.cbLunes.SelectedIndexChanged += new System.EventHandler(this.cbLunes_SelectedIndexChanged);
            // 
            // tbObservacionesHorario
            // 
            this.tbObservacionesHorario.BackColor = System.Drawing.Color.White;
            this.tbObservacionesHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservacionesHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObservacionesHorario.Location = new System.Drawing.Point(104, 235);
            this.tbObservacionesHorario.Name = "tbObservacionesHorario";
            this.tbObservacionesHorario.Size = new System.Drawing.Size(361, 20);
            this.tbObservacionesHorario.TabIndex = 10;
            // 
            // tbNombreHorario
            // 
            this.tbNombreHorario.BackColor = System.Drawing.Color.White;
            this.tbNombreHorario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreHorario.Location = new System.Drawing.Point(104, 21);
            this.tbNombreHorario.Name = "tbNombreHorario";
            this.tbNombreHorario.Size = new System.Drawing.Size(361, 20);
            this.tbNombreHorario.TabIndex = 1;
            this.tbNombreHorario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.DimGray;
            this.label35.Location = new System.Drawing.Point(6, 68);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 13);
            this.label35.TabIndex = 8;
            this.label35.Text = "Horario Lunes";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.DimGray;
            this.label61.Location = new System.Drawing.Point(6, 21);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(81, 13);
            this.label61.TabIndex = 10;
            this.label61.Text = "Nombre Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horario Viernes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(4, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Horario Domingo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Horario Sábado";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.DimGray;
            this.label56.Location = new System.Drawing.Point(6, 142);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(78, 13);
            this.label56.TabIndex = 2;
            this.label56.Text = "Horario Jueves";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.DimGray;
            this.label57.Location = new System.Drawing.Point(6, 120);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(89, 13);
            this.label57.TabIndex = 4;
            this.label57.Text = "Horario Miércoles";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.DimGray;
            this.label59.Location = new System.Drawing.Point(6, 95);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(76, 13);
            this.label59.TabIndex = 5;
            this.label59.Text = "Horario Martes";
            // 
            // dgvHorariosExistentes
            // 
            this.dgvHorariosExistentes.AllowUserToAddRows = false;
            this.dgvHorariosExistentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Firebrick;
            this.dgvHorariosExistentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorariosExistentes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorariosExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHorariosExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorariosExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column12,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorariosExistentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHorariosExistentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHorariosExistentes.Location = new System.Drawing.Point(0, 319);
            this.dgvHorariosExistentes.Name = "dgvHorariosExistentes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorariosExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHorariosExistentes.RowHeadersVisible = false;
            this.dgvHorariosExistentes.Size = new System.Drawing.Size(495, 163);
            this.dgvHorariosExistentes.TabIndex = 17;
            this.dgvHorariosExistentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorariosExistentes_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(376, 272);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(269, 272);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.Column3.HeaderText = "IDHORARIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "HORARIO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "OBSERVACIÓN";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "lun";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "mar";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "mier";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "jue";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "vie";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "sab";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "dom";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // frmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 482);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvHorariosExistentes);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE HORARIOS";
            this.Load += new System.EventHandler(this.frmHorario_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosExistentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.CheckBox cbPonerMismoHorario;
        private System.Windows.Forms.ComboBox cbDomingo;
        private System.Windows.Forms.ComboBox cbSabado;
        private System.Windows.Forms.ComboBox cbViernes;
        private System.Windows.Forms.ComboBox cbJueves;
        private System.Windows.Forms.ComboBox cbMiercoles;
        private System.Windows.Forms.ComboBox cbMartes;
        private System.Windows.Forms.ComboBox cbLunes;
        private System.Windows.Forms.TextBox tbObservacionesHorario;
        private System.Windows.Forms.TextBox tbNombreHorario;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.DataGridView dgvHorariosExistentes;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}