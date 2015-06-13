namespace asistencia
{
    partial class frmDiasNoLaborables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiasNoLaborables));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.nudMInutoFin = new System.Windows.Forms.NumericUpDown();
            this.nudMinutoIni = new System.Windows.Forms.NumericUpDown();
            this.nudHoraFIn = new System.Windows.Forms.NumericUpDown();
            this.nudHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.paColorFondo = new System.Windows.Forms.Panel();
            this.pbImagenMenu = new System.Windows.Forms.PictureBox();
            this.rbNoTodoDia = new System.Windows.Forms.RadioButton();
            this.rbSiTodoDia = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNombreFeriado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbImagenMenu = new System.Windows.Forms.Label();
            this.lbColorFondo = new System.Windows.Forms.Label();
            this.dgvDiasFeriados = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdDiaLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREFERIADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDoDIA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HORAINI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cdSeleccionarColor = new System.Windows.Forms.ColorDialog();
            this.ofd_CargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMInutoFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutoIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraFIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasFeriados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDatos.Controls.Add(this.nudMInutoFin);
            this.gbDatos.Controls.Add(this.nudMinutoIni);
            this.gbDatos.Controls.Add(this.nudHoraFIn);
            this.gbDatos.Controls.Add(this.nudHoraInicio);
            this.gbDatos.Controls.Add(this.paColorFondo);
            this.gbDatos.Controls.Add(this.pbImagenMenu);
            this.gbDatos.Controls.Add(this.rbNoTodoDia);
            this.gbDatos.Controls.Add(this.rbSiTodoDia);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.tbNombreFeriado);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.lbImagenMenu);
            this.gbDatos.Controls.Add(this.lbColorFondo);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(6, 9);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(449, 140);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "CONFIGURACIÓN DE DÍAS NO LABORABLES";
            // 
            // nudMInutoFin
            // 
            this.nudMInutoFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMInutoFin.Location = new System.Drawing.Point(197, 95);
            this.nudMInutoFin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMInutoFin.Name = "nudMInutoFin";
            this.nudMInutoFin.Size = new System.Drawing.Size(43, 20);
            this.nudMInutoFin.TabIndex = 7;
            // 
            // nudMinutoIni
            // 
            this.nudMinutoIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutoIni.Location = new System.Drawing.Point(197, 69);
            this.nudMinutoIni.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutoIni.Name = "nudMinutoIni";
            this.nudMinutoIni.Size = new System.Drawing.Size(43, 20);
            this.nudMinutoIni.TabIndex = 5;
            // 
            // nudHoraFIn
            // 
            this.nudHoraFIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoraFIn.Location = new System.Drawing.Point(141, 95);
            this.nudHoraFIn.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoraFIn.Name = "nudHoraFIn";
            this.nudHoraFIn.Size = new System.Drawing.Size(43, 20);
            this.nudHoraFIn.TabIndex = 6;
            // 
            // nudHoraInicio
            // 
            this.nudHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoraInicio.Location = new System.Drawing.Point(141, 69);
            this.nudHoraInicio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoraInicio.Name = "nudHoraInicio";
            this.nudHoraInicio.Size = new System.Drawing.Size(43, 20);
            this.nudHoraInicio.TabIndex = 4;
            // 
            // paColorFondo
            // 
            this.paColorFondo.BackColor = System.Drawing.Color.Firebrick;
            this.paColorFondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paColorFondo.Location = new System.Drawing.Point(277, 46);
            this.paColorFondo.Name = "paColorFondo";
            this.paColorFondo.Size = new System.Drawing.Size(65, 69);
            this.paColorFondo.TabIndex = 9;
            this.paColorFondo.Click += new System.EventHandler(this.paColorFondo_Click);
            // 
            // pbImagenMenu
            // 
            this.pbImagenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImagenMenu.Image = global::asistencia.Properties.Resources.Navidad_Christmas_Tree;
            this.pbImagenMenu.Location = new System.Drawing.Point(364, 45);
            this.pbImagenMenu.Name = "pbImagenMenu";
            this.pbImagenMenu.Size = new System.Drawing.Size(66, 69);
            this.pbImagenMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenMenu.TabIndex = 8;
            this.pbImagenMenu.TabStop = false;
            this.pbImagenMenu.Click += new System.EventHandler(this.pbImagenMenu_Click);
            // 
            // rbNoTodoDia
            // 
            this.rbNoTodoDia.AutoSize = true;
            this.rbNoTodoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoTodoDia.ForeColor = System.Drawing.Color.DimGray;
            this.rbNoTodoDia.Location = new System.Drawing.Point(188, 45);
            this.rbNoTodoDia.Name = "rbNoTodoDia";
            this.rbNoTodoDia.Size = new System.Drawing.Size(39, 17);
            this.rbNoTodoDia.TabIndex = 3;
            this.rbNoTodoDia.Text = "No";
            this.rbNoTodoDia.UseVisualStyleBackColor = true;
            // 
            // rbSiTodoDia
            // 
            this.rbSiTodoDia.AutoSize = true;
            this.rbSiTodoDia.Checked = true;
            this.rbSiTodoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSiTodoDia.ForeColor = System.Drawing.Color.Firebrick;
            this.rbSiTodoDia.Location = new System.Drawing.Point(141, 45);
            this.rbSiTodoDia.Name = "rbSiTodoDia";
            this.rbSiTodoDia.Size = new System.Drawing.Size(34, 17);
            this.rbSiTodoDia.TabIndex = 2;
            this.rbSiTodoDia.TabStop = true;
            this.rbSiTodoDia.Text = "Si";
            this.rbSiTodoDia.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre del día feriado";
            // 
            // tbNombreFeriado
            // 
            this.tbNombreFeriado.BackColor = System.Drawing.Color.White;
            this.tbNombreFeriado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreFeriado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreFeriado.Location = new System.Drawing.Point(141, 16);
            this.tbNombreFeriado.Name = "tbNombreFeriado";
            this.tbNombreFeriado.Size = new System.Drawing.Size(300, 20);
            this.tbNombreFeriado.TabIndex = 1;
            this.tbNombreFeriado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Feriado todo el día";
            // 
            // lbImagenMenu
            // 
            this.lbImagenMenu.AutoSize = true;
            this.lbImagenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbImagenMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagenMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.lbImagenMenu.Location = new System.Drawing.Point(349, 118);
            this.lbImagenMenu.Name = "lbImagenMenu";
            this.lbImagenMenu.Size = new System.Drawing.Size(99, 13);
            this.lbImagenMenu.TabIndex = 0;
            this.lbImagenMenu.Text = "Imagen Referencial";
            // 
            // lbColorFondo
            // 
            this.lbColorFondo.AutoSize = true;
            this.lbColorFondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbColorFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColorFondo.ForeColor = System.Drawing.Color.Firebrick;
            this.lbColorFondo.Location = new System.Drawing.Point(278, 118);
            this.lbColorFondo.Name = "lbColorFondo";
            this.lbColorFondo.Size = new System.Drawing.Size(64, 13);
            this.lbColorFondo.TabIndex = 0;
            this.lbColorFondo.Text = "Color Fondo";
            // 
            // dgvDiasFeriados
            // 
            this.dgvDiasFeriados.AllowUserToAddRows = false;
            this.dgvDiasFeriados.AllowUserToDeleteRows = false;
            this.dgvDiasFeriados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiasFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiasFeriados.ColumnHeadersVisible = false;
            this.dgvDiasFeriados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Column4,
            this.IdDiaLaboral,
            this.NOMBREFERIADO,
            this.ToDoDIA,
            this.HORAINI,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDiasFeriados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDiasFeriados.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDiasFeriados.Location = new System.Drawing.Point(0, 201);
            this.dgvDiasFeriados.Name = "dgvDiasFeriados";
            this.dgvDiasFeriados.RowHeadersVisible = false;
            this.dgvDiasFeriados.Size = new System.Drawing.Size(467, 223);
            this.dgvDiasFeriados.TabIndex = 14;
            this.dgvDiasFeriados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiasFeriados_CellClick);
            // 
            // Editar
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle9;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 16;
            // 
            // Column4
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column4.HeaderText = "Eliminar";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 16;
            // 
            // IdDiaLaboral
            // 
            this.IdDiaLaboral.HeaderText = "IDDiaLaboral";
            this.IdDiaLaboral.Name = "IdDiaLaboral";
            this.IdDiaLaboral.ReadOnly = true;
            this.IdDiaLaboral.Visible = false;
            // 
            // NOMBREFERIADO
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DimGray;
            this.NOMBREFERIADO.DefaultCellStyle = dataGridViewCellStyle11;
            this.NOMBREFERIADO.HeaderText = "NOMBRE FERIADO";
            this.NOMBREFERIADO.Name = "NOMBREFERIADO";
            this.NOMBREFERIADO.ReadOnly = true;
            this.NOMBREFERIADO.Width = 125;
            // 
            // ToDoDIA
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.NullValue = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Firebrick;
            this.ToDoDIA.DefaultCellStyle = dataGridViewCellStyle12;
            this.ToDoDIA.HeaderText = "TODO EL DIA";
            this.ToDoDIA.Name = "ToDoDIA";
            this.ToDoDIA.ReadOnly = true;
            this.ToDoDIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ToDoDIA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ToDoDIA.Width = 25;
            // 
            // HORAINI
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Firebrick;
            this.HORAINI.DefaultCellStyle = dataGridViewCellStyle13;
            this.HORAINI.HeaderText = "HORA INICIO";
            this.HORAINI.Name = "HORAINI";
            this.HORAINI.ReadOnly = true;
            this.HORAINI.Width = 55;
            // 
            // Column1
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DimGray;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column1.HeaderText = "HORA FIN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column2.HeaderText = "COLOR FONDO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 16;
            // 
            // Column3
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle16.NullValue")));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column3.HeaderText = "IMAGEN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 32;
            // 
            // cdSeleccionarColor
            // 
            this.cdSeleccionarColor.Color = System.Drawing.Color.LightBlue;
            this.cdSeleccionarColor.FullOpen = true;
            // 
            // ofd_CargarImagen
            // 
            this.ofd_CargarImagen.FileName = "openFileDialog1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(351, 154);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(244, 154);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmDiasNoLaborables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 424);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDiasFeriados);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiasNoLaborables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE DÍAS NO LABORABLES";
            this.Load += new System.EventHandler(this.frmDiasNoLaborables_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMInutoFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutoIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraFIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasFeriados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.NumericUpDown nudMInutoFin;
        private System.Windows.Forms.NumericUpDown nudMinutoIni;
        private System.Windows.Forms.NumericUpDown nudHoraFIn;
        private System.Windows.Forms.NumericUpDown nudHoraInicio;
        private System.Windows.Forms.Panel paColorFondo;
        private System.Windows.Forms.PictureBox pbImagenMenu;
        private System.Windows.Forms.RadioButton rbNoTodoDia;
        private System.Windows.Forms.RadioButton rbSiTodoDia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNombreFeriado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbImagenMenu;
        private System.Windows.Forms.Label lbColorFondo;
        private System.Windows.Forms.DataGridView dgvDiasFeriados;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiaLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREFERIADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ToDoDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAINI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColorDialog cdSeleccionarColor;
        private System.Windows.Forms.OpenFileDialog ofd_CargarImagen;
    }
}