using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using teknıkservıs_web.entites;

namespace teknıkservıs_web
{
    public partial class ddefault : System.Web.UI.Page
    {
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBLURUN.ToList();
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLİLETİŞİM tf = new TBLİLETİŞİM();
            tf.ADSOYAD = TextBox1.Text;
            tf.MAIL = TextBox2.Text;
            tf.KONU = TextBox3.Text;
            tf.MESAJ = TextBox4.Text;
            db.TBLİLETİŞİM.Add(tf);
            db.SaveChanges();
        }
    }
}