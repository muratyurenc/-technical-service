using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNİKSERVİS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnürünlistesiformu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FRMÜRÜNLİSİTESİ fr = new FORMLAR.FRMÜRÜNLİSİTESİ();
            fr.MdiParent = this;
            fr.Show();


        }

        private void btnyenıurun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.FRMYENİÜRÜN fr = new FORMLAR.FRMYENİÜRÜN();
            fr.Show();

        }

        FORMLAR.FRMKATEGORİ fr2;
        private void btnkategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FORMLAR.FRMKATEGORİ();
                fr2.MdiParent = this;
                fr2.Show();
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FORMLAR.FRM1YENİKATEGORİ YR = new FORMLAR.FRM1YENİKATEGORİ();
            YR.Show();

        }

        private void btnistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmistatistik fr = new FORMLAR.Frmistatistik();
            fr.MdiParent = this;
            fr.Show();


        }

        private void markaistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmmarka fr = new FORMLAR.Frmmarka();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FORMLAR.Frmcarilistesi fr = new FORMLAR.Frmcarilistesi();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frkcariiller fr = new FORMLAR.Frkcariiller();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmyenicarıekle fr = new FORMLAR.Frmyenicarıekle();
          
            fr.Show();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.frmdepartman fr = new FORMLAR.frmdepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmyenidepartman fr = new FORMLAR.Frmyenidepartman();
            fr.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmpersonel fr = new FORMLAR.Frmpersonel();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnhesapmakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmdövizkurları fr = new FORMLAR.Frmdövizkurları();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmyoutube fr = new FORMLAR.Frmyoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void AJANDA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmnotlar fr = new FORMLAR.Frmnotlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmarızalistesi fr = new FORMLAR.Frmarızalistesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmurunsatıs fr = new FORMLAR.Frmurunsatıs();

            fr.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmsatıslistesi fr = new FORMLAR.Frmsatıslistesi();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmarızalıurunkaydı fr = new FORMLAR.Frmarızalıurunkaydı();

            fr.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmarızalıurunacıklama fr = new FORMLAR.Frmarızalıurunacıklama();

            fr.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmarızalıüründetayları fr = new FORMLAR.Frmarızalıüründetayları();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmqrcode fr = new FORMLAR.Frmqrcode();

            fr.Show();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmfaturalistesi fr = new FORMLAR.Frmfaturalistesi();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmfaturakalem fr = new FORMLAR.Frmfaturakalem();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmfaturaarama fr = new FORMLAR.Frmfaturaarama();
            fr.MdiParent = this;
            fr.Show();

        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FORMLAR.Frmraporlar fr = new FORMLAR.Frmraporlar();
        
            fr.Show();

        }
        FORMLAR.FrmANASAYFA fr;
        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FORMLAR.FrmANASAYFA();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr == null)
            {
                fr = new FORMLAR.FrmANASAYFA();
                fr.MdiParent = this;
                fr.Show();
            }

        }
}
}
