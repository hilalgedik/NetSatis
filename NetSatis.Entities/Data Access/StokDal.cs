using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.Data_Access
{
    public class StokDal:EntityRepositoryBase<NetSatisContext,Stok,StokValidator>
    {
        public object GetAllJoin(NetSatisContext context)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu,
                (Stoklar, StokHareketleri) => new
                {
                    Stoklar.Id,
                    Stoklar.StokKodu,
                    Stoklar.StokAdi,
                    Stoklar.Barkod,
                    Stoklar.BarkodTuru,
                    Stoklar.Birimi,
                    Stoklar.StokGrubu,
                    Stoklar.StokAltGrubu,
                    Stoklar.Marka,
                    Stoklar.Modeli,
                    Stoklar.OzelKod1,
                    Stoklar.OzelKod2,
                    Stoklar.OzelKod3,
                    Stoklar.OzelKod4,
                    Stoklar.GarantiSuresi,
                    Stoklar.UreticiKodu,
                    Stoklar.AlisKdv,
                    Stoklar.SatisKdv,
                    Stoklar.AlisFiyati1,
                    Stoklar.AlisFiyati2,
                    Stoklar.AlisFiyati3,
                    Stoklar.SatisFiyati1,
                    Stoklar.SatisFiyati2,
                    Stoklar.SatisFiyati3,
                    Stoklar.MinStokMiktari,
                    Stoklar.MaxStokMiktari,
                    Stoklar.Aciklama,

                    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) -
                        StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,



                }).ToList();
            return tablo;

          
        }

        public object GetGenelStok(NetSatisContext context,string stokKodu)
        {
            var result = (from c in context.StokHareketleri.Where(c=>c.StokKodu == stokKodu)
                group c by new { c.Hareket }
                into g
                select new
                {
                    Bilgi = g.Key.Hareket,
                    KayitSayisi = g.Count(),
                    Toplam = g.Sum(c => c.Miktar)

                }).ToList();
            return result;
        }

        public object GetDepoStok(NetSatisContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
                c => c.DepoKodu, c => c.DepoKodu,
                (depolar, stokhareketleri) => new
                {
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0 -
                        stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,


                }).ToList();
            return result;
        }

    }
}
