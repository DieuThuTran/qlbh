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
    public partial class FrmMT : Form
    {
        double data1, data2;
        string pheptinh;
        public FrmMT()
        {
            InitializeComponent();
        }
       

        private void FrmMT_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                txthienthi2.Text = data1.ToString() + " + " + float.Parse(txthienthi1.Text) + " = ";
                data2 = data1 + float.Parse(txthienthi1.Text);
                txthienthi1.Text = data2.ToString();
            }
            if (pheptinh == "tru")
            {
                txthienthi2.Text = data1.ToString() + " - " + float.Parse(txthienthi1.Text) + " = ";
                data2 = data1 - float.Parse(txthienthi1.Text);
                txthienthi1.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                txthienthi2.Text = data1.ToString() + " x " + float.Parse(txthienthi1.Text) + " = ";
                data2 = data1 * float.Parse(txthienthi1.Text);
                txthienthi1.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if (float.Parse(txthienthi1.Text) == 0)
                {
                    txthienthi2.Text = data1.ToString() + " / " + float.Parse(txthienthi1.Text) + " = ";
                    txthienthi1.Text = "Mau so khac 0";
                }
                else
                {
                    txthienthi2.Text = data1.ToString() + " / " + float.Parse(txthienthi1.Text) + " = ";
                    data2 = data1 / float.Parse(txthienthi1.Text);
                    txthienthi1.Text = data2.ToString();
                }

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "2";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txthienthi1.Text += "8";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txthienthi1.Clear();
            txthienthi2.Clear();

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            txthienthi2.Text = data1.ToString() + " * ";
            data1 = float.Parse(txthienthi1.Text);
            txthienthi1.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            txthienthi2.Text = data1.ToString() + " - ";
            data1 = float.Parse(txthienthi1.Text);
            txthienthi1.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            txthienthi2.Text = data1.ToString() + " + ";
            data1 = float.Parse(txthienthi1.Text);
            txthienthi1.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            txthienthi2.Text = data1.ToString() + " / ";
            data1 = float.Parse(txthienthi1.Text);
            txthienthi1.Clear();
        }

        private void txthienthi1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
