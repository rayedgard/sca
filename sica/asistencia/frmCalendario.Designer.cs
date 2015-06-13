namespace asistencia
{
    partial class frmCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.calend_CalendarioDiasFeriados = new ClaseCalendario.Calendario();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(340, 460);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 42);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // calend_CalendarioDiasFeriados
            // 
            this.calend_CalendarioDiasFeriados.AutoSize = true;
            this.calend_CalendarioDiasFeriados.BackColor = System.Drawing.Color.DodgerBlue;
            this.calend_CalendarioDiasFeriados.BackColorMonthYearValue = System.Drawing.Color.WhiteSmoke;
            this.calend_CalendarioDiasFeriados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calend_CalendarioDiasFeriados.ColorTextoDia = System.Drawing.SystemColors.ControlDark;
            this.calend_CalendarioDiasFeriados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calend_CalendarioDiasFeriados.DiasMesConOpciones = new string[] {
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        ""};
            this.calend_CalendarioDiasFeriados.FechaActualHoy = new System.DateTime(((long)(0)));
            this.calend_CalendarioDiasFeriados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calend_CalendarioDiasFeriados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calend_CalendarioDiasFeriados.ListaOpcionesFeriados = ((System.Collections.ArrayList)(resources.GetObject("calend_CalendarioDiasFeriados.ListaOpcionesFeriados")));
            this.calend_CalendarioDiasFeriados.Location = new System.Drawing.Point(11, 39);
            this.calend_CalendarioDiasFeriados.MaximumSize = new System.Drawing.Size(900, 900);
            this.calend_CalendarioDiasFeriados.MesAnioFecha = new int[] {
        3,
        2011};
            this.calend_CalendarioDiasFeriados.MinimumSize = new System.Drawing.Size(423, 415);
            this.calend_CalendarioDiasFeriados.Name = "calend_CalendarioDiasFeriados";
            this.calend_CalendarioDiasFeriados.Size = new System.Drawing.Size(427, 416);
            this.calend_CalendarioDiasFeriados.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(10, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(299, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Debe guardar o modificar los días no laborables por cada mes";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(10, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(254, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Click derecho para establecer los días no laborables";
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 506);
            this.Controls.Add(this.calend_CalendarioDiasFeriados);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÍAS NO LABORABLES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.ServiceProcess.ServiceController serviceController1;
        private ClaseCalendario.Calendario calend_CalendarioDiasFeriados;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
    }
}