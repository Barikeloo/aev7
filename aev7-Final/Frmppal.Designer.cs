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
            this.ptbFlorida = new System.Windows.Forms.PictureBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            this.gpbFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlorida)).BeginInit();
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
            this.lblNif.Location = new System.Drawing.Point(48, 37);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(53, 26);
            this.lblNif.TabIndex = 3;
            this.lblNif.Text = "NIF:";
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(130, 33);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(298, 38);
            this.txtNif.TabIndex = 4;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.Location = new System.Drawing.Point(63, 173);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.RowHeadersWidth = 51;
            this.dgvFichajes.Size = new System.Drawing.Size(664, 250);
            this.dgvFichajes.TabIndex = 7;
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacion.Location = new System.Drawing.Point(60, 141);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(123, 16);
            this.lblSituacion.TabIndex = 8;
            this.lblSituacion.Text = "Estado de Fichajes";
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnMantenimiento.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(818, 444);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(171, 55);
            this.btnMantenimiento.TabIndex = 12;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPermanencia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(818, 368);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(171, 55);
            this.btnPermanencia.TabIndex = 13;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPresencia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(818, 288);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(171, 55);
            this.btnPresencia.TabIndex = 14;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnSalida.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(818, 208);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(171, 55);
            this.btnSalida.TabIndex = 15;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEntrada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(818, 132);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(171, 55);
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
            this.gpbFechaHora.Location = new System.Drawing.Point(805, 24);
            this.gpbFechaHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbFechaHora.Name = "gpbFechaHora";
            this.gpbFechaHora.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbFechaHora.Size = new System.Drawing.Size(194, 91);
            this.gpbFechaHora.TabIndex = 17;
            this.gpbFechaHora.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(22, 55);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 24);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(22, 15);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // ptbFlorida
            // 
            this.ptbFlorida.Image = global::EjemploFechasHoras.Properties.Resources.floridafoto1;
            this.ptbFlorida.InitialImage = global::EjemploFechasHoras.Properties.Resources.floridafoto1;
            this.ptbFlorida.Location = new System.Drawing.Point(52, 119);
            this.ptbFlorida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbFlorida.Name = "ptbFlorida";
            this.ptbFlorida.Size = new System.Drawing.Size(706, 348);
            this.ptbFlorida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFlorida.TabIndex = 18;
            this.ptbFlorida.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(53, 84);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(705, 383);
            this.txtMessage.TabIndex = 19;
            // 
            // Frmppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 535);
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
            this.Name = "Frmppal";
            this.Text = "Ejemplo de tratamiento de tipos DATE y DATETIME de MySql desde C#";
            this.Load += new System.EventHandler(this.Frmppal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            this.gpbFechaHora.ResumeLayout(false);
            this.gpbFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlorida)).EndInit();
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
    }
}

