using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlbh
{
    public partial class FrmDien : Form
    {
        int ThanhTien;
        public FrmDien()
        {
            InitializeComponent();
        }

        private void FrmDien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int csd= Convert.ToInt16(txtCsd.Text);
            int csc = Convert.ToInt16(txtCsc.Text);
            
            int TT = csc - csd;
            if (TT >= 0 && TT < 80)
            {
                ThanhTien = TT * 500;
            }
            else if (TT >= 80 && TT < 200)
                ThanhTien =80*500+( TT-80) * 1500;
            else if (TT >= 200)
                ThanhTien =80*500+120*1500+( TT-200) * 3000;
            lblSoTien.Text = Convert.ToString(ThanhTien);

        }
    }
}
