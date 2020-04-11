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
    public partial class Frmfaturaarama : Form
    {
        public Frmfaturaarama()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textEdit1.Text);
            var getir = (from x in db.TBLFATURADETAY
                         select new
                         {
                             x.FATURADETAYID,
                             x.URUN,
                             x.ADET,
                             x.FIYAT,
                             x.TUTAR,
                             x.FATURAID,
                         }).Where(x => x.FATURAID == id);
            gridControl1.DataSource = getir.ToList();
        }
    }
}
