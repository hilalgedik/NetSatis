using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.InterFaces;

namespace NetSatis.Entities.Tables
{
    public class Tanim : IEntity
    {
        public int Id { get; set; }
        public string Turu { get; set; }

        public string Tanimi { get; set; }
        public string Aciklama { get; set; }
        
    }
}
