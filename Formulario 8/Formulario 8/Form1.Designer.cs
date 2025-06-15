namespace Formulario_8
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtOracion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(237, 114);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(250, 24);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Cantidad de Palabras: 0";
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(272, 254);
            this.btnContar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(147, 66);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar Palabras";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtOracion
            // 
            this.txtOracion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOracion.Location = new System.Drawing.Point(181, 152);
            this.txtOracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOracion.Multiline = true;
            this.txtOracion.Name = "txtOracion";
            this.txtOracion.Size = new System.Drawing.Size(337, 74);
            this.txtOracion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txtOracion);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.lblResultado);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtOracion;
    }
}

