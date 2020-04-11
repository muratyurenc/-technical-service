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
    public partial class FRM1YENİKATEGORİ : Form
    {
        public FRM1YENİKATEGORİ()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI ekle = new TBLKATEGORI();
            ekle.AD = txturunadı.Text;
            db.TBLKATEGORI.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Test");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
