using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            using (var context= new NetSatisContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NetSatisContext context = new NetSatisContext();
            //CariDal cariDal = new CariDal();
            //Cari entity = new Cari
            //{
            //    CariKodu = "123456"
            //};
            //cariDal.AddOrUpdate(context,entity);
            //cariDal.Save(context);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.MdiParent=this;
            form.Show();
        }
    }
}
