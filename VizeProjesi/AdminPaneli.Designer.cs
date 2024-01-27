
namespace VizeProjesi
{
    partial class AdminPaneli
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
            this.buttonKullanıcıEkle = new System.Windows.Forms.Button();
            this.buttonKullanıcıSil = new System.Windows.Forms.Button();
            this.buttonÜrünFiyatGüncelle = new System.Windows.Forms.Button();
            this.buttonCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKullanıcıEkle
            // 
            this.buttonKullanıcıEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonKullanıcıEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullanıcıEkle.Location = new System.Drawing.Point(12, 41);
            this.buttonKullanıcıEkle.Name = "buttonKullanıcıEkle";
            this.buttonKullanıcıEkle.Size = new System.Drawing.Size(200, 114);
            this.buttonKullanıcıEkle.TabIndex = 0;
            this.buttonKullanıcıEkle.Text = "Kullanıcı Ekle";
            this.buttonKullanıcıEkle.UseVisualStyleBackColor = false;
            this.buttonKullanıcıEkle.Click += new System.EventHandler(this.buttonKullanıcıEkle_Click);
            // 
            // buttonKullanıcıSil
            // 
            this.buttonKullanıcıSil.BackColor = System.Drawing.Color.Salmon;
            this.buttonKullanıcıSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullanıcıSil.Location = new System.Drawing.Point(265, 41);
            this.buttonKullanıcıSil.Name = "buttonKullanıcıSil";
            this.buttonKullanıcıSil.Size = new System.Drawing.Size(199, 114);
            this.buttonKullanıcıSil.TabIndex = 1;
            this.buttonKullanıcıSil.Text = "Kullanıcı Sil";
            this.buttonKullanıcıSil.UseVisualStyleBackColor = false;
            this.buttonKullanıcıSil.Click += new System.EventHandler(this.buttonKullanıcıSil_Click);
            // 
            // buttonÜrünFiyatGüncelle
            // 
            this.buttonÜrünFiyatGüncelle.BackColor = System.Drawing.Color.Chocolate;
            this.buttonÜrünFiyatGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÜrünFiyatGüncelle.Location = new System.Drawing.Point(516, 41);
            this.buttonÜrünFiyatGüncelle.Name = "buttonÜrünFiyatGüncelle";
            this.buttonÜrünFiyatGüncelle.Size = new System.Drawing.Size(201, 114);
            this.buttonÜrünFiyatGüncelle.TabIndex = 2;
            this.buttonÜrünFiyatGüncelle.Text = "Ürün Fiyat Güncelle";
            this.buttonÜrünFiyatGüncelle.UseVisualStyleBackColor = false;
            this.buttonÜrünFiyatGüncelle.Click += new System.EventHandler(this.buttonÜrünFiyatGüncelle_Click);
            // 
            // buttonCıkıs
            // 
            this.buttonCıkıs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCıkıs.Location = new System.Drawing.Point(242, 262);
            this.buttonCıkıs.Name = "buttonCıkıs";
            this.buttonCıkıs.Size = new System.Drawing.Size(274, 101);
            this.buttonCıkıs.TabIndex = 3;
            this.buttonCıkıs.Text = "Çıkış";
            this.buttonCıkıs.UseVisualStyleBackColor = false;
            this.buttonCıkıs.Click += new System.EventHandler(this.buttonCıkıs_Click);
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 397);
            this.Controls.Add(this.buttonCıkıs);
            this.Controls.Add(this.buttonÜrünFiyatGüncelle);
            this.Controls.Add(this.buttonKullanıcıSil);
            this.Controls.Add(this.buttonKullanıcıEkle);
            this.Name = "AdminPaneli";
            this.Text = "Admin Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPaneli_FormClosed);
            this.Load += new System.EventHandler(this.AdminPaneli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKullanıcıEkle;
        private System.Windows.Forms.Button buttonKullanıcıSil;
        private System.Windows.Forms.Button buttonÜrünFiyatGüncelle;
        private System.Windows.Forms.Button buttonCıkıs;
    }
}