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
using DTO;
using BUS;
using System.IO;
using System.Drawing.Imaging;
namespace DXApplication1
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        string str1, str2, linkanh;
        HardCode cod = new HardCode();
        public string strMANV
        {
            get { return str1; }
            set { str1 = value; }
        }
        public string strQuyen
        {
            get { return str2; }
            set { str2 = value; }
        }
        public frmNhanVien()
        {
            InitializeComponent();

        }    

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien ThemNhanVien = new frmThemNhanVien();
            ThemNhanVien.ShowDialog();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            gctNhanVien.DataSource = nhanvienBUS.LayDSNV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chưa chọn nhân viên cần xóa", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (str1 == txtMaNV.Text)
            {
                MessageBox.Show(cod.TK_Exit, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVienDTO NV = new NhanVienDTO()
            {
                MaNV = txtMaNV.Text
            };

            DialogResult dlr = MessageBox.Show(string.Format("Bạn muốn xóa nhân viên {0} {1}?", txtHoTenLot.Text,txtTenNV.Text), cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;

            if (nhanvienBUS.XoaNV(NV))
            {
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiNV_Click(sender, e);
                return;
            }

            else
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void gctNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
            txtHoTenLot.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HoTenLotNV").ToString();
            txtTenNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
            cboGioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phai").ToString();
            detNgaySinh.Text =gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString();
            cboChucVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ChucVu").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DChi").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
            txtCCCD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CCCD").ToString();
            picAnhNV.Image = Image.FromFile(string.Format(@"{0}", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AnhThe").ToString()));
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int Numrd, Numrd2;
            Random rd = new Random();
            Numrd = rd.Next(1, 100);//biến Numrd sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100
            Random rd2 = new Random();
            Numrd2 = rd2.Next(1, 100);
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Chưa chọn nhân viên cần sửa", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtHoTenLot.Text.Trim().Length == 0 || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin nhân viên", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDateTime(detNgaySinh.EditValue) > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn năm hiện tại", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((DateTime.Now.Year - detNgaySinh.DateTime.Year) < 18)
            {
                MessageBox.Show("Tuổi không được bé hơn 18", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Sai định dạng Email", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSDT.Text.Trim().Length < 10)
            {
                MessageBox.Show("SDT sai định dạng ", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCCCD.Text.Trim().Length < 12)
            {
                MessageBox.Show("CCCD sai định dạng ", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picAnhNV.Image == null)
            {
                MessageBox.Show("Chưa chọn ảnh nhân viên", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (FileStream file = new FileStream(cod.PATH_NV + txtMaNV.Text + " " + Numrd + Numrd2 + ".jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] image = ConvertImageToByteArray(picAnhNV.Image);
                file.Write(image, 0, image.Length);
                file.Close();
                file.Dispose();
                System.GC.Collect();
            }
            linkanh = cod.PATH_NV + txtMaNV.Text + " " + Numrd + Numrd2 + ".jpg";
            if (str1 == txtMaNV.Text)
            {
                MessageBox.Show(cod.TK_Exit, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVienDTO NV = new NhanVienDTO()
            {
                MaNV = txtMaNV.Text,
                HoTenLotNV = txtHoTenLot.Text,
                TenNV = txtTenNV.Text,
                Phai =cboGioiTinh.Text,
                AnhThe = linkanh,
                NgaySinh = Convert.ToDateTime(detNgaySinh.EditValue),
                ChucVu = cboChucVu.Text,
                DChi =txtDiaChi.Text,
                SDT=txtSDT.Text,
                Email =txtEmail.Text,
                CCCD=txtCCCD.Text
            };
            if (nhanvienBUS.SuaNV(NV))
            {
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                gctNhanVien.DataSource = null;
                gctNhanVien.DataSource = nhanvienBUS.LayDSNV();
                return;
            }
            else
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThemAnhNV_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng đọc hình ảnh
            Stream myStream = null;
            //Mặc định OpenFileDialog mở ổ đĩa C:\
            ofdFile.InitialDirectory = "C:\\";
            //Lọc những loại tập tin có thể mở được 
            ofdFile.Filter = "Image file (*.jpg, *.jpeg, *.jpe ,*.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofdFile.FilterIndex = 2;
            ofdFile.RestoreDirectory = true;

            //Hiển thị hộp thoại
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Tập tin tồn tại
                    if ((myStream = ofdFile.OpenFile()) != null)
                    {
                        //Đọc tập tin và hiển thị PictureBox
                        using (myStream)
                        {
                            //Insert code to read the stream here
                            picAnhNV.Image = Image.FromStream(myStream);

                        }
                    }
                }
                catch (Exception ex) //Thông báo lỗi trong trường hợp đọc hình ảnh
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                myStream.Close();
                myStream.Dispose();
                System.GC.Collect();
            }
        }
        public byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                //Chuyển image sang kiểu bitmap
                Bitmap bmp = new Bitmap(imageToConvert);

                //Lưu bitmap thành MemoryStream cho việc lưu trữ ảnh
                bmp.Save(ms, ImageFormat.Jpeg);

                return ms.ToArray();
            }
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            gctNhanVien.DataSource = null;
            gctNhanVien.DataSource = nhanvienBUS.LayDSNV();
            txtMaNV.Text = string.Empty;
            txtHoTenLot.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            cboGioiTinh.EditValue = "Nam";
            cboChucVu.EditValue = "NhanVien";
            detNgaySinh.EditValue = "02/02/2002";
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            picAnhNV.Image = null;
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHoTenLot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
