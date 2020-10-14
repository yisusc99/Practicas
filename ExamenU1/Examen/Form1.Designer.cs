namespace Examen
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
            this.Generar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.Color.White;
            this.Generar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generar.ForeColor = System.Drawing.Color.Black;
            this.Generar.Location = new System.Drawing.Point(64, 168);
            this.Generar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(112, 57);
            this.Generar.TabIndex = 0;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.White;
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Borrar.ForeColor = System.Drawing.Color.Black;
            this.Borrar.Location = new System.Drawing.Point(217, 168);
            this.Borrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(121, 57);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // numero
            // 
            this.numero.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(64, 23);
            this.numero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numero.Multiline = true;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(274, 112);
            this.numero.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(145)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(393, 257);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Generar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Generador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.TextBox numero;
    }
}

