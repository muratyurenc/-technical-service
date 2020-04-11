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
    public partial class Frmcarilistesi : Form
    {
        public Frmcarilistesi()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmcarilistesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARI.ToList();

        }
    }
}
