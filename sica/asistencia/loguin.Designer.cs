namespace asistencia
{
    partial class loguin
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
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbentrar = new System.Windows.Forms.PictureBox();
            this.lbCambiarcuenta = new System.Windows.Forms.Label();
            this.lbOlvide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbItdecsa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbentrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItdecsa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(236, 133);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(198, 26);
            this.tbUsuario.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(236, 165);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = 'o';
            this.tbPass.Size = new System.Drawing.Size(198, 26);
            this.tbPass.TabIndex = 1;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbSalir.BackgroundImage = global::asistencia.Properties.Resources.salir;
            this.pbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Location = new System.Drawing.Point(455, 53);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(39, 36);
            this.pbSalir.TabIndex = 2;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pbentrar
            // 
            this.pbentrar.BackColor = System.Drawing.Color.Transparent;
            this.pbentrar.BackgroundImage = global::asistencia.Properties.Resources.Vista__151_;
            this.pbentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbentrar.Location = new System.Drawing.Point(378, 197);
            this.pbentrar.Name = "pbentrar";
            this.pbentrar.Size = new System.Drawing.Size(55, 43);
            this.pbentrar.TabIndex = 3;
            this.pbentrar.TabStop = false;
            this.pbentrar.Click += new System.EventHandler(this.pbentrar_Click);
            // 
            // lbCambiarcuenta
            // 
            this.lbCambiarcuenta.AutoSize = true;
            this.lbCambiarcuenta.BackColor = System.Drawing.Color.Transparent;
            this.lbCambiarcuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCambiarcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambiarcuenta.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbCambiarcuenta.Location = new System.Drawing.Point(40, 256);
            this.lbCambiarcuenta.Name = "lbCambiarcuenta";
            this.lbCambiarcuenta.Size = new System.Drawing.Size(125, 15);
            this.lbCambiarcuenta.TabIndex = 4;
            this.lbCambiarcuenta.Text = "CAMBIAR CUENTA";
            // 
            // lbOlvide
            // 
            this.lbOlvide.AutoSize = true;
            this.lbOlvide.BackColor = System.Drawing.Color.Transparent;
            this.lbOlvide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOlvide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOlvide.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbOlvide.Location = new System.Drawing.Point(318, 256);
            this.lbOlvide.Name = "lbOlvide";
            this.lbOlvide.Size = new System.Drawing.Size(137, 15);
            this.lbOlvide.TabIndex = 5;
            this.lbOlvide.Text = "OLVIDE PASSWORD";
            this.lbOlvide.Click += new System.EventHandler(this.lbOlvide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(202, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATOS RED";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbItdecsa
            // 
            this.pbItdecsa.BackColor = System.Drawing.Color.Transparent;
            this.pbItdecsa.BackgroundImage = global::asistencia.Properties.Resources.Vista__22_;
            this.pbItdecsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbItdecsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItdecsa.Location = new System.Drawing.Point(455, 274);
            this.pbItdecsa.Name = "pbItdecsa";
            this.pbItdecsa.Size = new System.Drawing.Size(39, 36);
            this.pbItdecsa.TabIndex = 7;
            this.pbItdecsa.TabStop = false;
            // 
            // loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::asistencia.Properties.Resources.loguin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(493, 310);
            this.Controls.Add(this.pbItdecsa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOlvide);
            this.Controls.Add(this.lbCambiarcuenta);
            this.Controls.Add(this.pbentrar);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loguin";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdministrador_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbentrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItdecsa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbentrar;
        private System.Windows.Forms.Label lbCambiarcuenta;
        private System.Windows.Forms.Label lbOlvide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbItdecsa;
    }
}