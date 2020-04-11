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
    public partial class FrmANASAYFA : Form
    {
        public FrmANASAYFA()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmANASAYFA_Load(object sender, EventArgs e)
        {
            var ekle = (from x in db.TBLURUN
                        select new
                        {
                            x.AD,
                            x.STOK
                        }).Where(X => X.STOK <= 100);
            gridControl1.DataSource = ekle.ToList();


            gridControl2.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE
                                       }).ToList();
            gridControl3.DataSource = db.URUNKATEGORI().ToList();
            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where x.TARIH == bugun
                          select
                          new
                      {
                x.BASLIK,
                  x.ICERIK
                  });
            gridControl7.DataSource = deger.ToList();
             
        }
    }
}
