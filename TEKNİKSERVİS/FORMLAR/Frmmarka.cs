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
    public partial class Frmmarka : Form
    {
        public Frmmarka()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();

        private void Frmmarka_Load(object sender, EventArgs e)
        {
            var getir = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                MARKA = z.Key,
                toplam = z.Count()
            });
            gridControl1.DataSource = getir.ToList();
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl5.Text = (from x in db.TBLURUN
                                  select x.MARKA).Distinct().Count().ToString();
            labelControl3.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending
                                  select x.AD).FirstOrDefault();
            chartControl2.Series["Series 1"].Points.AddPoint("siemens", 8);
            chartControl2.Series["Series 1"].Points.AddPoint("arcelik", 7);
            chartControl2.Series["Series 1"].Points.AddPoint("beko", 9);
            chartControl2.Series["Series 1"].Points.AddPoint("bosh", 4);
            chartControl2.Series["Series 1"].Points.AddPoint("suny", 3);
            chartControl2.Series["Series 1"].Points.AddPoint("vestel", 2);

            chartControl3.Series["Kategoriler"].Points.AddPoint("siemens", 8);
            chartControl3.Series["Kategoriler"].Points.AddPoint("arcelik", 7);
            chartControl3.Series["Kategoriler"].Points.AddPoint("beko", 9);
            chartControl3.Series["Kategoriler"].Points.AddPoint("bosh", 4);
            chartControl3.Series["Kategoriler"].Points.AddPoint("suny", 3);
            chartControl3.Series["Kategoriler"].Points.AddPoint("vestel", 2);
        }
    }
}