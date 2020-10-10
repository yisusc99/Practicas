namespace P4
{
    partial class Conversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.conv = new System.Windows.Forms.Button();
            this.td = new System.Windows.Forms.TextBox();
            this.tmx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkcon = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conv
            // 
            this.conv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(120)))), ((int)(((byte)(194)))));
            this.conv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.conv.Location = new System.Drawing.Point(370, 96);
            this.conv.Name = "conv";
            this.conv.Size = new System.Drawing.Size(119, 41);
            this.conv.TabIndex = 1;
            this.conv.Text = "Convertir";
            this.conv.UseVisualStyleBackColor = false;
            this.conv.Click += new System.EventHandler(this.button2_Click);
            // 
            // td
            // 
            this.td.Location = new System.Drawing.Point(35, 96);
            this.td.Name = "td";
            this.td.Size = new System.Drawing.Size(189, 23);
            this.td.TabIndex = 2;
            // 
            // tmx
            // 
            this.tmx.Location = new System.Drawing.Point(35, 151);
            this.tmx.Name = "tmx";
            this.tmx.Size = new System.Drawing.Size(188, 23);
            this.tmx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Moneda en dlls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moneda en MXN";
            // 
            // checkcon
            // 
            this.checkcon.AutoSize = true;
            this.checkcon.Location = new System.Drawing.Point(239, 129);
            this.checkcon.Name = "checkcon";
            this.checkcon.Size = new System.Drawing.Size(101, 19);
            this.checkcon.TabIndex = 7;
            this.checkcon.Text = "De Dlls a MXN";
            this.checkcon.UseVisualStyleBackColor = true;
            this.checkcon.CheckedChanged += new System.EventHandler(this.checkcon_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "Calculadora";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItem1.Text = "Calculadora";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(511, 221);
            this.Controls.Add(this.checkcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmx);
            this.Controls.Add(this.td);
            this.Controls.Add(this.conv);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Conversor";
            this.Text = "Cotizador";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button conv;
        private System.Windows.Forms.TextBox td;
        private System.Windows.Forms.TextBox tmx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

