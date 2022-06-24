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
    public partial class Frmltcb : Form
    {
        int i, n, T;

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            i = 1;
            while(i<=n)
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            lblKQ.Text = "Tinh tong dung while la: " + Convert.ToString(T);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            while (i <= n);
            lblKQ.Text = "Tinh tong dung do la: " + Convert.ToString(T);

        }

        public Frmltcb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            for (i = 1; i <= n; i++)
            {
                if (i%2 == 0)
                {
                    T = T + i;
                }
            }
            lblKQ.Text = "Tinh tong dung for la: " + Convert.ToString(T);
        }
    }
}
