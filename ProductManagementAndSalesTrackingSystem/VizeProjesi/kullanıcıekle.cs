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
    public partial class kullanıcıekle : Form
    {
        
        private void kullanıcıekle_Load(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';
        }
        public kullanıcıekle()
        {
            InitializeComponent();
        }
        private void checkBoxSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifre.Checked)
            {
                textBoxSifre.PasswordChar = '\0';
            }
            else
            {
                textBoxSifre.PasswordChar = '*';
            }
        }
        private void buttonKullanıcıEkle_Click(object sender, EventArgs e)
        {
            

            XmlDocument xmlUsers = new XmlDocument();
            xmlUsers.Load(Application.StartupPath + @"\users.xml");

            XmlTextReader okuyucu = new XmlTextReader(Application.StartupPath + @"\users.xml");

            int count = 0;
            bool kullanıcıBulundu = false;
            while (okuyucu.Read())
            {
                if (okuyucu.Name == "kullanıcıadı")
                {
                    if (okuyucu.ReadString() == textBoxKullaniciAdi.Text)
                    {
                            MessageBox.Show("Bu kullanıcı adı mevcut!");
                        okuyucu.Close();
                        okuyucu.Dispose();

                        return;

                        kullanıcıBulundu = true;
                    }
                    count++;
                }
            }

            
            okuyucu.Close();
            okuyucu.Dispose();
                XmlElement kullanıcı = xmlUsers.CreateElement("kullanıcı");
                XmlElement kullanıcıadı = xmlUsers.CreateElement("kullanıcıadı");
                XmlElement sifre = xmlUsers.CreateElement("sifre");

                kullanıcıadı.InnerText = textBoxKullaniciAdi.Text;

                sifre.InnerText = textBoxSifre.Text;

                kullanıcı.AppendChild(kullanıcıadı);
                kullanıcı.AppendChild(sifre);

            MessageBox.Show("Kullanıcı eklendi");
            xmlUsers.DocumentElement.AppendChild(kullanıcı);
            xmlUsers.Save(Application.StartupPath + @"\users.xml");
            
        }

       
        
    }
}

