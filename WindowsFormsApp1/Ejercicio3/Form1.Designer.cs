namespace Ejercicio3
{
    partial class Form1
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
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbCuenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTiempo
            // 
            this.tbTiempo.Location = new System.Drawing.Point(229, 132);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.Size = new System.Drawing.Size(100, 26);
            this.tbTiempo.TabIndex = 0;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(140, 251);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(124, 46);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiempo";
            // 
            // LbCuenta
            // 
            this.LbCuenta.AutoSize = true;
            this.LbCuenta.Location = new System.Drawing.Point(483, 138);
            this.LbCuenta.Name = "LbCuenta";
            this.LbCuenta.Size = new System.Drawing.Size(27, 20);
            this.LbCuenta.TabIndex = 4;
            this.LbCuenta.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temporizador";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(298, 254);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(124, 43);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Detener";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.tbTiempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTiempo;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btStop;
    }
}

