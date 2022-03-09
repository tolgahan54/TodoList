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
    public partial class kayitliste : Form
    {
        todoService todoService;
        public kayitliste()
        {
            InitializeComponent();
            todoService = new todoService();
        }

        private void kayitliste_Load(object sender, EventArgs e)
        {
            grdListe.DataSource = Tumliste();
            grdListe.Columns["id"].Visible = false;
        }

        private List<Todo> Tumliste()
        {
            return todoService.kayitliste();
        }

        private void btnTumListe_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = Tumliste();
            grdListe.Columns["id"].Visible = false;
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = Tumliste().Where(x=>x.durumAciklama == "Tamamlandı").ToList();
            grdListe.Columns["id"].Visible = false;
        }

        private void btnTamamlanmadi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = Tumliste().Where(x => x.durumAciklama == "Tamamlanmadı").ToList();
            grdListe.Columns["id"].Visible = false;
        }

        private void btnIptalEdildi_Click(object sender, EventArgs e)
        {
            grdListe.DataSource = Tumliste().Where(x => x.durumAciklama == "İptal Edildi").ToList();
            grdListe.Columns["id"].Visible = false;
        }
    }
}
