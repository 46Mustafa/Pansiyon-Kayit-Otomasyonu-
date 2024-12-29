namespace Pansiyon_kayıt1
{
    partial class FrmAdminGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // TxtKullanıcıAdı
            // 
            this.TxtKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanıcıAdı.Location = new System.Drawing.Point(134, 78);
            this.TxtKullanıcıAdı.Name = "TxtKullanıcıAdı";
            this.TxtKullanıcıAdı.Size = new System.Drawing.Size(153, 26);
            this.TxtKullanıcıAdı.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(134, 128);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(153, 26);
            this.TxtSifre.TabIndex = 1;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiriş.Location = new System.Drawing.Point(150, 174);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(121, 28);
            this.BtnGiriş.TabIndex = 2;
            this.BtnGiriş.Text = "Giriş Yap";
            this.BtnGiriş.UseVisualStyleBackColor = true;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ay Çiçeği Pansiyonuna Hoşgeldiniz";
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullanıcıAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminGiris";
            this.Text = "Admin Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullanıcıAdı;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGiriş;
        private System.Windows.Forms.Label label3;
    }
}

