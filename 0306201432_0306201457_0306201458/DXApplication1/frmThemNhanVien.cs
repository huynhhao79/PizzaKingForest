using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;
namespace DXApplication1
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBUS nhanvienBUS = new NhanVienBUS();
        TaiKhoanBUS taikhoanBUS = new TaiKhoanBUS();
        string linkanh;
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            txtHoTenLot.Text=string.Empty;
            txtTenNV.Text =string.Empty;
            cbeGioiTinh.EditValue = "Nam";
            detNgaySinh.EditValue =" 02/02/2002";
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text=string.Empty;
            txtCCCD.Text = string.Empty;
            cboChucVu.EditValue = "NhanVien";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTenLot.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDateTime(detNgaySinh.EditValue) > DateTime.Now) 
            {
                MessageBox.Show("Ngày sinh không được lớn hơn năm hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((DateTime.Now.Year - detNgaySinh.DateTime.Year) < 18)
            {
                MessageBox.Show("Tuổi không được bé hơn 18", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Sai định dạng Email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSDT.Text.Trim().Length < 10)
            {
                MessageBox.Show("SDT sai định dạng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCCCD.Text.Trim().Length < 12)
            {
                MessageBox.Show("CCCD sai định dạng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picAnhNV.Image == null)
            {
                MessageBox.Show("Chưa chọn ảnh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }        
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream("../../img/ImageNV/" + txtMaNV.Text + ".jpg", FileMode.Create,FileAccess.ReadWrite))
                {
                    byte[] bytes = ConvertImageToByteArray(picAnhNV.Image);
                    fs.Write(bytes, 0, bytes.Length);
                }
                linkanh = "../../img/ImageNV/" + txtMaNV.Text + ".jpg";
            }
            tapTT.SelectedPage = tabThongTinTK;
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtMaNVTK.Enabled = false;
            txtMaNV.Text = string.Format("N{0}",(nhanvienBUS.DemDSNV().Count + 1).ToString("000"));
            txtMaNVTK.Text = txtMaNV.Text;
        }

        private void btnThemNVTK_Click(object sender, EventArgs e)
        {
            btnTiepTuc_Click(sender, e);
            
            if (string.IsNullOrEmpty(txtTenTK.Text) || string.IsNullOrEmpty(txtMK.Text) || string.IsNullOrEmpty(txtNhapLaiMK.Text))
            {
                MessageBox.Show("Chưa nhập đủ thông tin tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVienDTO addnv = new NhanVienDTO()
            {
                MaNV = txtMaNV.Text,
                HoTenLotNV = txtHoTenLot.Text,
                TenNV = txtTenNV.Text,
                Phai = cbeGioiTinh.Text,
                NgaySinh =Convert.ToDateTime(detNgaySinh.EditValue),
                ChucVu = cboChucVu.Text,
                AnhThe = linkanh,
                DChi = txtDiaChi.Text,
                SDT =txtSDT.Text,
                Email = txtEmail.Text,
                CCCD =txtCCCD.Text
            };
            TaiKhoanDTO addtk = new TaiKhoanDTO()
            {
                MaNV = txtMaNVTK.Text,
                TK = txtTenTK.Text,
                MK = txtMK.Text,
                Quyen = cboChucVu.Text
            };
            if (txtMK.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu phải trùng khớp với mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (taikhoanBUS.TrungTenTK(addtk))
                {
                    if (nhanvienBUS.ThemNV(addnv) && taikhoanBUS.ThemTK(addtk))
                    {
                        MessageBox.Show(string.Format("Thêm thành công nhân viên {0} với mã tài khoản {1}", txtMaNV.Text, txtMaNV.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Thêm nhân viên {0} thất bại",txtMaNVTK.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã có ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 
            }            
        }

        private void btnLamMoiTK_Click(object sender, EventArgs e)
        {
            txtTenTK.Text = string.Empty;
            txtMK.Text = string.Empty;
            txtNhapLaiMK.Text = string.Empty;
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            tapTT.SelectedPage = tabThongTinNV;
        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Close();
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
      
           
    }
}