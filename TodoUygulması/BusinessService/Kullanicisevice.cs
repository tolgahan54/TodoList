using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoUygulması.DB;
using TodoUygulması.entities;

namespace TodoUygulması.BusinessService
{
    public class Kullanicisevice
    {
        public Kullanici kullanicikontrol(string kullaniciAdi, string sifre)
        {
            return SanalDB.Kullanicitablo.Where(x => x.kullanici == kullaniciAdi && x.sifre == sifre).FirstOrDefault();
        }
    }
}
