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
    
    public partial class Form2 : Form
    {
        string connection = @"Data Source=ADMIN;Initial Catalog=QLNHAHANG;Persist Security Info=True;User ID=sa;Password=Trunghieu@191004";
        SqlConnection conn = null;
        public Form2()
        {
            InitializeComponent();
        }
        private DataTable getData(string query, SqlParameter[] parameters = null)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                var dt = new DataTable();
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        private void run(string query, SqlParameter[] parameters = null)
        {
            using (var conn = new SqlConnection(connection))
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
            }
        }
        private void LoadData()
        {
            string query = "SELECT MON.MA_MON, MON.MA_LOAI_MON, MON.TEN_MON, MON.DON_VI, MON.DON_GIA, LOAI_MON.TEN_LOAI_MON " +
                  "FROM MON INNER JOIN LOAI_MON ON MON.MA_LOAI_MON = LOAI_MON.MA_LOAI_MON";
            dtgvMon.DataSource = getData(query);
        }

        private void LoadLoaiMon()
        {
            string query = "SELECT MA_LOAI_MON, TEN_LOAI_MON FROM LOAI_MON";
            cbLoaiMon.DataSource = getData(query);
            cbLoaiMon.DisplayMember = "TEN_LOAI_MON";
            cbLoaiMon.ValueMember = "MA_LOAI_MON";
        }
        private void ClearInputs()
        {
            txbMaMon.Clear();
            txbTenMon.Clear();
            txbDVT.Clear();
            txbDonGia.Clear();
            cbLoaiMon.SelectedIndex = -1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadLoaiMon();
            LoadData();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MON (MA_LOAI_MON, TEN_MON, DON_VI, DON_GIA) VALUES (@maLoaiMon, @tenMon, @donVi, @donGia)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@maLoaiMon", cbLoaiMon.SelectedValue),
                new SqlParameter("@tenMon", txbTenMon.Text),
                new SqlParameter("@donVi", txbDVT.Text),
                new SqlParameter("@donGia", txbDonGia.Text)
            };
            run(query, parameters);
            ClearInputs();
            LoadData();
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            string query = "UPDATE MON SET MA_LOAI_MON = @maLoaiMon, TEN_MON = @tenMon, DON_VI = @donVi, DON_GIA = @donGia WHERE MA_MON = @maMon";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@maMon", txbMaMon.Text),
                new SqlParameter("@maLoaiMon", cbLoaiMon.SelectedValue),
                new SqlParameter("@tenMon", txbTenMon.Text),
                new SqlParameter("@donVi", txbDVT.Text),
                new SqlParameter("@donGia", txbDonGia.Text)
            };
            run(query, parameters);
            ClearInputs();
            LoadData();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaMon.Text))
            {
                MessageBox.Show("Vui lòng chọn món ăn để xóa.");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM MON WHERE MA_MON = @maMon";
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@maMon", txbMaMon.Text)
                };
                run(query, parameters);
                ClearInputs();
                LoadData();
            }
        }

        private void btnReloadMon_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnTimKiemMon_Click(object sender, EventArgs e)
        {
            string query = "SELECT MON.MA_MON, MON.TEN_MON, MON.DON_VI, MON.DON_GIA, LOAI_MON.TEN_LOAI_MON " +
                           "FROM MON INNER JOIN LOAI_MON ON MON.MA_LOAI_MON = LOAI_MON.MA_LOAI_MON WHERE 1=1";

            var parameters = new List<SqlParameter>();

            if (ckbTKTenMon.Checked && !string.IsNullOrWhiteSpace(txbTenMon.Text))
            {
                query += " AND MON.TEN_MON LIKE @tenMon";
                parameters.Add(new SqlParameter("@tenMon", $"%{txbTenMon.Text}%"));
            }
            if (ckbTKDonGia.Checked && !string.IsNullOrWhiteSpace(txbDonGia.Text))
            {
                query += " AND MON.DON_GIA = @donGia";
                parameters.Add(new SqlParameter("@donGia", txbDonGia.Text));
            }
            if (ckbTKLoaiMon.Checked && cbLoaiMon.SelectedValue != null)
            {
                query += " AND MON.MA_LOAI_MON = @maLoaiMon";
                parameters.Add(new SqlParameter("@maLoaiMon", cbLoaiMon.SelectedValue));
            }

            dtgvMon.DataSource = getData(query, parameters.ToArray());
        }

        private void dtgvMon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvMon.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txbMaMon.Text = dtgvMon.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbTenMon.Text = dtgvMon.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbDVT.Text = dtgvMon.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbDonGia.Text = dtgvMon.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbLoaiMon.Text = dtgvMon.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void dtgvMon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
