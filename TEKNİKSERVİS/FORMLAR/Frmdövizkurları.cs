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
    public partial class Frmdövizkurları : Form
    {
        public Frmdövizkurları()
        {
            InitializeComponent();
        }

        private void Frmdövizkurları_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
        }
    }
}
