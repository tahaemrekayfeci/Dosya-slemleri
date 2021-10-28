
namespace Dosyaİslemleri
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
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kimlik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kadin = new System.Windows.Forms.RadioButton();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_duzenlemek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(93, 125);
            this.txt_tel.Mask = "(999) 000-0000";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 0;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(93, 26);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(93, 75);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tel Numara :";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(93, 181);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(100, 20);
            this.txt_eposta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TC Kimlik :";
            // 
            // txt_kimlik
            // 
            this.txt_kimlik.Location = new System.Drawing.Point(326, 26);
            this.txt_kimlik.Name = "txt_kimlik";
            this.txt_kimlik.Size = new System.Drawing.Size(100, 20);
            this.txt_kimlik.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cinsiyet :";
            // 
            // kadin
            // 
            this.kadin.AutoSize = true;
            this.kadin.Location = new System.Drawing.Point(326, 73);
            this.kadin.Name = "kadin";
            this.kadin.Size = new System.Drawing.Size(52, 17);
            this.kadin.TabIndex = 11;
            this.kadin.TabStop = true;
            this.kadin.Text = "Kadın";
            this.kadin.UseVisualStyleBackColor = true;
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(427, 75);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(53, 17);
            this.erkek.TabIndex = 12;
            this.erkek.TabStop = true;
            this.erkek.Text = "Erkek";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(260, 123);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 13;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_duzenlemek
            // 
            this.btn_duzenlemek.Location = new System.Drawing.Point(365, 123);
            this.btn_duzenlemek.Name = "btn_duzenlemek";
            this.btn_duzenlemek.Size = new System.Drawing.Size(75, 23);
            this.btn_duzenlemek.TabIndex = 14;
            this.btn_duzenlemek.Text = "Düzenle";
            this.btn_duzenlemek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_duzenlemek);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.kadin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_kimlik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kimlik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton kadin;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_duzenlemek;
    }
}

