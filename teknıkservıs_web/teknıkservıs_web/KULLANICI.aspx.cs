using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using teknıkservıs_web.entites;

namespace teknıkservıs_web
{
    public partial class KULLANICI1 : System.Web.UI.Page
    {
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
          //  var degerler = db.TBLURUNTAKIP.ToList();
           // Repeater2.DataSource = degerler;
           // Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var degerler = db.TBLURUNTAKIP.Where(x => x.SERINO == TextBox1.Text);
            Repeater2.DataSource = degerler.ToList();
            Repeater2.DataBind();
        }
    }
}