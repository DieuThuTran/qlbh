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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
                f.Show();
        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tổngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmltcb f = new Frmltcb();
            f.Show(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void táchTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmtt f = new Frmtt();
            f.Show();
        }

        private void tínhTiềnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDien f = new FrmDien();
            f.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDN f = new FrmDN();
            f.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            ttlbl.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            trangthai1.Text = "Sẵn sàng nhận lệnh";
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ttlbl.Text = DateTime.Now.ToString();

        }

        private void dMHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();

        }

        private void dMNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMNCC f = new frmDMNCC();
            f.Show();
        }
    }
}
