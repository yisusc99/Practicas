namespace PControlesForm
{
    partial class Comp
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
            this.title = new System.Windows.Forms.Label();
            this.g1 = new System.Windows.Forms.GroupBox();
            this.ram = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c5 = new System.Windows.Forms.CheckBox();
            this.c4 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c1 = new System.Windows.Forms.CheckBox();
            this.g2 = new System.Windows.Forms.GroupBox();
            this.cap2 = new System.Windows.Forms.ComboBox();
            this.cap1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.ComboBox();
            this.d1 = new System.Windows.Forms.ComboBox();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.So = new System.Windows.Forms.ComboBox();
            this.g3 = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.CheckedListBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.g1.SuspendLayout();
            this.g2.SuspendLayout();
            this.g3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(52, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(235, 21);
            this.title.TabIndex = 0;
            this.title.Text = "Selecciona tus componentes";
            // 
            // g1
            // 
            this.g1.Controls.Add(this.label7);
            this.g1.Controls.Add(this.ram);
            this.g1.Controls.Add(this.label2);
            this.g1.Controls.Add(this.label1);
            this.g1.Controls.Add(this.c5);
            this.g1.Controls.Add(this.c4);
            this.g1.Controls.Add(this.c3);
            this.g1.Controls.Add(this.c2);
            this.g1.Controls.Add(this.c1);
            this.g1.ForeColor = System.Drawing.Color.White;
            this.g1.Location = new System.Drawing.Point(57, 69);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(650, 320);
            this.g1.TabIndex = 1;
            this.g1.TabStop = false;
            this.g1.Text = "Procesador y memoria ram";
            // 
            // ram
            // 
            this.ram.FormattingEnabled = true;
            this.ram.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "16"});
            this.ram.Location = new System.Drawing.Point(380, 116);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(121, 29);
            this.ram.TabIndex = 7;
            this.ram.SelectedIndexChanged += new System.EventHandler(this.ram_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Procesador";
            // 
            // c5
            // 
            this.c5.AutoSize = true;
            this.c5.Location = new System.Drawing.Point(64, 242);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(131, 25);
            this.c5.TabIndex = 4;
            this.c5.Text = "AMD Ryzen 7";
            this.c5.UseVisualStyleBackColor = true;
            this.c5.CheckedChanged += new System.EventHandler(this.c5_CheckedChanged);
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(64, 211);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(131, 25);
            this.c4.TabIndex = 3;
            this.c4.Text = "AMD Ryzen 9";
            this.c4.UseVisualStyleBackColor = true;
            this.c4.CheckedChanged += new System.EventHandler(this.c4_CheckedChanged);
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(64, 180);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(170, 25);
            this.c3.TabIndex = 2;
            this.c3.Text = "Intel Core i7 i7-600";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.CheckedChanged += new System.EventHandler(this.c3_CheckedChanged);
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(64, 149);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(170, 25);
            this.c2.TabIndex = 1;
            this.c2.Text = "Intel Core i9 i7-970";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.CheckedChanged += new System.EventHandler(this.c2_CheckedChanged);
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(64, 118);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(155, 25);
            this.c1.TabIndex = 0;
            this.c1.Text = "Intel Core I5 550";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.CheckedChanged += new System.EventHandler(this.c1_CheckedChanged);
            // 
            // g2
            // 
            this.g2.Controls.Add(this.label9);
            this.g2.Controls.Add(this.label8);
            this.g2.Controls.Add(this.cap2);
            this.g2.Controls.Add(this.cap1);
            this.g2.Controls.Add(this.label6);
            this.g2.Controls.Add(this.label5);
            this.g2.Controls.Add(this.label4);
            this.g2.Controls.Add(this.label3);
            this.g2.Controls.Add(this.d2);
            this.g2.Controls.Add(this.d1);
            this.g2.Controls.Add(this.r2);
            this.g2.Controls.Add(this.r1);
            this.g2.Controls.Add(this.So);
            this.g2.ForeColor = System.Drawing.Color.White;
            this.g2.Location = new System.Drawing.Point(57, 397);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(650, 350);
            this.g2.TabIndex = 3;
            this.g2.TabStop = false;
            this.g2.Text = "S.O. y Disco duro";
            // 
            // cap2
            // 
            this.cap2.FormattingEnabled = true;
            this.cap2.Items.AddRange(new object[] {
            "150",
            "250",
            "500",
            "1024",
            "2048"});
            this.cap2.Location = new System.Drawing.Point(487, 240);
            this.cap2.Name = "cap2";
            this.cap2.Size = new System.Drawing.Size(121, 29);
            this.cap2.TabIndex = 12;
            this.cap2.SelectedIndexChanged += new System.EventHandler(this.cap2_SelectedIndexChanged);
            // 
            // cap1
            // 
            this.cap1.Enabled = false;
            this.cap1.FormattingEnabled = true;
            this.cap1.Items.AddRange(new object[] {
            "150",
            "250",
            "500",
            "1024",
            "2048"});
            this.cap1.Location = new System.Drawing.Point(318, 240);
            this.cap1.Name = "cap1";
            this.cap1.Size = new System.Drawing.Size(121, 29);
            this.cap1.TabIndex = 11;
            this.cap1.SelectedIndexChanged += new System.EventHandler(this.cap1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Capacidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selecciona tu disco duro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de discos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sistema operativo";
            // 
            // d2
            // 
            this.d2.Enabled = false;
            this.d2.FormattingEnabled = true;
            this.d2.Items.AddRange(new object[] {
            "Disco duro SATA - Toshiba",
            "SSD - Samsung"});
            this.d2.Location = new System.Drawing.Point(487, 132);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(121, 29);
            this.d2.TabIndex = 5;
            this.d2.SelectedIndexChanged += new System.EventHandler(this.d2_SelectedIndexChanged);
            // 
            // d1
            // 
            this.d1.Enabled = false;
            this.d1.FormattingEnabled = true;
            this.d1.Items.AddRange(new object[] {
            "Disco duro SATA - Toshiba",
            "SSD - Samsung"});
            this.d1.Location = new System.Drawing.Point(318, 132);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(121, 29);
            this.d1.TabIndex = 3;
            this.d1.SelectedIndexChanged += new System.EventHandler(this.d1_SelectedIndexChanged);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(382, 69);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(37, 25);
            this.r2.TabIndex = 2;
            this.r2.TabStop = true;
            this.r2.Text = "2";
            this.r2.UseVisualStyleBackColor = true;
            this.r2.CheckedChanged += new System.EventHandler(this.r2_CheckedChanged);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(318, 69);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(37, 25);
            this.r1.TabIndex = 1;
            this.r1.TabStop = true;
            this.r1.Text = "1";
            this.r1.UseVisualStyleBackColor = true;
            this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // So
            // 
            this.So.FormattingEnabled = true;
            this.So.Items.AddRange(new object[] {
            "Ubuntu 2020",
            "Kali Linux",
            "Windows 7 Pro",
            "Windows 8 Pro",
            "Windows 8.1 Pro",
            "Windows 10 Pro"});
            this.So.Location = new System.Drawing.Point(23, 100);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(150, 29);
            this.So.TabIndex = 0;
            this.So.SelectedIndexChanged += new System.EventHandler(this.So_SelectedIndexChanged);
            // 
            // g3
            // 
            this.g3.Controls.Add(this.list);
            this.g3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.g3.Location = new System.Drawing.Point(57, 753);
            this.g3.Name = "g3";
            this.g3.Size = new System.Drawing.Size(650, 350);
            this.g3.TabIndex = 4;
            this.g3.TabStop = false;
            this.g3.Text = "Adicionales";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "Mousepad Mickey Mouse",
            "Mousepad CoolerMaster",
            "Mouse Optico Razer",
            "Mouse Optico Logitech",
            "Mouse Optico CoolerMaster",
            "Teclado CoolerMaster",
            "Teclado Razer",
            "Teclado Logitech",
            "Audifonos Beats",
            "Audifonos Stelau",
            "Audifonos Razer",
            "Pantalla Samsung 15\'\'",
            "Pantalla Xiaomi 18\'\'",
            "Pantalla Sony 15\'\'"});
            this.list.Location = new System.Drawing.Point(122, 53);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(400, 224);
            this.list.TabIndex = 0;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardar.Location = new System.Drawing.Point(518, 1109);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(187, 48);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "GB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "GB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "GB";
            // 
            // Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.g3);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comp";
            this.Text = "Seleccion de componentes";
            this.Load += new System.EventHandler(this.Comp_Load);
            this.g1.ResumeLayout(false);
            this.g1.PerformLayout();
            this.g2.ResumeLayout(false);
            this.g2.PerformLayout();
            this.g3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox g1;
        private System.Windows.Forms.GroupBox g2;
        private System.Windows.Forms.CheckBox c3;
        private System.Windows.Forms.CheckBox c2;
        private System.Windows.Forms.CheckBox c1;
        private System.Windows.Forms.ComboBox ram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox c5;
        private System.Windows.Forms.CheckBox c4;
        private System.Windows.Forms.ComboBox d2;
        private System.Windows.Forms.ComboBox d1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.ComboBox So;
        private System.Windows.Forms.GroupBox g3;
        private System.Windows.Forms.CheckedListBox list;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cap2;
        private System.Windows.Forms.ComboBox cap1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}