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
    public partial class Frmarızalistesi : Form
    {
        public Frmarızalistesi()
        {
            InitializeComponent();
        }
        
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmarızalistesi_Load(object sender, EventArgs e)
        {
            var ekle = from x in db.TBLURUNKABUL
                       select new
                       {
                           x.ID,
                           CARİ = x.TBLCARI.AD,
                           personel = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                           x.GELISTARIHI,
                           x.CIKISTARIHI,
                           x.URUNSERINO
                       };
            gridControl1.DataSource = ekle.ToList();

        }
    }
}
