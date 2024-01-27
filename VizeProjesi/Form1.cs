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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxSifre.PasswordChar = '\0';
            }
            else
            {
                textBoxSifre.PasswordChar = '*';
            }
            
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            XmlDocument xmlAdmin = new XmlDocument();
            xmlAdmin.Load(Application.StartupPath + @"\admin.xml");

            string username = xmlAdmin.GetElementsByTagName("username")[0].InnerText;
            string password = xmlAdmin.GetElementsByTagName("password")[0].InnerText;


            if (textBoxKullaniciAdi.Text == username)
            {
                if (textBoxSifre.Text == password)
                {
                    MessageBox.Show("Admin Girişi Yapıldı!");
                    AdminPaneli panel = new AdminPaneli();
                    panel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış!");

                }

             }
            else
            {
                XmlDocument xmlUsers = new XmlDocument();
                XmlTextReader okuyucu = new XmlTextReader(Application.StartupPath + @"\users.xml");
                xmlUsers.Load(Application.StartupPath + @"\users.xml");

                int count = 0;
                bool kullanıcıBulundu = false;
                while (okuyucu.Read())
                {
                    if (okuyucu.Name == "kullanıcıadı")
                    {
                        if (okuyucu.ReadString() == textBoxKullaniciAdi.Text)
                        {
                            if (xmlUsers.GetElementsByTagName("sifre")[count].InnerText == textBoxSifre.Text)
                            {
                                MessageBox.Show("Kullanıcı Girişi Yapıldı!");
                                UserPanel upanel = new UserPanel();
                                upanel.Show();
                                this.Hide();

                                return;
                                
                            }
                            kullanıcıBulundu = true;
                        }
                        count++;
                    }
                }
                if (kullanıcıBulundu)
                {
                    MessageBox.Show("Şifre yanlış!");
                }

            }

            }
           

      





        }
    }

