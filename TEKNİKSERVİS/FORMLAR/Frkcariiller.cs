using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TEKNİKSERVİS.FORMLAR
{
    public partial class Frkcariiller : Form
    {
        public Frkcariiller()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        SqlConnection con = new SqlConnection(@"Data Source=MEDELL\SQLEXPRESS;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");

        private void Frkcariiller_Load(object sender, EventArgs e)
        {
            //  chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            //    chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 35);
            // chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 13);
            // chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 15);
            // chartControl1.Series["Series 1"].Points.AddPoint("Urfa", 15);

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new
            {
                il = z.Key,
                toplam = z.Count()
            }).ToList();
            con.Open();
            SqlCommand kmt = new SqlCommand("select IL,COUNT(*) FROM TBLCARI group by IL", con);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            con.Close();
        }
    }
}
