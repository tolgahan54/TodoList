using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoUygulması.entities
{
    public class Todo
    {
        public Guid id { get; set; }
        [DisplayName("Başlık")]
        public string baslik { get; set; }
        [DisplayName("Kısa Açıklama")]
        public string kisaaciklama { get; set; }
        [DisplayName("Açıklama")]
        public string aciklama { get; set; }
        [DisplayName("Önem Derecesi")]
        public int onemDerece { get; set; }
        [DisplayName("Durum Açıklaması")]
        public string durumAciklama { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public DateTime olusturmaTarih { get; set; }
    }
}
