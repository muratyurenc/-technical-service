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
    public partial class Frmurunsatıs : Form
    {
        public Frmurunsatıs()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET ht = new TBLURUNHAREKET();
            ht.URUN = int.Parse(txtıd.Text);
            ht.MUSTERI = int.Parse(txtsmüş.Text);
            ht.PERSONEL = short.Parse(txtper.Text);
            ht.TARIH = DateTime.Parse( txttar.Text);
            ht.ADET = short.Parse(txtadet.Text);
            ht.FIYAT = decimal.Parse(txtsatıs.Text);
            ht.URUNSERINO = textserıno.Text;
            db.TBLURUNHAREKET.Add(ht);
            db.SaveChanges();
            MessageBox.Show("ŞATIŞ YAPILDI");

        }
    }
}
