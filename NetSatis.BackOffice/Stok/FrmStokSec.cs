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
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        private StokDal stokDal = new StokDal();
        NetSatisContext context = new NetSatisContext();
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public FrmStokSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                grStoklar.OptionsSelection.MultiSelect = true;
            }
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            grcStoklar.DataSource = stokDal.GetAllJoin(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            foreach (var row in grStoklar.GetSelectedRows())
            {
                string stokKodu = grStoklar.GetRowCellValue(row, colStokKodu).ToString();
                secilen.Add(context.Stoklar.SingleOrDefault(c=>c.StokKodu==stokKodu));
            }
            this.Close();
        }
    }
}