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
    public partial class Frmarızalıurunkaydı : Form
    {
        public Frmarızalıurunkaydı()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
           t.CARI = int.Parse(txtsmüş.Text);
            t.PERSONEL = short.Parse(txtper.Text);
            t.GELISTARIHI = DateTime.Parse(txttar.Text);
            t.URUNSERINO = textserıno.Text;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("kaydedildiss");
        }
    }
}
