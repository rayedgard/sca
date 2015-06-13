namespace asistencia
{
    partial class frmNuevoToletancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoToletancia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIntervalo3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIntervalo2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTolerancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIntervalo1 = new System.Windows.Forms.TextBox();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbIntervalo3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbIntervalo2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTolerancia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbIntervalo1);
            this.groupBox1.Controls.Add(this.pbGuardar);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignación de tolerancia y tardanza de Ingreso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(1, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(376, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Despues de transcurrido los intérvalos se considera, FALTA POR TARDANZA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(248, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Minutos";
            // 
            // tbIntervalo3
            // 
            this.tbIntervalo3.BackColor = System.Drawing.Color.White;
            this.tbIntervalo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIntervalo3.Location = new System.Drawing.Point(199, 96);
            this.tbIntervalo3.Name = "tbIntervalo3";
            this.tbIntervalo3.Size = new System.Drawing.Size(42, 20);
            this.tbIntervalo3.TabIndex = 32;
            this.tbIntervalo3.Text = "10";
            this.tbIntervalo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumero);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "3° intérvalo, despues de 2° intervalo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(183, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(248, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Minutos";
            // 
            // tbIntervalo2
            // 
            this.tbIntervalo2.BackColor = System.Drawing.Color.White;
            this.tbIntervalo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIntervalo2.Location = new System.Drawing.Point(199, 73);
            this.tbIntervalo2.Name = "tbIntervalo2";
            this.tbIntervalo2.Size = new System.Drawing.Size(42, 20);
            this.tbIntervalo2.TabIndex = 28;
            this.tbIntervalo2.Text = "10";
            this.tbIntervalo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumero);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "2° intérvalo, despues de 1° intervalo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(183, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(248, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Minutos";
            // 
            // tbTolerancia
            // 
            this.tbTolerancia.BackColor = System.Drawing.Color.White;
            this.tbTolerancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTolerancia.Location = new System.Drawing.Point(199, 26);
            this.tbTolerancia.Name = "tbTolerancia";
            this.tbTolerancia.Size = new System.Drawing.Size(42, 20);
            this.tbTolerancia.TabIndex = 24;
            this.tbTolerancia.Text = "10";
            this.tbTolerancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumero);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(247, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Minutos";
            // 
            // tbIntervalo1
            // 
            this.tbIntervalo1.BackColor = System.Drawing.Color.White;
            this.tbIntervalo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIntervalo1.Location = new System.Drawing.Point(199, 50);
            this.tbIntervalo1.Name = "tbIntervalo1";
            this.tbIntervalo1.Size = new System.Drawing.Size(42, 20);
            this.tbIntervalo1.TabIndex = 22;
            this.tbIntervalo1.Text = "10";
            this.tbIntervalo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNumero);
            // 
            // pbGuardar
            // 
            this.pbGuardar.BackgroundImage = global::asistencia.Properties.Resources._131;
            this.pbGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGuardar.Location = new System.Drawing.Point(314, 25);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(45, 40);
            this.pbGuardar.TabIndex = 18;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.pbGuardar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Firebrick;
            this.label16.Location = new System.Drawing.Point(306, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "GUARDAR";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(6, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "1° intérvalo, despues de tolerancia";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(183, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(183, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(99, 246);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = ":";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.DimGray;
            this.label27.Location = new System.Drawing.Point(6, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Tolerancia";
            // 
            // frmNuevoToletancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(393, 157);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 195);
            this.MinimizeBox = false;
            this.Name = "frmNuevoToletancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACIÓN DE TIEMPOS DE TOLERANCIA Y TARDANZA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIntervalo1;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTolerancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIntervalo3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIntervalo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}