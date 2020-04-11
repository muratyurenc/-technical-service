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
    public partial class FRMKATEGORİ : Form
    {
        public FRMKATEGORİ()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities kt = new DBTEKNIKSERVISEntities();
     public void kategorı()
        {
            var kategori = from k in kt.TBLKATEGORI
                           select new
                           {
                              k.ID,
                              k.AD
                           };
            gridControl1.DataSource = kategori.ToList();
        }
        private void FRMKATEGORİ_Load(object sender, EventArgs e)
        {

            kategorı();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI ekle = new TBLKATEGORI();
            ekle.AD = txtad.Text;
            kt.TBLKATEGORI.Add(ekle);
            kt.SaveChanges();

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            kategorı();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
                txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtıd.Text);
            var sil = kt.TBLKATEGORI.Find(id);
            kt.TBLKATEGORI.Remove(sil);
            kt.SaveChanges();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtıd.Text);
            var veriekle = kt.TBLKATEGORI.Find(ıd);
            veriekle.AD = txtad.Text;
            kt.SaveChanges();
        }

        private void btnlistele_Click_1(object sender, EventArgs e)
        {
            var kategori = from k in kt.TBLKATEGORI
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = kategori.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
