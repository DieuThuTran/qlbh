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
    public partial class Frmtt : Form
    {
        public Frmtt()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))

            {

                MessageBox.Show("Chưa nhập họ tên");

                txtHoTen.Focus();

            }

            else

            {

                string input = txtHoTen.Text.Trim();

                string[] arr = input.Split(' ');

                if (arr.Length >= 2)

                {

                    string ho = arr[0];

                    string ten = arr[arr.Length - 1];

                    lblHo.Text = ho;

                    lblTen.Text = ten;

                    string chuLot = "";

                    if (arr.Length > 2)

                    {

                        for (int i = 1; i < arr.Length - 1; i++)

                        {

                            chuLot += arr[i] + " ";

                        }

                    }

                    lblDem.Text = chuLot;

                }

                else

                {

                    if (arr.Length <= 1)

                    {

                        MessageBox.Show("Họ tên chưa đầy đủ");

                        txtHoTen.Focus();

                    }

                }

            }

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
  
