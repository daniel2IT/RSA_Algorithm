namespace RSA_algorithm
{
    partial class RSA_Algorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA_Algorithm));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.EnryptionBTN = new System.Windows.Forms.Button();
            this.DecryptionBTN = new System.Windows.Forms.Button();
            this.textiFaila = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog3save = new System.Windows.Forms.OpenFileDialog();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.viesasisRaktas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(85, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "p = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(271, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "q =";
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(140, 137);
            this.textBox_p.Multiline = true;
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(54, 45);
            this.textBox_p.TabIndex = 8;
            this.textBox_p.Text = "23";
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(320, 137);
            this.textBox_q.Multiline = true;
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(54, 45);
            this.textBox_q.TabIndex = 9;
            this.textBox_q.Text = "31";
            // 
            // EnryptionBTN
            // 
            this.EnryptionBTN.BackColor = System.Drawing.Color.Lime;
            this.EnryptionBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnryptionBTN.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnryptionBTN.ForeColor = System.Drawing.Color.Black;
            this.EnryptionBTN.Location = new System.Drawing.Point(12, 24);
            this.EnryptionBTN.Name = "EnryptionBTN";
            this.EnryptionBTN.Size = new System.Drawing.Size(236, 107);
            this.EnryptionBTN.TabIndex = 10;
            this.EnryptionBTN.Text = "Encryption";
            this.EnryptionBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EnryptionBTN.UseVisualStyleBackColor = false;
            this.EnryptionBTN.Click += new System.EventHandler(this.EnryptionBTN_Click);
            // 
            // DecryptionBTN
            // 
            this.DecryptionBTN.BackColor = System.Drawing.Color.Red;
            this.DecryptionBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptionBTN.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptionBTN.ForeColor = System.Drawing.Color.Black;
            this.DecryptionBTN.Location = new System.Drawing.Point(281, 24);
            this.DecryptionBTN.Name = "DecryptionBTN";
            this.DecryptionBTN.Size = new System.Drawing.Size(217, 107);
            this.DecryptionBTN.TabIndex = 11;
            this.DecryptionBTN.Text = "Decryption";
            this.DecryptionBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DecryptionBTN.UseVisualStyleBackColor = false;
            this.DecryptionBTN.Click += new System.EventHandler(this.DecryptionBTN_Click);
            // 
            // textiFaila
            // 
            this.textiFaila.Location = new System.Drawing.Point(12, 188);
            this.textiFaila.Multiline = true;
            this.textiFaila.Name = "textiFaila";
            this.textiFaila.Size = new System.Drawing.Size(486, 220);
            this.textiFaila.TabIndex = 12;
            this.textiFaila.Text = resources.GetString("textiFaila.Text");
            // 
            // folderBrowserDialog3save
            // 
            this.folderBrowserDialog3save.FileName = "folderBrowserDialog3save";
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(444, 363);
            this.textBox_d.Multiline = true;
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(54, 45);
            this.textBox_d.TabIndex = 14;
            this.textBox_d.Visible = false;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(444, 188);
            this.textBox_n.Multiline = true;
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(54, 45);
            this.textBox_n.TabIndex = 15;
            this.textBox_n.Visible = false;
            // 
            // viesasisRaktas
            // 
            this.viesasisRaktas.Location = new System.Drawing.Point(444, 229);
            this.viesasisRaktas.Multiline = true;
            this.viesasisRaktas.Name = "viesasisRaktas";
            this.viesasisRaktas.Size = new System.Drawing.Size(54, 137);
            this.viesasisRaktas.TabIndex = 18;
            this.viesasisRaktas.Visible = false;
            // 
            // RSA_Algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(511, 423);
            this.Controls.Add(this.viesasisRaktas);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textiFaila);
            this.Controls.Add(this.DecryptionBTN);
            this.Controls.Add(this.EnryptionBTN);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IsMdiContainer = true;
            this.Name = "RSA_Algorithm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Button EnryptionBTN;
        private System.Windows.Forms.Button DecryptionBTN;
        private System.Windows.Forms.TextBox textiFaila;
        private System.Windows.Forms.OpenFileDialog folderBrowserDialog3save;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox viesasisRaktas;
    }
}

