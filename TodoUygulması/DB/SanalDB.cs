using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoUygulması.entities;

namespace TodoUygulması.DB
{
    public static class SanalDB
    {
        public static List<Kullanici> Kullanicitablo;
        public static List<Todo> Todotablosu;

        static SanalDB()
        {
            Kullanicitablo = new List<Kullanici>();
            Kullanicitablo.Add(new Kullanici() { id = Guid.NewGuid(), kullanici = "test1", sifre = "test1" });
            Todotablosu = new List<Todo>();
        }
    }
}
