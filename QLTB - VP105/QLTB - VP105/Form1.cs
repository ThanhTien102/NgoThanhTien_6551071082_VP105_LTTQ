using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace QLTB___VP105
{
    public partial class Form1 : Form
    {
        private String connectionString = @"Server=.;Database=DuLieu_ThietBi;Trusted_Connection=true;TrustServerCertificate=true";
        private string selectedMaTB = "";
        private bool isAdding = false;
        private bool isEditing = false;
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ThietBi", conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.Columns.Clear();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }

        }
        public void SetButtonState(bool isSelected)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = isSelected;
            btnXoa.Enabled = isSelected;
            btnThoat.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
            LoadData();
            SetButtonState(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtMaTB.Text = row.Cells["MaThietBi"].Value?.ToString() ?? "";
            txtTenTB.Text = row.Cells["TenThietBi"].Value?.ToString() ?? "";
            txtDonGia.Text = row.Cells["DonGia"].Value?.ToString() ?? "";

            selectedMaTB = txtMaTB.Text;
            SetButtonState(true);
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaTB.Text))
            {
                MessageBox.Show("Mã thiết bị không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenTB.Text))
            {
                MessageBox.Show("Tên thiết bị không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Đơn giá không được để trống.");
                return false;
            }
            if (!string.IsNullOrEmpty(txtDonGia.Text))
            {
                if (!decimal.TryParse(txtDonGia.Text, out _))
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho đơn giá.");
                    return false;
                }
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!ValidateInput())
            {
              
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO ThietBi (MaThietBi, TenThietBi, DonGia) VALUES (@MaThietBi, @TenThietBi, @DonGia)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThietBi", txtMaTB.Text);
                        cmd.Parameters.AddWithValue("@TenThietBi", txtTenTB.Text);
                        cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thiết bị thành công.");
                            LoadData();
                            txtTenTB.Clear();
                            txtDonGia.Clear();
                            txtMaTB.Clear();

                            isAdding = true;
                            txtMaTB.Enabled = true;
                            txtTenTB.Enabled = true;
                            txtDonGia.Enabled = true;

                            btnThem.Enabled = false;
                            btnSua.Enabled = false;
                            btnXoa.Enabled = false;
                            btnThoat.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm thiết bị.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Mã thiết bị đã tồn tại. Vui lòng sử dụng mã khác.");
                else
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaTB))
            {
                MessageBox.Show("Vui lòng chọn thiết bị để xóa.");
                return;
            }
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thiết bị {selectedMaTB}?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM ThietBi WHERE MaThietBi = @MaThietBi";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThietBi", selectedMaTB);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thiết bị thành công.");
                            LoadData();
                            selectedMaTB = "";
                            isAdding = false;
                            isEditing = false;

                            txtMaTB.Clear();
                            txtTenTB.Clear();
                            txtDonGia.Clear();

                            txtMaTB.Enabled = true;
                            txtTenTB.Enabled = true;
                            txtDonGia.Enabled = true;

                            btnThem.Enabled = true;
                            btnSua.Enabled = false;
                            btnXoa.Enabled = false;
                            btnThoat.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thiết bị để xóa.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa thiết bị: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE ThietBi SET TenThietBi = @TenThietBi, DonGia = @DonGia WHERE MaThietBi = @MaThietBi";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThietBi", txtMaTB.Text);
                        cmd.Parameters.AddWithValue("@TenThietBi", txtTenTB.Text);
                        cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thiết bị thành công.");
                            LoadData();

                            txtMaTB.Clear();
                            txtTenTB.Clear();
                            txtDonGia.Clear();



                            isEditing = false;
                            txtMaTB.Enabled = true;
                            txtTenTB.Enabled = true;
                            txtDonGia.Enabled = true;
                            SetButtonState(false);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thiết bị để cập nhật.");
                        }

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thiết bị: " + ex.Message);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
   

        }
    }
}

