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
    public partial class frmdepartman : Form
    {
        public frmdepartman()
        {
            InitializeComponent();
        }

        private void labelControl26_Click(object sender, EventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void frmdepartman_Load(object sender, EventArgs e)
        {
            var dep = (from x in db.TBLDEPARTMAN
                       select new
                       {
                           x.ID,
                           x.AD,
                           x.ACIKLAMA
                       });
            gridControl1.DataSource = dep.ToList();
            labelControl21.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl23.Text = db.TBLPERSONEL.Count().ToString();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN dp = new TBLDEPARTMAN();
            if (txtad.Text.Length<=50 && txtad.Text !="" && richTextBox1.Text.Length >=1)
            {

                dp.AD = txtad.Text;
                dp.ACIKLAMA = richTextBox1.Text;
                db.TBLDEPARTMAN.Add(dp);
                db.SaveChanges();
                MessageBox.Show("kayıt eklendi");
            }
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtıd.Text);
            var verisil = db.TBLDEPARTMAN.Find(ıd);
            db.TBLDEPARTMAN.Remove(verisil);
            db.SaveChanges();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtıd.Text);
            var veriekle = db.TBLDEPARTMAN.Find(ıd);
            veriekle.AD = txtad.Text;
            veriekle.ACIKLAMA = richTextBox1.Text;
            db.SaveChanges();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            var dep = (from x in db.TBLDEPARTMAN
                       select new
                       {
                           x.ID,
                           x.AD,
                           x.ACIKLAMA
                       });
            gridControl1.DataSource = dep.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
          richTextBox1.Text= gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }
    }
}
