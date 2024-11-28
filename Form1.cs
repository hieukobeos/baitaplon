using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class Form1 : Form
    {
        string connection = @"Data Source=ADMIN;Initial Catalog=QLNHAHANG;Persist Security Info=True;User ID=sa;Password=Trunghieu@191004";
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable getData(string query)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                var com = new SqlCommand(query, conn);
                var dt = new DataTable();
                var da = new SqlDataAdapter(com);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        private bool run(string query)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                var com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                return true;
            }
        }

        private void LoadData()
        {
            string query = "SELECT * FROM LOAI_MON";
            dtgvLoaiMon.DataSource = getData(query);
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ClearInputs()
        {
            txbMaLoai.Clear();
            txbTenLoai.Clear();
        }
        private void btnThemLoaiMon_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO LOAI_MON (TEN_LOAI_MON) VALUES (@tenLoai)";
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tenLoai", txbTenLoai.Text);
                cmd.ExecuteNonQuery();
            }
            string checkIdentQuery = "DBCC CHECKIDENT ('LOAI_MON', RESEED)";
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                var cmd = new SqlCommand(checkIdentQuery, conn);
                cmd.ExecuteNonQuery();
            }

            ClearInputs();
            LoadData();
        }

        private void btnSuaLoaiMon_Click(object sender, EventArgs e)
        {
            string query = "UPDATE LOAI_MON SET TEN_LOAI_MON = @tenLoai WHERE MA_LOAI_MON = @maLoai";
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maLoai", txbMaLoai.Text);
                cmd.Parameters.AddWithValue("@tenLoai", txbTenLoai.Text);
                cmd.ExecuteNonQuery();
            }
            ClearInputs();
            LoadData();
        }

        private void btnXoaLoaiMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn loại món để xóa.");
                return;
            }
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại món này không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM LOAI_MON WHERE MA_LOAI_MON = @maLoai";
                using (var conn = new SqlConnection(connection))
                {
                    conn.Open();
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maLoai", txbMaLoai.Text);
                    cmd.ExecuteNonQuery();
                }
                ClearInputs();
                LoadData();
                MessageBox.Show("Xóa loại món thành công.");
            }
        }

        private void btnTimKiemLoaiMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMaLoai.Text))
            {
                MessageBox.Show("Hãy nhập mã loại món cần tìm!");
                return;
            }

            var dt = getData($"SELECT * FROM LOAI_MON WHERE MA_LOAI_MON LIKE '%{txbMaLoai.Text}%'");
            if (dt.Rows.Count > 0)
            {
                dtgvLoaiMon.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy loại món nào!");
            }
        }

        private void dtgvLoaiMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvLoaiMon.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txbMaLoai.Text = dtgvLoaiMon.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbTenLoai.Text =dtgvLoaiMon.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void dtgvLoaiMon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
