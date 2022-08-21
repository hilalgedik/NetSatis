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
        StokDal stokDal = new StokDal();
        StokHareketDal stokHareketDal = new StokHareketDal();
        NetSatisContext context = new NetSatisContext();
        private string _stokKodu;
        public FrmStokHareket(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            grcStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            grcGenelStok.DataSource = stokDal.GetGenelStok(context, _stokKodu);
            grcDepoStok.DataSource = stokDal.GetDepoStok(context, _stokKodu);
        }
    }
}