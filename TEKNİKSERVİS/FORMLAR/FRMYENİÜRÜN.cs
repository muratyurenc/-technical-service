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
    public partial class FRMYENİÜRÜN : Form
    {
        public FRMYENİÜRÜN()
        {
            InitializeComponent();
        }

        private void FRMYENİÜRÜN_Load(object sender, EventArgs e)
        {

        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
           // FRMYENİÜRÜN fr = new FRMYENİÜRÜN();
            //fr.Hide();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            DBTEKNIKSERVISEntities tr = new DBTEKNIKSERVISEntities();
            TBLURUN ekle = new TBLURUN();
            ekle.AD = txturunadı.Text;
            ekle.MARKA = txtmarkası.Text;
            ekle.ALISFIYAT = decimal.Parse(txtalış.Text);
            ekle.SATISFIYAT = decimal.Parse(txtsatış.Text);
            ekle.STOK = short.Parse(txtstok.Text);
            ekle.KATEGORI = byte.Parse(txtkategorı.Text);
            tr.TBLURUN.Add(ekle);
            tr.SaveChanges();
            MessageBox.Show("yeni ürün eklendi");

        }
    }
}
