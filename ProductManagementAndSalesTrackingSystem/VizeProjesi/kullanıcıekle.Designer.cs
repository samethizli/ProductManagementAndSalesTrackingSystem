
namespace VizeProjesi
{
    partial class kullanıcıekle
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
            this.labelKullanıcıAdı = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonKullanıcıEkle = new System.Windows.Forms.Button();
            this.checkBoxSifre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelKullanıcıAdı
            // 
            this.labelKullanıcıAdı.AutoSize = true;
            this.labelKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanıcıAdı.Location = new System.Drawing.Point(12, 28);
            this.labelKullanıcıAdı.Name = "labelKullanıcıAdı";
            this.labelKullanıcıAdı.Size = new System.Drawing.Size(97, 16);
            this.labelKullanıcıAdı.TabIndex = 0;
            this.labelKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(12, 89);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(44, 16);
            this.labelSifre.TabIndex = 1;
            this.labelSifre.Text = "Şifre:";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(132, 24);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(123, 20);
            this.textBoxKullaniciAdi.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(132, 85);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(123, 20);
            this.textBoxSifre.TabIndex = 3;
            // 
            // buttonKullanıcıEkle
            // 
            this.buttonKullanıcıEkle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonKullanıcıEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullanıcıEkle.Location = new System.Drawing.Point(132, 147);
            this.buttonKullanıcıEkle.Name = "buttonKullanıcıEkle";
            this.buttonKullanıcıEkle.Size = new System.Drawing.Size(123, 72);
            this.buttonKullanıcıEkle.TabIndex = 4;
            this.buttonKullanıcıEkle.Text = "Kullanıcı Ekle";
            this.buttonKullanıcıEkle.UseVisualStyleBackColor = false;
            this.buttonKullanıcıEkle.Click += new System.EventHandler(this.buttonKullanıcıEkle_Click);
            // 
            // checkBoxSifre
            // 
            this.checkBoxSifre.AutoSize = true;
            this.checkBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSifre.Location = new System.Drawing.Point(262, 87);
            this.checkBoxSifre.Name = "checkBoxSifre";
            this.checkBoxSifre.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSifre.TabIndex = 5;
            this.checkBoxSifre.Text = "Şifreyi Göster";
            this.checkBoxSifre.UseVisualStyleBackColor = true;
            this.checkBoxSifre.CheckedChanged += new System.EventHandler(this.checkBoxSifre_CheckedChanged);
            // 
            // kullanıcıekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 231);
            this.Controls.Add(this.checkBoxSifre);
            this.Controls.Add(this.buttonKullanıcıEkle);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullanıcıAdı);
            this.Name = "kullanıcıekle";
            this.Text = "kullanıcıekle";
            this.Load += new System.EventHandler(this.kullanıcıekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullanıcıAdı;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonKullanıcıEkle;
        private System.Windows.Forms.CheckBox checkBoxSifre;
    }
}