using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CThoadon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            dgvCT.DataSource = database.GetData(
                @"SELECT SoHD AS [Số HĐ],
                         TenSP AS [Sản phẩm],
                         SoLuong AS [SL],
                         DonGia AS [Đơn giá],
                         SoLuong * DonGia AS [Thành tiền]
                  FROM ChiTietHoaDon
                  ORDER BY SoHD");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoHD.Text))
            {
                LoadAll();
            }
            else
            {
                dgvCT.DataSource = database.GetData(
                    @"SELECT SoHD AS [Số HĐ],
                             TenSP AS [Sản phẩm],
                             SoLuong AS [SL],
                             DonGia AS [Đơn giá],
                             SoLuong * DonGia AS [Thành tiền]
                      FROM ChiTietHoaDon
                      WHERE SoHD LIKE @s",
                    new SqlParameter("@s", "%" + txtSoHD.Text + "%"));
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quay về trang chủ!");
        }

        private void dgvCT_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
    }
}
