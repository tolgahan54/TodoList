using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoUygulması.BusinessService;

namespace TodoUygulması
{
    public partial class Form1 : Form
    {
        Form T;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOnOff(bool Kontrol)
        {
            foreach (Control item in gbIslemliste.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = Kontrol;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm_zaman.Interval = 15000;
            tm_zaman.Tick += Tm_zaman_Tick;
            tm_zaman.Start();

            BtnOnOff(false);

            sstemGiris kullaniciKontrol = new sstemGiris();
            kullaniciKontrol.MdiParent = this;
            kullaniciKontrol.StartPosition = FormStartPosition.CenterScreen;
            kullaniciKontrol.Show();
        }

        private void Tm_zaman_Tick(object sender, EventArgs e)
        {
            lblzaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
        }

        private void btnuygulamakapa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYenikayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["yenikayit"] != null)
            {
                T = Application.OpenForms["yenikayit"];
                T.Focus();
            }
            else
            {
                T = new yenikayit();
                T.MdiParent = this; 
                T.Show();
            }
        }

        private void btnkayitliste_Click(object sender, EventArgs e)
        {
            todoService todoservice = new todoService();
            if (todoservice.kayitkontrol()>0)
            {
                kayitliste kayitliste = new kayitliste();
                kayitliste.MdiParent = this;
                kayitliste.Show();
            }
            else
            {
                MessageBox.Show("Listelenecek Kayıt Bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
