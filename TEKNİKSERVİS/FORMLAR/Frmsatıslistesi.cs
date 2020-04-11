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
    public partial class Frmsatıslistesi : Form
    {
        public Frmsatıslistesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmsatıslistesi_Load(object sender, EventArgs e)
        {
           
            var ekle = (from x in db.TBLURUNHAREKET
                        select new
                        {
                            x.HAREKETID,
                            x.TBLURUN.AD,
                          MUSTERI=x.TBLCARI.AD + " " +x.TBLCARI.SOYAD,
                            x.PERSONEL,
                            x.TARIH,
                            x.ADET,
                            x.FIYAT,
                            x.URUNSERINO

                        }).ToList();
            gridControl1.DataSource = ekle;

        }
    }
}