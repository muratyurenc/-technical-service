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
    public partial class Frmyenidepartman : Form
    {
        public Frmyenidepartman()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
                private void btnkaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN dp = new TBLDEPARTMAN();
            if (txtdptad.Text.Length <= 50 && txtdptad.Text != "")
            {

                dp.AD = txtdptad.Text;   
                db.TBLDEPARTMAN.Add(dp);
                db.SaveChanges();
                MessageBox.Show("kayıt eklendi");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyin");
            }



        }
    }
}
