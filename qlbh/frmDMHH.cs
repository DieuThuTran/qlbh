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


namespace qlbh
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5GJIHLS\\SQLEXPRESS;Initial Catalog=QLBH;"+
                "Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MaNhom,MaHH,TenHH,Dvt,DGvnd,SanXuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            GrdData.DataSource = dt;
            NapCT();
        }

        private void GrdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, 0];
            NapCT();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            GrdData.CurrentCell = GrdData[0, GrdData.RowCount - 1];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = GrdData.CurrentRow.Index;
            if(i>0)
            {
                GrdData.CurrentCell = GrdData[0, i - 1];
                NapCT();
            }    
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            i = GrdData.CurrentRow.Index;
            if(i<GrdData.RowCount-1)
            {
                GrdData.CurrentCell = GrdData[0, i + 1];
                NapCT();
            }    
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "Select Distinct " + comTruong.Text + " From tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGT.DataSource = comdt;
            comGT.DisplayMember = comTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (comTruong.Text == "")
            {
                MessageBox.Show("Bạn cần thiết lập điều kiện lọc trước đã");
            }
            else
            {

            
                sql = "select MaNhom,MaHH,TenHH,Dvt,DGvnd,SanXuat from tblDMHH" +
                    " where " + comTruong.Text + "='" + comGT.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt.Clear();
             
                da.Fill(dt);
                GrdData.DataSource = dt;
                GrdData.Refresh();
                NapCT();
            }    
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {

            sql = "select MaNhom,MaHH,TenHH,Dvt,DGvnd,SanXuat from tblDMHH";
              
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();

            da.Fill(dt);
            GrdData.DataSource = dt;
            GrdData.Refresh();
            NapCT();
        }

        private void NapCT()
        {
            i = GrdData.CurrentRow.Index;
            txtMaNhom.Text = GrdData.Rows[i].Cells["MaNhom"].Value.ToString();
            txtMaHH.Text = GrdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text = GrdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDvt.Text = GrdData.Rows[i].Cells["Dvt"].Value.ToString();
            txtDGvnd.Text = GrdData.Rows[i].Cells["DGvnd"].Value.ToString();
            txtSanXuat.Text = GrdData.Rows[i].Cells["SanXuat"].Value.ToString();


        }
    }
}
