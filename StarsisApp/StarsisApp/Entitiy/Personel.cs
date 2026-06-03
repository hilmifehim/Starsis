using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mssqldeneme2.Entitiy
{
    internal class Personel
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }
        public decimal Maas { get; set; }
        public int DepartmanID { get; set; }
        public int PozisyonID { get; set; }
    }
}
