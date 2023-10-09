namespace indirim_satis
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rb40 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb40);
            this.groupBox1.Controls.Add(this.rb30);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb0);
            this.groupBox1.Location = new System.Drawing.Point(15, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(216, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Seçin";
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Location = new System.Drawing.Point(43, 43);
            this.rb0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(121, 28);
            this.rb0.TabIndex = 0;
            this.rb0.TabStop = true;
            this.rb0.Text = "İndirim Yok";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(43, 86);
            this.rb5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(114, 28);
            this.rb5.TabIndex = 1;
            this.rb5.TabStop = true;
            this.rb5.Text = "%5 İndirim";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Location = new System.Drawing.Point(43, 128);
            this.rb30.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(124, 28);
            this.rb30.TabIndex = 2;
            this.rb30.TabStop = true;
            this.rb30.Text = "%30 İndirim";
            this.rb30.UseVisualStyleBackColor = true;
            // 
            // rb40
            // 
            this.rb40.AutoSize = true;
            this.rb40.Location = new System.Drawing.Point(43, 170);
            this.rb40.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb40.Name = "rb40";
            this.rb40.Size = new System.Drawing.Size(124, 28);
            this.rb40.TabIndex = 3;
            this.rb40.TabStop = true;
            this.rb40.Text = "%40 İndirim";
            this.rb40.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiyat Girin";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(408, 68);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(154, 29);
            this.txtFiyat.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(408, 112);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(154, 70);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Ödenecek Tutar";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Location = new System.Drawing.Point(404, 200);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(99, 24);
            this.lblOdenecekTutar.TabIndex = 4;
            this.lblOdenecekTutar.Text = "Ödenecek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 290);
            this.Controls.Add(this.lblOdenecekTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb40;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblOdenecekTutar;
    }
}

