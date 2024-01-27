
namespace VizeProjesi
{
    partial class ürünFiyatGuncelle
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
            this.comboBoxFiyatÜrün = new System.Windows.Forms.ComboBox();
            this.textBoxÜrünYeniFiyat = new System.Windows.Forms.TextBox();
            this.buttonFiyatGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiyatı Değiştirilecek Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürünün Yeni Fiyatı:";
            // 
            // comboBoxFiyatÜrün
            // 
            this.comboBoxFiyatÜrün.FormattingEnabled = true;
            this.comboBoxFiyatÜrün.Location = new System.Drawing.Point(195, 24);
            this.comboBoxFiyatÜrün.Name = "comboBoxFiyatÜrün";
            this.comboBoxFiyatÜrün.Size = new System.Drawing.Size(140, 21);
            this.comboBoxFiyatÜrün.TabIndex = 2;
            // 
            // textBoxÜrünYeniFiyat
            // 
            this.textBoxÜrünYeniFiyat.Location = new System.Drawing.Point(195, 81);
            this.textBoxÜrünYeniFiyat.Name = "textBoxÜrünYeniFiyat";
            this.textBoxÜrünYeniFiyat.Size = new System.Drawing.Size(140, 20);
            this.textBoxÜrünYeniFiyat.TabIndex = 3;
            this.textBoxÜrünYeniFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxÜrünYeniFiyat_KeyPress);
            // 
            // buttonFiyatGuncelle
            // 
            this.buttonFiyatGuncelle.BackColor = System.Drawing.Color.Red;
            this.buttonFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFiyatGuncelle.Location = new System.Drawing.Point(130, 138);
            this.buttonFiyatGuncelle.Name = "buttonFiyatGuncelle";
            this.buttonFiyatGuncelle.Size = new System.Drawing.Size(147, 62);
            this.buttonFiyatGuncelle.TabIndex = 4;
            this.buttonFiyatGuncelle.Text = "Fiyatı Güncelle";
            this.buttonFiyatGuncelle.UseVisualStyleBackColor = false;
            this.buttonFiyatGuncelle.Click += new System.EventHandler(this.buttonFiyatGuncelle_Click);
            // 
            // ürünFiyatGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 246);
            this.Controls.Add(this.buttonFiyatGuncelle);
            this.Controls.Add(this.textBoxÜrünYeniFiyat);
            this.Controls.Add(this.comboBoxFiyatÜrün);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ürünFiyatGuncelle";
            this.Text = "ürünFiyatGuncelle";
            this.Load += new System.EventHandler(this.ürünFiyatGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiyatÜrün;
        private System.Windows.Forms.TextBox textBoxÜrünYeniFiyat;
        private System.Windows.Forms.Button buttonFiyatGuncelle;
    }
}