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
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        StokDal stokDal = new StokDal();
        public FrmStok()
        {
            InitializeComponent();
        }

       

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            gridControl1.DataSource= stokDal.GetAllJoin(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

      

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {

                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();

                stokDal.Delete(context, c=>c.StokKodu==secilen);
                stokDal.Save(context);
                GetAll();
            }
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokIslem form = new FrmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokIslem form = new FrmStokIslem(stokDal.GetByFilter(context,c=>c.StokKodu==secilen));
            form.ShowDialog();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            FrmStokIslem form = new FrmStokIslem(stokEntity);
            form.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokHareket form = new FrmStokHareket(secilen);
            form.ShowDialog();
        }
    }
}