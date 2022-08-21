using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.InterFaces;

namespace NetSatis.Entities.Tables
{
    public class OdemeTuru : IEntity
    {
        public int Id { get; set; }
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
