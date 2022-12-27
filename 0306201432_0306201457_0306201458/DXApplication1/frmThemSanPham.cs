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
namespace DXApplication1
{
    public partial class frmThemSanPham : DevExpress.XtraEditors.XtraForm
    {
        SanPhamBUS sanphamBUS = new SanPhamBUS();
        LoaiSanPhamBUS loaisanphamBUS = new LoaiSanPhamBUS();
        string linkanh;
        HardCode cod = new HardCode();
        public frmThemSanPham()
        {
            InitializeComponent();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lueLoaiSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa chọn loại sản phẩm", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMoTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập mô tả", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập đơn giá", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            if (picAnhSP.Image == null)
            {
                MessageBox.Show("Chưa chọn ảnh sản phẩm", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream("../../img/ImageSP/" + txtMaSP.Text + ".jpg", FileMode.Create, FileAccess.ReadWrite))
                {
                    byte[] bytes = ConvertImageToByteArray(picAnhSP.Image);
                    fs.Write(bytes, 0, bytes.Length);
                }
                linkanh = "../../img/ImageSP/" + txtMaSP.Text + ".jpg";
            }
            SanPhamDTO themsp = new SanPhamDTO()
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                MaLoaiSP = lueLoaiSP.EditValue.ToString(),
                MoTa = txtMoTa.Text,
                DonGia =Convert.ToDecimal (txtDonGia.Text),
                AnhSP = linkanh
            };      
            if (sanphamBUS.ThemSP(themsp))
            {
                MessageBox.Show(string.Format("Thêm thành công sản phẩm {0}", txtMaSP.Text), cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
        }

        private void frmThemSanPham_Load(object sender, EventArgs e)
        {
            //Load danh sách sp lên lueLoaiSP
            lueLoaiSP.Properties.DataSource = loaisanphamBUS.LayDSLoaiSP();
            lueLoaiSP.Properties.DisplayMember = cod.LSPDISPLAY;
            lueLoaiSP.Properties.ValueMember = cod.LSPVALUE;
            lueLoaiSP.Properties.PopulateColumns();
            lueLoaiSP.Properties.Columns[0].Visible = false;
            lueLoaiSP.Properties.Columns[2].Visible = false;
            lueLoaiSP.Properties.Columns[1].Caption = cod.LSPDISPLAY;

            txtMaSP.Enabled = false;
            txtMaSP.Text = string.Format("SP{0}", ( sanphamBUS.DemDSSP().Count + 1).ToString("000"));
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = string.Empty;
            txtMaSP.Text = string.Format("SP{0}", (sanphamBUS.DemDSSP().Count + 1).ToString("000"));
            txtTenSP.Text = string.Empty;
            lueLoaiSP.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            picAnhSP.Image = null;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
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
                            picAnhSP.Image = Image.FromStream(myStream);

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

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}