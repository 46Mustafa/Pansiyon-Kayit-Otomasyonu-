namespace Pansiyon_kayıt1
{
    partial class FrmStoklar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.Txtatıştırmalıklar = new System.Windows.Forms.TextBox();
            this.Txtıcecekler = new System.Windows.Forms.TextBox();
            this.TxtGıdalar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btnkaydet2 = new System.Windows.Forms.Button();
            this.Txtİnt = new System.Windows.Forms.TextBox();
            this.TxtSu = new System.Windows.Forms.TextBox();
            this.Txtelektirik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-2, 263);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(418, 125);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 152;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.Txtatıştırmalıklar);
            this.groupBox1.Controls.Add(this.Txtıcecekler);
            this.groupBox1.Controls.Add(this.TxtGıdalar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 254);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(249, 126);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(102, 33);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // Txtatıştırmalıklar
            // 
            this.Txtatıştırmalıklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtatıştırmalıklar.Location = new System.Drawing.Point(167, 94);
            this.Txtatıştırmalıklar.Name = "Txtatıştırmalıklar";
            this.Txtatıştırmalıklar.Size = new System.Drawing.Size(184, 26);
            this.Txtatıştırmalıklar.TabIndex = 12;
            // 
            // Txtıcecekler
            // 
            this.Txtıcecekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtıcecekler.Location = new System.Drawing.Point(167, 55);
            this.Txtıcecekler.Name = "Txtıcecekler";
            this.Txtıcecekler.Size = new System.Drawing.Size(184, 26);
            this.Txtıcecekler.TabIndex = 11;
            // 
            // TxtGıdalar
            // 
            this.TxtGıdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGıdalar.Location = new System.Drawing.Point(167, 18);
            this.TxtGıdalar.Name = "TxtGıdalar";
            this.TxtGıdalar.Size = new System.Drawing.Size(184, 26);
            this.TxtGıdalar.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Atıştırmalıklar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "İçecek Tutarı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gıda Tutarı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btnkaydet2);
            this.groupBox2.Controls.Add(this.Txtİnt);
            this.groupBox2.Controls.Add(this.TxtSu);
            this.groupBox2.Controls.Add(this.Txtelektirik);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(422, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 249);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // Btnkaydet2
            // 
            this.Btnkaydet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet2.Location = new System.Drawing.Point(181, 132);
            this.Btnkaydet2.Name = "Btnkaydet2";
            this.Btnkaydet2.Size = new System.Drawing.Size(102, 33);
            this.Btnkaydet2.TabIndex = 21;
            this.Btnkaydet2.Text = "Kaydet";
            this.Btnkaydet2.UseVisualStyleBackColor = true;
            this.Btnkaydet2.Click += new System.EventHandler(this.Btnkaydet2_Click);
            // 
            // Txtİnt
            // 
            this.Txtİnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtİnt.Location = new System.Drawing.Point(99, 87);
            this.Txtİnt.Name = "Txtİnt";
            this.Txtİnt.Size = new System.Drawing.Size(184, 26);
            this.Txtİnt.TabIndex = 20;
            // 
            // TxtSu
            // 
            this.TxtSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSu.Location = new System.Drawing.Point(99, 51);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Size = new System.Drawing.Size(184, 26);
            this.TxtSu.TabIndex = 19;
            // 
            // Txtelektirik
            // 
            this.Txtelektirik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtelektirik.Location = new System.Drawing.Point(99, 16);
            this.Txtelektirik.Name = "Txtelektirik";
            this.Txtelektirik.Size = new System.Drawing.Size(184, 26);
            this.Txtelektirik.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "İnternet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Su :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Elektirik :";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(422, 263);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(428, 125);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektirik";
            this.columnHeader4.Width = 152;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 145;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 152;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 380);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox Txtatıştırmalıklar;
        private System.Windows.Forms.TextBox Txtıcecekler;
        private System.Windows.Forms.TextBox TxtGıdalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btnkaydet2;
        private System.Windows.Forms.TextBox Txtİnt;
        private System.Windows.Forms.TextBox TxtSu;
        private System.Windows.Forms.TextBox Txtelektirik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}