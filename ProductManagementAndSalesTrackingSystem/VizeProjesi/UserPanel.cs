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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private string path = Application.StartupPath + @"\urunler.xml";

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            richTextBoxUrunler.Clear();
            richTextBoxUrunler.Text += "Ürün Adı\t\t\t";
            richTextBoxUrunler.Text += "Adet\t\t\t";
            richTextBoxUrunler.Text += "FİYAT(TL)\n";



            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(path);

            int toplam = 0;
            int count = 0;
            XmlTextReader okuyucu = new XmlTextReader(Application.StartupPath + @"\urunler.xml");
            int miktar1 = Convert.ToInt32(textBox1.Text);
            int miktar2 = Convert.ToInt32(textBox2.Text);
            int miktar3 = Convert.ToInt32(textBox3.Text);
            int miktar4 = Convert.ToInt32(textBox4.Text);
            
            while (okuyucu.Read())
            {
                if (okuyucu.Name == "ürünadı")
                {
                    string ürünadi = okuyucu.ReadString();
                   
                    if (ürünadi == "Cafe Latte" && checkBox1.Checked)
                    {
                        int fiyat = Convert.ToInt32(xDoc.GetElementsByTagName("ürünfiyat")[count].InnerText);

                        toplam += fiyat * miktar1;
                        richTextBoxUrunler.Text += "Cafe Latte";
                        richTextBoxUrunler.Text += "\t\t" + miktar1.ToString();
                        richTextBoxUrunler.Text += "\t\t\t" + (fiyat * miktar1).ToString() + "\n";
                       



                    }
                    else if (ürünadi == "Americano" && checkBox2.Checked)
                    {
                        int fiyat = Convert.ToInt32(xDoc.GetElementsByTagName("ürünfiyat")[count].InnerText);

                        toplam += fiyat * miktar2;
                        richTextBoxUrunler.Text += "Americano";
                        richTextBoxUrunler.Text += "\t\t" + miktar2.ToString();
                        richTextBoxUrunler.Text += "\t\t\t" + (fiyat * miktar2).ToString() + "\n";


                    }
                    else if (ürünadi == "Espresso" && checkBox3.Checked)
                    {
                        int fiyat = Convert.ToInt32(xDoc.GetElementsByTagName("ürünfiyat")[count].InnerText);

                        toplam += fiyat * miktar3;
                        richTextBoxUrunler.Text += "Espresso";
                        richTextBoxUrunler.Text += "\t\t\t" + miktar3.ToString();
                        richTextBoxUrunler.Text += "\t\t\t" + (fiyat * miktar3).ToString() + "\n";


                    }

                    else if (ürünadi == "Filtre Kahve" && checkBox4.Checked)
                    {
                        int fiyat = Convert.ToInt32(xDoc.GetElementsByTagName("ürünfiyat")[count].InnerText);

                        toplam += fiyat * miktar4;
                        richTextBoxUrunler.Text += "Filtre Kahve";
                        richTextBoxUrunler.Text += "\t\t" + miktar4.ToString();
                        richTextBoxUrunler.Text += "\t\t\t" + (fiyat * miktar4).ToString() + "\n";


                    }
                    count++;
                }
            }

            richTextBoxUrunler.Text += "\n\nToplam:\t\t\t\t\t\t" + toplam.ToString();

            textBoxtoplam.Text = (miktar1 + miktar2 + miktar3 + miktar4).ToString();

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Text = Math.Max(0, Convert.ToInt32(textBox1.Text) + 1).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Max(0, Convert.ToInt32(textBox1.Text) - 1).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Math.Max(0, Convert.ToInt32(textBox2.Text) + 1).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Math.Max(0, Convert.ToInt32(textBox2.Text) - 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.Max(0, Convert.ToInt32(textBox3.Text) - 1).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.Max(0, Convert.ToInt32(textBox3.Text) + 1).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = Math.Max(0, Convert.ToInt32(textBox4.Text) - 1).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text = Math.Max(0, Convert.ToInt32(textBox4.Text) + 1).ToString();
        }


        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            richTextBoxUrunler.Clear();
        }

        private void buttonYazdır_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)//printe basılırsa
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTipi = new Font("Times News Roman", 14, FontStyle.Bold);
            Brush fontRengi = Brushes.Black;
            PointF baslangicNoktasi = new PointF(120, 500);
            e.Graphics.DrawString(richTextBoxUrunler.Text, fontTipi, fontRengi, baslangicNoktasi);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            }
            else
            {
                textBox1.Text = "0";
                textBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                textBox2.Text = "0";
                textBox2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            else
            {
                textBox3.Text = "0";
                textBox3.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                textBox4.Text = "0";
                textBox4.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }
        }
    }
}
