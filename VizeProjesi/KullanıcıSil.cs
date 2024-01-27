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
    public partial class KullanıcıSil : Form
    {
        public KullanıcıSil()
        {
            InitializeComponent();
        }

       

        private void buttonKullanıcıSil_Click(object sender, EventArgs e)
        {
            XmlDocument xmlUsers = new XmlDocument();
            xmlUsers.Load(Application.StartupPath + @"\users.xml");

            bool kullanıcıBulundu = false;

            XmlElement kullanıcılar = (XmlElement)xmlUsers.GetElementsByTagName("kullanıcılar")[0];
            foreach (XmlNode node in xmlUsers.GetElementsByTagName("kullanıcılar")[0].ChildNodes)
            {
                var kullanıcı = (XmlElement)node;
                var kullanıcıadı = (XmlElement)kullanıcı.GetElementsByTagName("kullanıcıadı")[0];
                if (kullanıcıadı.InnerText == textBoxKullaniciAdi.Text)
                {
                    kullanıcılar.RemoveChild(kullanıcı);
                    kullanıcıBulundu = true;
                    break;
                }
            }

            if (kullanıcıBulundu)
            {
                MessageBox.Show("Kullanıcı silindi!");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!");
            }


            xmlUsers.Save(Application.StartupPath + @"\users.xml");
        }

       
    }
}
