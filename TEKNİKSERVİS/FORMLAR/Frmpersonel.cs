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
    public partial class Frmpersonel : Form
    {
        public Frmpersonel()
        {
            InitializeComponent();
        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmpersonel_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLPERSONEL
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.FOTOGRAF,
                               x.MAIL,
                               x.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
            string ad, soyad, ad2, soyad2,ad3,soy3,ad4,soy4;
            ad = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl2.Text = ad + "  " + soyad;
            labelControl3.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl5.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            //personel 2

            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl20.Text = ad + "  " + soyad;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl7.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            //personel 3
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soy3= db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl27.Text = ad3 + "  " + soy3;
            labelControl25.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl23.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            //personel 4
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soy4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl33.Text = ad4 + "  " + soy4;
            labelControl31.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl29.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;
        }
    }
}
