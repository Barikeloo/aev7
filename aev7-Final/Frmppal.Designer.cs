namespace EjemploFechasHoras
{
    partial class Frmppal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblNif = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.lblSituacion = new System.Windows.Forms.Label();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbFechaHora = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.ptbFlorida = new System.Windows.Forms.PictureBox();
            this.grpbPermanencias = new System.Windows.Forms.GroupBox();
            this.btnVerPermanencia = new System.Windows.Forms.Button();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.btnSalirPermanencias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            this.gpbFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlorida)).BeginInit();
            this.grpbPermanencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(64, 46);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(70, 33);
            this.lblNif.TabIndex = 3;
            this.lblNif.Text = "NIF:";
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(173, 41);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(396, 46);
            this.txtNif.TabIndex = 4;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Location = new System.Drawing.Point(71, 95);
            this.dgvFichajes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.RowHeadersWidth = 51;
            this.dgvFichajes.Size = new System.Drawing.Size(939, 273);
            this.dgvFichajes.TabIndex = 7;
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacion.Location = new System.Drawing.Point(67, 91);
            this.lblSituacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(0, 20);
            this.lblSituacion.TabIndex = 8;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMantenimiento.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(1091, 546);
            this.btnMantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(228, 68);
            this.btnMantenimiento.TabIndex = 12;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPermanencia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(1091, 453);
            this.btnPermanencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(228, 68);
            this.btnPermanencia.TabIndex = 13;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPresencia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(1091, 354);
            this.btnPresencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(228, 68);
            this.btnPresencia.TabIndex = 14;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSalida.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(1091, 256);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(228, 68);
            this.btnSalida.TabIndex = 15;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEntrada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(1091, 162);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(228, 68);
            this.btnEntrada.TabIndex = 16;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click_1);
            // 
            // gpbFechaHora
            // 
            this.gpbFechaHora.BackColor = System.Drawing.Color.Bisque;
            this.gpbFechaHora.Controls.Add(this.lblHora);
            this.gpbFechaHora.Controls.Add(this.lblFecha);
            this.gpbFechaHora.Location = new System.Drawing.Point(1073, 30);
            this.gpbFechaHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFechaHora.Name = "gpbFechaHora";
            this.gpbFechaHora.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFechaHora.Size = new System.Drawing.Size(259, 112);
            this.gpbFechaHora.TabIndex = 17;
            this.gpbFechaHora.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(29, 68);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(69, 29);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(29, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 29);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(71, 374);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(939, 241);
            this.txtMessage.TabIndex = 19;
            // 
            // ptbFlorida
            // 
            this.ptbFlorida.Image = global::EjemploFechasHoras.Properties.Resources.floridafoto1;
            this.ptbFlorida.InitialImage = global::EjemploFechasHoras.Properties.Resources.floridafoto1;
            this.ptbFlorida.Location = new System.Drawing.Point(69, 191);
            this.ptbFlorida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbFlorida.Name = "ptbFlorida";
            this.ptbFlorida.Size = new System.Drawing.Size(941, 383);
            this.ptbFlorida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFlorida.TabIndex = 18;
            this.ptbFlorida.TabStop = false;
            // 
            // grpbPermanencias
            // 
            this.grpbPermanencias.Controls.Add(this.btnSalirPermanencias);
            this.grpbPermanencias.Controls.Add(this.btnVerPermanencia);
            this.grpbPermanencias.Controls.Add(this.dtpFecha2);
            this.grpbPermanencias.Controls.Add(this.dtpFecha1);
            this.grpbPermanencias.Location = new System.Drawing.Point(102, 396);
            this.grpbPermanencias.Name = "grpbPermanencias";
            this.grpbPermanencias.Size = new System.Drawing.Size(867, 165);
            this.grpbPermanencias.TabIndex = 20;
            this.grpbPermanencias.TabStop = false;
            this.grpbPermanencias.Text = "Permanencias";
            // 
            // btnVerPermanencia
            // 
            this.btnVerPermanencia.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnVerPermanencia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPermanencia.Location = new System.Drawing.Point(67, 108);
            this.btnVerPermanencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerPermanencia.Name = "btnVerPermanencia";
            this.btnVerPermanencia.Size = new System.Drawing.Size(365, 46);
            this.btnVerPermanencia.TabIndex = 21;
            this.btnVerPermanencia.Text = "Ver Fechas Seleccionadas";
            this.btnVerPermanencia.UseVisualStyleBackColor = false;
            this.btnVerPermanencia.Click += new System.EventHandler(this.btnVerPermanencia_Click);
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Location = new System.Drawing.Point(191, 61);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(475, 34);
            this.dtpFecha2.TabIndex = 1;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Location = new System.Drawing.Point(191, 21);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(475, 34);
            this.dtpFecha1.TabIndex = 0;
            // 
            // btnSalirPermanencias
            // 
            this.btnSalirPermanencias.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSalirPermanencias.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPermanencias.Location = new System.Drawing.Point(438, 108);
            this.btnSalirPermanencias.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirPermanencias.Name = "btnSalirPermanencias";
            this.btnSalirPermanencias.Size = new System.Drawing.Size(362, 46);
            this.btnSalirPermanencias.TabIndex = 22;
            this.btnSalirPermanencias.Text = "Salir";
            this.btnSalirPermanencias.UseVisualStyleBackColor = false;
            this.btnSalirPermanencias.Click += new System.EventHandler(this.btnSalirPermanencias_Click);
            // 
            // Frmppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 658);
            this.Controls.Add(this.grpbPermanencias);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.ptbFlorida);
            this.Controls.Add(this.gpbFechaHora);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.lblSituacion);
            this.Controls.Add(this.dgvFichajes);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.lblNif);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmppal";
            this.Text = "Ejemplo de tratamiento de tipos DATE y DATETIME de MySql desde C#";
            this.Load += new System.EventHandler(this.Frmppal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            this.gpbFechaHora.ResumeLayout(false);
            this.gpbFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlorida)).EndInit();
            this.grpbPermanencias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.DataGridView dgvFichajes;
        private System.Windows.Forms.Label lblSituacion;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnEntrada;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpbFechaHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox ptbFlorida;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox grpbPermanencias;
        private System.Windows.Forms.Button btnVerPermanencia;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Button btnSalirPermanencias;
    }
}

