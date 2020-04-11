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
    public partial class FRMÜRÜNLİSİTESİ : Form
    {
        public FRMÜRÜNLİSİTESİ()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();

        public void urunveriler()
        {
            var veriler = from u in db.TBLURUN
                          select new
                          {
                              u.ID,
                              u.AD,
                              u.MARKA,
                              KATEGORI = u.TBLKATEGORI.AD,
                              u.ALISFIYAT,
                              u.SATISFIYAT,
                              u.STOK,


                          };
            gridControl1 .DataSource = veriler.ToList();
        }
        private void FRMÜRÜNLİSİTESİ_Load(object sender, EventArgs e)
        {

            urunveriler();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();


        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLURUN tb = new TBLURUN();
            tb.AD = txturunad.Text;
            tb.MARKA = txtmarka.Text;
            tb.ALISFIYAT = Convert.ToDecimal(txtalısfıyat.Text);
            tb.SATISFIYAT = Convert.ToDecimal (txtsatısfıyat.Text);
            tb.STOK = short.Parse(txtstok.Text);
            tb.DURUM = false;
            tb.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(tb);
            db.SaveChanges();
            MessageBox.Show("kayıt eklendi", "bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtstok_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            urunveriler();
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txturunad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtalısfıyat.Text  = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
             txtsatısfıyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtstok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();

        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtıd.Text);
            var verisil = db.TBLURUN.Find(ıd);
            db.TBLURUN.Remove(verisil);
            db.SaveChanges();

        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtıd.Text);
            var veriekle = db.TBLURUN.Find(ıd);
            veriekle.AD = txturunad.Text;
            veriekle.MARKA = txtmarka.Text;
            veriekle.ALISFIYAT = decimal.Parse(txtalısfıyat.Text);
            veriekle.STOK = short.Parse(txtstok.Text);
            veriekle.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            veriekle.SATISFIYAT = decimal.Parse(txtsatısfıyat.Text);
            db.SaveChanges();


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
