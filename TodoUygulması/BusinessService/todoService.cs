using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoUygulması.DB;
using TodoUygulması.entities;

namespace TodoUygulması.BusinessService
{
    public class todoService
    {
        public int kayitkontrol()
        {
            return SanalDB.Todotablosu.Count;
        }

        public List<Todo> kayitliste() 
        {
            return SanalDB.Todotablosu;
        }

        public int Kayityeni(Todo data)
        {
            try
            {
                SanalDB.Todotablosu.Add(data);
                return 1;
            }
            catch (Exception ex)
            {

                return 0;
            }
        }
    }
}
