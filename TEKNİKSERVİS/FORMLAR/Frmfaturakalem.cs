using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS.FORMLAR
{
    public partial class Frmfaturakalem : Form
    {
        public Frmfaturakalem()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY ft = new TBLFATURADETAY();
            ft.URUN =int.Parse( txturun.Text);
            ft.ADET = short.Parse(txtadet.Text);
            ft.FIYAT = decimal.Parse(txtfiyat.Text);
            ft.TUTAR = decimal.Parse(txttutar.Text);
            int v= int.Parse(txtfaturaıd.Text);
            ft.FATURAID = v;
            db.TBLFATURADETAY.Add(ft);
            db.SaveChanges();
            MessageBox.Show("Test");

        }

        private void Frmfaturakalem_Load(object sender, EventArgs e)
        {
            var getir = (from x in db.TBLFATURADETAY
                         select new
                         {
                             x.FATURADETAYID,
                             x.URUN,
                             x.ADET,
                             x.FIYAT,
                             x.TUTAR,
                             x.FATURAID,
                         });
            gridControl1.DataSource =getir.ToList();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            var getir = (from x in db.TBLFATURADETAY
                         select new
                         {
                             x.FATURADETAYID,
                             x.URUN,
                             x.ADET,
                             x.FIYAT,
                             x.TUTAR,
                             x.FATURAID,
                         });
            gridControl1.DataSource = getir.ToList();
        }
    }
}
