using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlxm
{
    public partial class ThueXe : Form
    {
        public ThueXe()
        {
            InitializeComponent();
            loadxelist();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {

            QuanLi f = new QuanLi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnthuexe_Click(object sender, EventArgs e)
        {
            khachhang f = new khachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btntraxe_Click(object sender, EventArgs e)
        {
            Xuathoadon f = new Xuathoadon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        void loadxelist()
        {
            string connectionSTR = @"Data Source = DESKTOP - HD08O0U; Initial Catalog = QLCTXM; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "select*from Xe";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dataGridView1.DataSource = data;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
