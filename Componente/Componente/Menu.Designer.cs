namespace Componente
{
    partial class Menu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.general = new System.Windows.Forms.Panel();
            this.minwindow = new System.Windows.Forms.Button();
            this.maxiwindow = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.general.SuspendLayout();
            this.SuspendLayout();
            // 
            // general
            // 
            this.general.Controls.Add(this.minwindow);
            this.general.Controls.Add(this.maxiwindow);
            this.general.Controls.Add(this.close);
            this.general.Dock = System.Windows.Forms.DockStyle.Right;
            this.general.Location = new System.Drawing.Point(16, 0);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(84, 50);
            this.general.TabIndex = 3;
            // 
            // minwindow
            // 
            this.minwindow.AutoSize = true;
            this.minwindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minwindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minwindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.minwindow.FlatAppearance.BorderSize = 0;
            this.minwindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minwindow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minwindow.ForeColor = System.Drawing.Color.White;
            this.minwindow.Image = ((System.Drawing.Image)(resources.GetObject("minwindow.Image")));
            this.minwindow.Location = new System.Drawing.Point(0, 0);
            this.minwindow.Name = "minwindow";
            this.minwindow.Size = new System.Drawing.Size(28, 50);
            this.minwindow.TabIndex = 0;
            this.minwindow.UseVisualStyleBackColor = true;
            this.minwindow.Click += new System.EventHandler(this.minwindow_Click);
            // 
            // maxiwindow
            // 
            this.maxiwindow.AutoSize = true;
            this.maxiwindow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.maxiwindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maxiwindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxiwindow.FlatAppearance.BorderSize = 0;
            this.maxiwindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxiwindow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxiwindow.ForeColor = System.Drawing.Color.White;
            this.maxiwindow.Image = ((System.Drawing.Image)(resources.GetObject("maxiwindow.Image")));
            this.maxiwindow.Location = new System.Drawing.Point(28, 0);
            this.maxiwindow.Name = "maxiwindow";
            this.maxiwindow.Size = new System.Drawing.Size(28, 50);
            this.maxiwindow.TabIndex = 1;
            this.maxiwindow.UseVisualStyleBackColor = true;
            this.maxiwindow.Click += new System.EventHandler(this.maxiwindow_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(56, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 50);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.general);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(100, 50);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel general;
        private System.Windows.Forms.Button minwindow;
        private System.Windows.Forms.Button maxiwindow;
        private System.Windows.Forms.Button close;
    }
}
