using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VizeProjesi
{
    public partial class ürünFiyatGuncelle : Form
    {
        public ürünFiyatGuncelle()
        {
            InitializeComponent();
        }

         private void ürünFiyatGuncelle_Load(object sender, EventArgs e)
        {

            XmlDocument xmlUrunler = new XmlDocument();
            xmlUrunler.Load(Application.StartupPath + @"\urunler.xml");
            foreach (var item in xmlUrunler.GetElementsByTagName("ürünler")[0].ChildNodes)
            {
                XmlElement ürün = (XmlElement)item;
                comboBoxFiyatÜrün.Items.Add(ürün.GetElementsByTagName("ürünadı")[0].InnerText);
                
            }
        }

        private void buttonFiyatGuncelle_Click(object sender, EventArgs e)
        {
            XmlDocument xmlurunler = new XmlDocument();
            xmlurunler.Load(Application.StartupPath + @"\urunler.xml");

            foreach (var item in xmlurunler.GetElementsByTagName("ürünler")[0].ChildNodes)
            {

                XmlElement ürün = (XmlElement)item;
                if (comboBoxFiyatÜrün.Text == ürün.GetElementsByTagName("ürünadı")[0].InnerText)
                {
                    ürün.GetElementsByTagName("ürünfiyat")[0].InnerText = textBoxÜrünYeniFiyat.Text;
                    MessageBox.Show("Ürün Fiyatı Güncellendi.");
                    break;
                    

                }

            }
          xmlurunler.Save(Application.StartupPath + @"\urunler.xml");
        }

        private void textBoxÜrünYeniFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                 MessageBox.Show("Rakam Giriniz.");
            }
            
            
        }

       
    }
}
