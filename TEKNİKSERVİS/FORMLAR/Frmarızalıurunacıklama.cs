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
    public partial class Frmarızalıurunacıklama : Form
    {
        public Frmarızalıurunacıklama()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = richTextBox1.Text;
            t.TARIH = DateTime.Parse(textEdit2.Text);
            t.SERINO = textEdit1.Text;
            db.TBLURUNTAKIP.Add(t);
            db.SaveChanges();
            MessageBox.Show("Test");
        }
    }
}
