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
    public partial class Frmarızalıüründetayları : Form
    {
        public Frmarızalıüründetayları()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmarızalıüründetayları_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUNTAKIP
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.SERINO,
                                          x.TARIH,
                                          x.ACIKLAMA
                                      }).ToList();

        }
    }
}
