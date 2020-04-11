using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TEKNİKSERVİS.FORMLAR
{
    public partial class Frmqrcode : Form
    {
        public Frmqrcode()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder cr = new QRCodeEncoder();
            pictureEdit1.Image =cr.Encode( textEdit1.Text);
        }
    }
}
