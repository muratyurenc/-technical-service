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
    public partial class Frmfaturalistesi : Form
    {
        public Frmfaturalistesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmfaturalistesi_Load(object sender, EventArgs e)
        {
            var ekle = from x in db.TBLFATURABILGI
                       select new
                       {
                           x.ID,
                           x.SERI,
                           x.SIRANO,
                           x.TARIH,
                           x.SAAT,
                           x.VERGIDAIRE,
                           Carı = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                           PERSONELl = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD
                       };
            gridControl1.DataSource = ekle.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD

                                                 }).ToList();
            lookUpEdit3.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + x.SOYAD

                                                 }).ToList();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = txtserı.Text;
            t.SIRANO = txtsırano.Text;
            t.TARIH = Convert.ToDateTime(txttarıh.Text);
            t.SAAT = txtsaat.Text;
            t.VERGIDAIRE = txtvergi.Text;
            t.CARI = int.Parse( lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit3.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Test");

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

            var ekle = from x in db.TBLFATURABILGI
                       select new
                       {
                           x.ID,
                           x.SERI,
                           x.SIRANO,
                           x.TARIH,
                           x.SAAT,
                           x.VERGIDAIRE,
                           Carı = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                           PERSONELl = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD
                       };
            gridControl1.DataSource = ekle.ToList();
        }
    }
}