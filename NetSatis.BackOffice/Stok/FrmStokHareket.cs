using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        
        StokHareketDal stokHareketDal = new StokHareketDal();
        NetSatisContext context = new NetSatisContext();
        private string _stokKodu;
        public FrmStokHareket(string stokKodu, string stokAdi)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            lblBaslik.Text = _stokKodu + "-" + stokAdi + " Hareketleri ";

        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            grcStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            grcGenelStok.DataSource = stokHareketDal.GetGenelStok(context, _stokKodu);
            grcDepoStok.DataSource = stokHareketDal.GetDepoStok(context, _stokKodu);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (grStokHareket.OptionsView.ShowAutoFilterRow==true)
            {
                grStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                grStokHareket.OptionsView.ShowAutoFilterRow = true;
            }
            
        }
    }
}