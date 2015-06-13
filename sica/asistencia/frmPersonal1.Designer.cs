namespace asistencia
{
    partial class frmPersonal1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal1));
            this.pBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbProfesion = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbContrato = new System.Windows.Forms.GroupBox();
            this.cbHorarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAreasTrabajo = new System.Windows.Forms.ComboBox();
            this.cbModalidadContrato = new System.Windows.Forms.ComboBox();
            this.cbCargos = new System.Windows.Forms.ComboBox();
            this.cbAgencia = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRemuneracion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCelularEmpresa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTelefonoEmpresa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEmailEmpresa = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.ofd_CargarImagen = new System.Windows.Forms.OpenFileDialog();
            this.epValida = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbHabilitado = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Button();
            this.pBotones.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValida)).BeginInit();
            this.SuspendLayout();
            // 
            // pBotones
            // 
            this.pBotones.Controls.Add(this.btnEliminar);
            this.pBotones.Controls.Add(this.btnGuardar);
            this.pBotones.Controls.Add(this.btnCancelar);
            this.pBotones.Controls.Add(this.btnNuevo);
            this.pBotones.Location = new System.Drawing.Point(11, 371);
            this.pBotones.Margin = new System.Windows.Forms.Padding(2);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(860, 65);
            this.pBotones.TabIndex = 52;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(117, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 42);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(7, 12);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(652, 12);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 42);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(755, 12);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 42);
            this.btnNuevo.TabIndex = 30;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label25);
            this.gbDatos.Controls.Add(this.tbProfesion);
            this.gbDatos.Controls.Add(this.label24);
            this.gbDatos.Controls.Add(this.cbDistrito);
            this.gbDatos.Controls.Add(this.label23);
            this.gbDatos.Controls.Add(this.cbProvincia);
            this.gbDatos.Controls.Add(this.pbFoto);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.dtFechaNacimiento);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.tbDireccion);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.tbCelular);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.tbTelefono);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.tbEmail);
            this.gbDatos.Controls.Add(this.rbFemenino);
            this.gbDatos.Controls.Add(this.rbMasculino);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.tbMaterno);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.tbPaterno);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.lbCodigo);
            this.gbDatos.Controls.Add(this.tbNombres);
            this.gbDatos.Controls.Add(this.tbDNI);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(11, 47);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(860, 159);
            this.gbDatos.TabIndex = 50;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "DATOS PERSONALES";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(344, 58);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "PROFESIÓN";
            // 
            // tbProfesion
            // 
            this.tbProfesion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProfesion.Location = new System.Drawing.Point(422, 54);
            this.tbProfesion.Name = "tbProfesion";
            this.tbProfesion.Size = new System.Drawing.Size(157, 20);
            this.tbProfesion.TabIndex = 7;
            this.tbProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(626, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "DISTRITO";
            // 
            // cbDistrito
            // 
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Location = new System.Drawing.Point(708, 105);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(147, 21);
            this.cbDistrito.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(626, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "PROVINCIA";
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Location = new System.Drawing.Point(708, 78);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(147, 21);
            this.cbProvincia.TabIndex = 12;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Image = global::asistencia.Properties.Resources.siluetaPersona;
            this.pbFoto.InitialImage = null;
            this.pbFoto.Location = new System.Drawing.Point(258, 24);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(78, 88);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 23;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "NACIMIENTO";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(422, 27);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(157, 20);
            this.dtFechaNacimiento.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "DIRECCIÓN";
            // 
            // tbDireccion
            // 
            this.tbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDireccion.Location = new System.Drawing.Point(708, 51);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(147, 20);
            this.tbDireccion.TabIndex = 11;
            this.tbDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "CELULAR";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(708, 25);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(147, 20);
            this.tbCelular.TabIndex = 10;
            this.tbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumeros);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "TELÉFONO";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(422, 105);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(157, 20);
            this.tbTelefono.TabIndex = 9;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumeros);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "EMAIL";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(422, 80);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(157, 20);
            this.tbEmail.TabIndex = 8;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(178, 131);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(81, 17);
            this.rbFemenino.TabIndex = 5;
            this.rbFemenino.Text = "FEMENINO";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(83, 132);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(88, 17);
            this.rbMasculino.TabIndex = 4;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "MASCULINO";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SEXO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MATERNO";
            // 
            // tbMaterno
            // 
            this.tbMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMaterno.Location = new System.Drawing.Point(85, 106);
            this.tbMaterno.Name = "tbMaterno";
            this.tbMaterno.Size = new System.Drawing.Size(167, 20);
            this.tbMaterno.TabIndex = 3;
            this.tbMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PATERNO";
            // 
            // tbPaterno
            // 
            this.tbPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPaterno.Location = new System.Drawing.Point(85, 80);
            this.tbPaterno.Name = "tbPaterno";
            this.tbPaterno.Size = new System.Drawing.Size(167, 20);
            this.tbPaterno.TabIndex = 2;
            this.tbPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRES";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(7, 34);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(26, 13);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "DNI";
            // 
            // tbNombres
            // 
            this.tbNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombres.Location = new System.Drawing.Point(85, 53);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(167, 20);
            this.tbNombres.TabIndex = 1;
            this.tbNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(85, 27);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(167, 20);
            this.tbDNI.TabIndex = 0;
            this.tbDNI.TextChanged += new System.EventHandler(this.tbDNI_TextChanged);
            this.tbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumeros);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "DATOS DEL EMPLEADO";
            // 
            // gbContrato
            // 
            this.gbContrato.Controls.Add(this.cbHorarios);
            this.gbContrato.Controls.Add(this.label4);
            this.gbContrato.Controls.Add(this.cbAreasTrabajo);
            this.gbContrato.Controls.Add(this.cbModalidadContrato);
            this.gbContrato.Controls.Add(this.cbCargos);
            this.gbContrato.Controls.Add(this.cbAgencia);
            this.gbContrato.Controls.Add(this.label18);
            this.gbContrato.Controls.Add(this.button1);
            this.gbContrato.Controls.Add(this.label17);
            this.gbContrato.Controls.Add(this.dtFechaFin);
            this.gbContrato.Controls.Add(this.label12);
            this.gbContrato.Controls.Add(this.dtFechaInicio);
            this.gbContrato.Controls.Add(this.label13);
            this.gbContrato.Controls.Add(this.tbRemuneracion);
            this.gbContrato.Controls.Add(this.label14);
            this.gbContrato.Controls.Add(this.tbCelularEmpresa);
            this.gbContrato.Controls.Add(this.label15);
            this.gbContrato.Controls.Add(this.tbTelefonoEmpresa);
            this.gbContrato.Controls.Add(this.label16);
            this.gbContrato.Controls.Add(this.tbEmailEmpresa);
            this.gbContrato.Controls.Add(this.label19);
            this.gbContrato.Controls.Add(this.label20);
            this.gbContrato.Controls.Add(this.label21);
            this.gbContrato.Controls.Add(this.label22);
            this.gbContrato.Controls.Add(this.tbCodigoEmpresa);
            this.gbContrato.Enabled = false;
            this.gbContrato.Location = new System.Drawing.Point(11, 212);
            this.gbContrato.Name = "gbContrato";
            this.gbContrato.Size = new System.Drawing.Size(860, 154);
            this.gbContrato.TabIndex = 51;
            this.gbContrato.TabStop = false;
            this.gbContrato.Text = "DATOS DE CONTRATO";
            // 
            // cbHorarios
            // 
            this.cbHorarios.Enabled = false;
            this.cbHorarios.FormattingEnabled = true;
            this.cbHorarios.Location = new System.Drawing.Point(422, 46);
            this.cbHorarios.Name = "cbHorarios";
            this.cbHorarios.Size = new System.Drawing.Size(157, 21);
            this.cbHorarios.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "ÁREA";
            // 
            // cbAreasTrabajo
            // 
            this.cbAreasTrabajo.FormattingEnabled = true;
            this.cbAreasTrabajo.Location = new System.Drawing.Point(83, 71);
            this.cbAreasTrabajo.Name = "cbAreasTrabajo";
            this.cbAreasTrabajo.Size = new System.Drawing.Size(169, 21);
            this.cbAreasTrabajo.TabIndex = 16;
            // 
            // cbModalidadContrato
            // 
            this.cbModalidadContrato.FormattingEnabled = true;
            this.cbModalidadContrato.Location = new System.Drawing.Point(422, 21);
            this.cbModalidadContrato.Name = "cbModalidadContrato";
            this.cbModalidadContrato.Size = new System.Drawing.Size(157, 21);
            this.cbModalidadContrato.TabIndex = 18;
            // 
            // cbCargos
            // 
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.Location = new System.Drawing.Point(83, 98);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(169, 21);
            this.cbCargos.TabIndex = 17;
            this.cbCargos.SelectedIndexChanged += new System.EventHandler(this.cbCargos_SelectedIndexChanged);
            // 
            // cbAgencia
            // 
            this.cbAgencia.FormattingEnabled = true;
            this.cbAgencia.Location = new System.Drawing.Point(83, 45);
            this.cbAgencia.Name = "cbAgencia";
            this.cbAgencia.Size = new System.Drawing.Size(169, 21);
            this.cbAgencia.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(310, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "HORARIO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "HUELLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "FECHA DE FIN";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(422, 99);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(157, 20);
            this.dtFechaFin.TabIndex = 21;
            this.dtFechaFin.ValueChanged += new System.EventHandler(this.dtFechaFin_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "FECHA DE INICIO";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(423, 75);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(157, 20);
            this.dtFechaInicio.TabIndex = 20;
            this.dtFechaInicio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(586, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "REMUNERACIÓN";
            // 
            // tbRemuneracion
            // 
            this.tbRemuneracion.Location = new System.Drawing.Point(708, 98);
            this.tbRemuneracion.Name = "tbRemuneracion";
            this.tbRemuneracion.Size = new System.Drawing.Size(146, 20);
            this.tbRemuneracion.TabIndex = 25;
            this.tbRemuneracion.Text = "0";
            this.tbRemuneracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaDecimales);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(586, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "CELULAR EMPRESA";
            // 
            // tbCelularEmpresa
            // 
            this.tbCelularEmpresa.Location = new System.Drawing.Point(708, 71);
            this.tbCelularEmpresa.Name = "tbCelularEmpresa";
            this.tbCelularEmpresa.Size = new System.Drawing.Size(146, 20);
            this.tbCelularEmpresa.TabIndex = 24;
            this.tbCelularEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumeros);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(586, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "TELÉFONO EMPRESA";
            // 
            // tbTelefonoEmpresa
            // 
            this.tbTelefonoEmpresa.Location = new System.Drawing.Point(708, 46);
            this.tbTelefonoEmpresa.Name = "tbTelefonoEmpresa";
            this.tbTelefonoEmpresa.Size = new System.Drawing.Size(146, 20);
            this.tbTelefonoEmpresa.TabIndex = 23;
            this.tbTelefonoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumeros);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(587, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "EMAIL EMPRESA";
            // 
            // tbEmailEmpresa
            // 
            this.tbEmailEmpresa.Location = new System.Drawing.Point(708, 21);
            this.tbEmailEmpresa.Name = "tbEmailEmpresa";
            this.tbEmailEmpresa.Size = new System.Drawing.Size(146, 20);
            this.tbEmailEmpresa.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(310, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "MODALIDAD";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "CARGO";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "AGENCIA";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "CÓDIGO";
            // 
            // tbCodigoEmpresa
            // 
            this.tbCodigoEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodigoEmpresa.Location = new System.Drawing.Point(83, 19);
            this.tbCodigoEmpresa.Name = "tbCodigoEmpresa";
            this.tbCodigoEmpresa.Size = new System.Drawing.Size(169, 20);
            this.tbCodigoEmpresa.TabIndex = 14;
            this.tbCodigoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaMayuscula);
            // 
            // epValida
            // 
            this.epValida.ContainerControl = this;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Enabled = false;
            this.btnHabilitar.Image = global::asistencia.Properties.Resources.editar32;
            this.btnHabilitar.Location = new System.Drawing.Point(249, 11);
            this.btnHabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(98, 29);
            this.btnHabilitar.TabIndex = 54;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(210, 11);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 29);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbHabilitado
            // 
            this.lbHabilitado.AutoSize = true;
            this.lbHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHabilitado.ForeColor = System.Drawing.Color.White;
            this.lbHabilitado.Location = new System.Drawing.Point(356, 17);
            this.lbHabilitado.Name = "lbHabilitado";
            this.lbHabilitado.Size = new System.Drawing.Size(193, 20);
            this.lbHabilitado.TabIndex = 55;
            this.lbHabilitado.Text = "DATOS DEL EMPLEADO";
            this.lbHabilitado.Click += new System.EventHandler(this.lbHabilitado_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Enabled = false;
            this.btnEstado.Image = global::asistencia.Properties.Resources.empleado;
            this.btnEstado.Location = new System.Drawing.Point(752, 8);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(120, 34);
            this.btnEstado.TabIndex = 56;
            this.btnEstado.Text = "Estado Empleado";
            this.btnEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // frmPersonal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 444);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.lbHabilitado);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.gbContrato);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DEL EMPLEADO";
            this.Load += new System.EventHandler(this.frmPersonal1_Load);
            this.pBotones.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbContrato.ResumeLayout(false);
            this.gbContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pBotones;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox gbContrato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRemuneracion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCelularEmpresa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTelefonoEmpresa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEmailEmpresa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbCodigoEmpresa;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbProfesion;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAreasTrabajo;
        private System.Windows.Forms.ComboBox cbModalidadContrato;
        private System.Windows.Forms.ComboBox cbCargos;
        private System.Windows.Forms.ComboBox cbAgencia;
        private System.Windows.Forms.ComboBox cbHorarios;
        private System.Windows.Forms.OpenFileDialog ofd_CargarImagen;
        private System.Windows.Forms.ErrorProvider epValida;
        public System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Label lbHabilitado;
        public System.Windows.Forms.Button btnEstado;
    }
}