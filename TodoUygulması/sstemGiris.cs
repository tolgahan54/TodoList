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
using TodoUygulması.entities;

namespace TodoUygulması
{
    public partial class sstemGiris : Form
    {
        public sstemGiris()
        {
            InitializeComponent();
        }

        private void txtKullaniciadi_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.CadetBlue;
        }

        private void txtKullaniciadi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciadi.Text) || !string.IsNullOrEmpty(txtsifre.Text))
            {
                Kullanicisevice kullaniciservice = new Kullanicisevice();
                Kullanici kontrolkullanici= kullaniciservice.kullanicikontrol(txtKullaniciadi.Text, txtsifre.Text);
                if (kontrolkullanici !=null)
                {
                    Form anaform = Application.OpenForms["Form1"];
                    Panel solPanel=(Panel)anaform.Controls["Islemlistesi"];
                    GroupBox gbxList = (GroupBox)solPanel.Controls["gbIslemliste"];

                    foreach (Control item in gbxList.Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show("Merhaba" +" "+kontrolkullanici.kullanici, "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Değer Giriniz", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Eksiksiz Değer Giriniz", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
