
namespace VizeProjesi
{
    partial class KullanıcıSil
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
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.buttonKullanıcıSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciAdi.Location = new System.Drawing.Point(12, 38);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(97, 16);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(135, 34);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(120, 20);
            this.textBoxKullaniciAdi.TabIndex = 2;
            // 
            // buttonKullanıcıSil
            // 
            this.buttonKullanıcıSil.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonKullanıcıSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullanıcıSil.Location = new System.Drawing.Point(135, 112);
            this.buttonKullanıcıSil.Name = "buttonKullanıcıSil";
            this.buttonKullanıcıSil.Size = new System.Drawing.Size(120, 42);
            this.buttonKullanıcıSil.TabIndex = 4;
            this.buttonKullanıcıSil.Text = "Kullanıcı Sil";
            this.buttonKullanıcıSil.UseVisualStyleBackColor = false;
            this.buttonKullanıcıSil.Click += new System.EventHandler(this.buttonKullanıcıSil_Click);
            // 
            // KullanıcıSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 190);
            this.Controls.Add(this.buttonKullanıcıSil);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Name = "KullanıcıSil";
            this.Text = "KullanıcıSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Button buttonKullanıcıSil;
    }
}