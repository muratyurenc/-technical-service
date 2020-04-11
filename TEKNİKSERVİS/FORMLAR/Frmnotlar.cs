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
    public partial class Frmnotlar : Form
    {
        public Frmnotlar()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmnotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == true).ToList();
        }

      
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM ekle = new TBLNOTLARIM();

            ekle.BASLIK = txtbaslık.Text;
            ekle.ICERIK = txtacıklama.Text;
            ekle.DURUM = false;
            db.TBLNOTLARIM.Add(ekle);
            db.SaveChanges();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == true).ToList();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                int ıd = int.Parse(txtıd.Text);
                var veriekle = db.TBLNOTLARIM.Find(ıd);
                veriekle.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Mesaj okundu!");
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
          
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}