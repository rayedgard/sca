namespace asistencia
{
    partial class frmHabilitaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabilitaPersonal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDeshabilitado = new System.Windows.Forms.RadioButton();
            this.rbtHabilitadoManual = new System.Windows.Forms.RadioButton();
            this.rbtHabilitadoBiometrico = new System.Windows.Forms.RadioButton();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDeshabilitado);
            this.groupBox1.Controls.Add(this.rbtHabilitadoManual);
            this.groupBox1.Controls.Add(this.rbtHabilitadoBiometrico);
            this.groupBox1.Location = new System.Drawing.Point(2, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edicion de estado del personal";
            // 
            // rbtDeshabilitado
            // 
            this.rbtDeshabilitado.AutoSize = true;
            this.rbtDeshabilitado.Location = new System.Drawing.Point(33, 65);
            this.rbtDeshabilitado.Name = "rbtDeshabilitado";
            this.rbtDeshabilitado.Size = new System.Drawing.Size(269, 17);
            this.rbtDeshabilitado.TabIndex = 2;
            this.rbtDeshabilitado.TabStop = true;
            this.rbtDeshabilitado.Text = "Personal DESHABILITADO, no labora en el periodo";
            this.rbtDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // rbtHabilitadoManual
            // 
            this.rbtHabilitadoManual.AutoSize = true;
            this.rbtHabilitadoManual.Location = new System.Drawing.Point(33, 42);
            this.rbtHabilitadoManual.Name = "rbtHabilitadoManual";
            this.rbtHabilitadoManual.Size = new System.Drawing.Size(228, 17);
            this.rbtHabilitadoManual.TabIndex = 1;
            this.rbtHabilitadoManual.TabStop = true;
            this.rbtHabilitadoManual.Text = "Personal HABILITADO con registro manual";
            this.rbtHabilitadoManual.UseVisualStyleBackColor = true;
            // 
            // rbtHabilitadoBiometrico
            // 
            this.rbtHabilitadoBiometrico.AutoSize = true;
            this.rbtHabilitadoBiometrico.Location = new System.Drawing.Point(33, 19);
            this.rbtHabilitadoBiometrico.Name = "rbtHabilitadoBiometrico";
            this.rbtHabilitadoBiometrico.Size = new System.Drawing.Size(242, 17);
            this.rbtHabilitadoBiometrico.TabIndex = 0;
            this.rbtHabilitadoBiometrico.TabStop = true;
            this.rbtHabilitadoBiometrico.Text = "Personal HABILITADO con registro biometrico";
            this.rbtHabilitadoBiometrico.UseVisualStyleBackColor = true;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbDNI.Location = new System.Drawing.Point(12, 9);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 1;
            this.lbDNI.Text = "DNI";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbNombre.Location = new System.Drawing.Point(12, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarEstado.Image")));
            this.btnCambiarEstado.Location = new System.Drawing.Point(254, 5);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(98, 42);
            this.btnCambiarEstado.TabIndex = 31;
            this.btnCambiarEstado.Text = "Cambiar Estaro";
            this.btnCambiarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // frmHabilitaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 161);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 199);
            this.MinimizeBox = false;
            this.Name = "frmHabilitaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADO DEL PERSONAL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDeshabilitado;
        private System.Windows.Forms.RadioButton rbtHabilitadoManual;
        private System.Windows.Forms.RadioButton rbtHabilitadoBiometrico;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbNombre;
        public System.Windows.Forms.Button btnCambiarEstado;
    }
}