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
    public partial class yenikayit : Form
    {
        public yenikayit()
        {
            InitializeComponent();
        }

        private void txtbaslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.CadetBlue;
        }

        private void txtbaslik_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            todoService service = new todoService();
            int sonuc = service.Kayityeni(new entities.Todo()
            {
                id = Guid.NewGuid(),
                baslik=txtbaslik.Text,
                kisaaciklama=txtkisaacik.Text,
                aciklama=txtaciklama.Text,
                onemDerece=int.Parse(txtonem.Text),
                durumAciklama=cbxdurum.SelectedItem.ToString(),
                olusturmaTarih=DateTime.Now
            }) ;

            if (sonuc >0)
            {
                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Yeni Kayıt Eklemek İster misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitliste = Application.OpenForms["kayitliste"];
                    if (kayitliste==null)
                    {
                        kayitliste = new kayitliste();
                        kayitliste.MdiParent = Application.OpenForms["Form1"];
                        kayitliste.StartPosition = FormStartPosition.CenterScreen;
                        kayitliste.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox Liste = (GroupBox)kayitliste.Controls["grpListe"];
                        DataGridView grdListe = (DataGridView)Liste.Controls["grdListe"];
                        List<Todo> Guncel = service.kayitliste();
                        grdListe.DataSource = null;
                        grdListe.DataSource = Guncel;
                        kayitliste.Show();
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Kayıt işleminde hata oluştu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
