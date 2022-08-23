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
using NetSatis.Entities.Validations;

namespace NetSatis.BackOffice.Stok
{

    public partial class FrmStokIslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDal stokDal = new StokDal();
        private NetSatisContext context = new NetSatisContext();

        public FrmStokIslem(Entities.Tables.Stok entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtStokKodu.DataBindings.Add("Text", _entity, "StokKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBirimi.DataBindings.Add("Text", _entity, "Birimi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi", false, DataSourceUpdateMode.OnPropertyChanged);
            calcMaxStokMiktari.DataBindings.Add("EditValue", _entity, "MaxStokMiktari", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            calcMinStokMiktari.DataBindings.Add("EditValue", _entity, "MinStokMiktari", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N3");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnMarka.DataBindings.Add("Text", _entity, "Marka", false, DataSourceUpdateMode.OnPropertyChanged);
            btnModel.DataBindings.Add("Text", _entity, "Modeli", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisKdv.DataBindings.Add("EditValue", _entity, "AlisKdv", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            calcSatisKdv.DataBindings.Add("EditValue", _entity, "SatisKdv", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            calcAlisFiyati1.DataBindings.Add("EditValue", _entity, "AlisFiyati1", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcAlisFiyati2.DataBindings.Add("EditValue", _entity, "AlisFiyati2", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcAlisFiyati3.DataBindings.Add("EditValue", _entity, "AlisFiyati3", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcSatisFiyati1.DataBindings.Add("EditValue", _entity, "SatisFiyati1", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcSatisFiyati2.DataBindings.Add("EditValue", _entity, "SatisFiyati2", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcSatisFiyati3.DataBindings.Add("EditValue", _entity, "SatisFiyati3", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
        }



        private void FrmStokIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (stokDal.AddOrUpdate(context, _entity))
            {
                stokDal.Save(context);
                this.Close();
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
