using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeProjesi
{
    
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
        
        }

        private void buttonKullanıcıEkle_Click(object sender, EventArgs e)
        {
            kullanıcıekle kullanıcılar = new kullanıcıekle();
            kullanıcılar.ShowDialog();
            
        }

        private void buttonKullanıcıSil_Click(object sender, EventArgs e)
        {
            KullanıcıSil kullanıcısil = new KullanıcıSil();
            kullanıcısil.ShowDialog();
        }

        private void buttonÜrünFiyatGüncelle_Click(object sender, EventArgs e)
        {
            ürünFiyatGuncelle ürünguncelle = new ürünFiyatGuncelle();
            ürünguncelle.ShowDialog();

        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void AdminPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
