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
    public partial class frmDMNCC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public frmDMNCC()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string sqlINSET = "INSERT INTO DMNCC VALUES (@MaNCC,@TenNCC,@DiaChi,@SDT,@Email)";
            SqlCommand cmd = new SqlCommand(sqlINSET, conn);
            cmd.Parameters.AddWithValue("MaNCC", txtMNCC.Text);
            cmd.Parameters.AddWithValue("TenNCC", txtTNCC.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDC.Text);
            cmd.Parameters.AddWithValue("MaSDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("Email", txtEMAIL.Text);
            cmd.ExecuteNonQuery();
            
        }

        private void frmDMNCC_Load(object sender, EventArgs e)
        {
            constr = " Data Source=LAPTOP-I5GJIHLS\\SQLEXPRESS;Initial Catalog=QLBT;" +
                "Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from DMNCC";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            GrdData.DataSource = dt;
        }
    }
}
