namespace asistencia
{
    partial class frmCiudades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudades));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUbicacionActual = new System.Windows.Forms.Label();
            this.tvPaisesDptos = new System.Windows.Forms.TreeView();
            this.tbNombreUbicacion = new System.Windows.Forms.TextBox();
            this.lbOperacion = new System.Windows.Forms.Label();
            this.cmsMenuOpcionesDist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuOpcionesProv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuOpcionesDptos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuOpcionesPaises = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label61 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.tbNombreAgencia = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.cmsMenuOpcionesDist.SuspendLayout();
            this.cmsMenuOpcionesProv.SuspendLayout();
            this.cmsMenuOpcionesDptos.SuspendLayout();
            this.cmsMenuOpcionesPaises.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.tbNombreAgencia);
            this.groupBox2.Controls.Add(this.btnGuardar2);
            this.groupBox2.Controls.Add(this.btnGuardar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label61);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbUbicacionActual);
            this.groupBox2.Controls.Add(this.tvPaisesDptos);
            this.groupBox2.Controls.Add(this.tbNombreUbicacion);
            this.groupBox2.Controls.Add(this.lbOperacion);
            this.groupBox2.Location = new System.Drawing.Point(5, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 265);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un Pais, Departamento, Provincia o Distrito  ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(368, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "UBICACION:";
            // 
            // lbUbicacionActual
            // 
            this.lbUbicacionActual.AutoSize = true;
            this.lbUbicacionActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbicacionActual.ForeColor = System.Drawing.Color.DimGray;
            this.lbUbicacionActual.Location = new System.Drawing.Point(368, 99);
            this.lbUbicacionActual.Name = "lbUbicacionActual";
            this.lbUbicacionActual.Size = new System.Drawing.Size(286, 13);
            this.lbUbicacionActual.TabIndex = 3;
            this.lbUbicacionActual.Text = "PAIS / DEPARTAMENTO / PROVINCIA / DISTRITO";
            // 
            // tvPaisesDptos
            // 
            this.tvPaisesDptos.BackColor = System.Drawing.Color.White;
            this.tvPaisesDptos.ForeColor = System.Drawing.Color.Black;
            this.tvPaisesDptos.Location = new System.Drawing.Point(5, 21);
            this.tvPaisesDptos.Name = "tvPaisesDptos";
            this.tvPaisesDptos.PathSeparator = "/";
            this.tvPaisesDptos.Size = new System.Drawing.Size(357, 234);
            this.tvPaisesDptos.TabIndex = 5;
            this.tvPaisesDptos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPaisesDptos_AfterSelect);
            this.tvPaisesDptos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvPaisesDptos_MouseUp);
            // 
            // tbNombreUbicacion
            // 
            this.tbNombreUbicacion.BackColor = System.Drawing.Color.White;
            this.tbNombreUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreUbicacion.Location = new System.Drawing.Point(524, 116);
            this.tbNombreUbicacion.Name = "tbNombreUbicacion";
            this.tbNombreUbicacion.Size = new System.Drawing.Size(177, 20);
            this.tbNombreUbicacion.TabIndex = 3;
            this.tbNombreUbicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreUbicacion_KeyPress);
            // 
            // lbOperacion
            // 
            this.lbOperacion.AutoSize = true;
            this.lbOperacion.ForeColor = System.Drawing.Color.DimGray;
            this.lbOperacion.Location = new System.Drawing.Point(368, 121);
            this.lbOperacion.Name = "lbOperacion";
            this.lbOperacion.Size = new System.Drawing.Size(150, 13);
            this.lbOperacion.TabIndex = 17;
            this.lbOperacion.Text = "Añadir Elemento de Ubicación";
            // 
            // cmsMenuOpcionesDist
            // 
            this.cmsMenuOpcionesDist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.cmsMenuOpcionesDist.Name = "cmsMenuOpcionesPaises";
            this.cmsMenuOpcionesDist.Size = new System.Drawing.Size(181, 48);
            this.cmsMenuOpcionesDist.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMenuOpcionesDist_ItemClicked);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = global::asistencia.Properties.Resources.edit_button;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "EDITAR DISTRITO";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::asistencia.Properties.Resources.delete;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem12.Text = "ELIMINAR DISTRITO";
            // 
            // cmsMenuOpcionesProv
            // 
            this.cmsMenuOpcionesProv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.cmsMenuOpcionesProv.Name = "cmsMenuOpcionesPaises";
            this.cmsMenuOpcionesProv.Size = new System.Drawing.Size(192, 70);
            this.cmsMenuOpcionesProv.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMenuOpcionesProv_ItemClicked);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::asistencia.Properties.Resources.Fairytale_button_add;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem7.Text = "AGREGAR DISTRITOS";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = global::asistencia.Properties.Resources.edit_button;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem8.Text = "EDITAR PROVINCIA";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = global::asistencia.Properties.Resources.delete;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem9.Text = "ELIMINAR PROVINCIA";
            // 
            // cmsMenuOpcionesDptos
            // 
            this.cmsMenuOpcionesDptos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.cmsMenuOpcionesDptos.Name = "cmsMenuOpcionesPaises";
            this.cmsMenuOpcionesDptos.Size = new System.Drawing.Size(224, 70);
            this.cmsMenuOpcionesDptos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMenuOpcionesDptos_ItemClicked);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::asistencia.Properties.Resources.Fairytale_button_add;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem4.Text = "AGREGAR PROVINCIAS";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::asistencia.Properties.Resources.edit_button;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem5.Text = "EDITAR DEPARTAMENTO";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::asistencia.Properties.Resources.delete;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem6.Text = "ELIMINAR DEPARTAMENTO";
            // 
            // cmsMenuOpcionesPaises
            // 
            this.cmsMenuOpcionesPaises.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1});
            this.cmsMenuOpcionesPaises.Name = "cmsMenuOpcionesPaises";
            this.cmsMenuOpcionesPaises.Size = new System.Drawing.Size(229, 70);
            this.cmsMenuOpcionesPaises.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMenuOpcionesPaises_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::asistencia.Properties.Resources.Fairytale_button_add;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItem2.Text = "AGREGAR DEPARTAMENTOS";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::asistencia.Properties.Resources.edit_button;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItem3.Text = "EDITAR PAIS";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::asistencia.Properties.Resources.delete;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItem1.Text = "ELIMINAR PAIS";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.ForeColor = System.Drawing.Color.DimGray;
            this.label61.Location = new System.Drawing.Point(368, 44);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(67, 13);
            this.label61.TabIndex = 29;
            this.label61.Text = "Nombre Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(368, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "AÑADIR PAICES";
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Enabled = false;
            this.btnGuardar1.Image = global::asistencia.Properties.Resources.siguiente_icono_5491_32;
            this.btnGuardar1.Location = new System.Drawing.Point(705, 37);
            this.btnGuardar1.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(70, 27);
            this.btnGuardar1.TabIndex = 2;
            this.btnGuardar1.Text = "Añadir";
            this.btnGuardar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Enabled = false;
            this.btnGuardar2.Image = global::asistencia.Properties.Resources.siguiente_icono_5491_32;
            this.btnGuardar2.Location = new System.Drawing.Point(705, 111);
            this.btnGuardar2.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(70, 27);
            this.btnGuardar2.TabIndex = 4;
            this.btnGuardar2.Text = "Añadir";
            this.btnGuardar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar2.UseVisualStyleBackColor = true;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // tbNombreAgencia
            // 
            this.tbNombreAgencia.BackColor = System.Drawing.Color.White;
            this.tbNombreAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombreAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreAgencia.Location = new System.Drawing.Point(441, 40);
            this.tbNombreAgencia.Name = "tbNombreAgencia";
            this.tbNombreAgencia.Size = new System.Drawing.Size(260, 20);
            this.tbNombreAgencia.TabIndex = 31;
            this.tbNombreAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreAgencia_KeyPress);
            // 
            // frmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCiudades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACION DE PAIS/DEPARTAMENTO/PROVINCIA/DISTRITO";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmsMenuOpcionesDist.ResumeLayout(false);
            this.cmsMenuOpcionesProv.ResumeLayout(false);
            this.cmsMenuOpcionesDptos.ResumeLayout(false);
            this.cmsMenuOpcionesPaises.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUbicacionActual;
        private System.Windows.Forms.TreeView tvPaisesDptos;
        private System.Windows.Forms.TextBox tbNombreUbicacion;
        private System.Windows.Forms.Label lbOperacion;
        private System.Windows.Forms.ContextMenuStrip cmsMenuOpcionesDist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ContextMenuStrip cmsMenuOpcionesProv;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ContextMenuStrip cmsMenuOpcionesDptos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ContextMenuStrip cmsMenuOpcionesPaises;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label61;
        public System.Windows.Forms.Button btnGuardar1;
        public System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.TextBox tbNombreAgencia;
    }
}