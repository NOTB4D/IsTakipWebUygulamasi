using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsTakip.DTO
{
    public class PersonelService 
    {
        public int ID { get; set; }

        public string ProjeAdi { get; set; }

        public string SorumluAdi { get; set; }

        public string YapilanIs { get; set; }

        public int TahminiIsSuresi { get; set; }

        public int TamamlanmaMiktari { get; set; }

        public DateTime BaslamaTarihi { get; set; }

        public DateTime TeslimTarihi { get; set; }

        public string Aciklama { get; set; }

        public bool IslemTipi { get; set; }
    }
}
