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
using System.Data.SqlClient;
using BUS;
using DTO;
using System.IO;
using System.Drawing.Imaging;
namespace DXApplication1
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        SanPhamBUS sanphamBUS = new SanPhamBUS();
        LoaiSanPhamBUS loaisanphamBUS = new LoaiSanPhamBUS();
        HardCode cod = new HardCode();
        string str1, str2,linkanh;
        public string strMANV
        {
            get { return str1; }
            set { str1 = value;  }
        }
        public string strQuyen
        {
            get { return str2; }
            set { str2 = value; }
        }
        
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmThemSanPham ThemSanPham = new frmThemSanPham();
            ThemSanPham.ShowDialog();
        }
      
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            if (str2 != cod.PER)
            {
                btnThemAnhSP.Enabled = btnThemSP.Enabled = btnSuaSP.Enabled = btnXoaSP.Enabled = false;
            }
            //Đổ dữ liệu loại sp vào lueloaisp
            lueLoaiSP.Properties.DataSource = loaisanphamBUS.LayDSLoaiSP();
            lueLoaiSP.Properties.DisplayMember = cod.LSPDISPLAY;
            lueLoaiSP.Properties.ValueMember = cod.LSPVALUE;
            lueLoaiSP.Properties.PopulateColumns();
            lueLoaiSP.Properties.Columns[0].Visible = false;
            lueLoaiSP.Properties.Columns[2].Visible = false;
            lueLoaiSP.Properties.Columns[1].Caption = "Loại sản phẩm";
            txtMaSP.Enabled = false;
            gctSP.DataSource = sanphamBUS.LayDSSP();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            int Numrd, Numrd2;
            Random rd = new Random();
            Numrd = rd.Next(1, 100);//biến Numrd sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100
            Random rd2 = new Random();
            Numrd2 = rd2.Next(1, 100);
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Chưa chọn sản phẩm cần sửa", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            using (FileStream file = new FileStream(cod.PATH_SP + txtMaSP.Text + " " + Numrd + Numrd2 + ".jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] image = ConvertImageToByteArray(picAnhSP.Image);
                file.Write(image, 0, image.Length);
                file.Close();
                file.Dispose();
                System.GC.Collect();
            }
            linkanh = cod.PATH_SP + txtMaSP.Text + " " + Numrd + Numrd2 + ".jpg";
            SanPhamDTO SP = new SanPhamDTO()
            {
                MaSP = txtMaSP.Text,
                TenSP = txtTenSP.Text,
                MaLoaiSP = lueLoaiSP.EditValue.ToString(),
                MoTa = txtMoTa.Text,
                DonGia =Convert.ToDecimal(txtDonGia.Text),
                AnhSP = linkanh,
            };
            if (sanphamBUS.SuaSP(SP))
            {
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                gctSP.DataSource = null;
                gctSP.DataSource = sanphamBUS.LayDSSP(); 
                return;
            }
            else
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThemAnhSP_Click(object sender, EventArgs e)
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

        private void gctSP_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSP").ToString();
            txtTenSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenSP").ToString();
            lueLoaiSP.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaLoaiSP").ToString();
            txtMoTa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MoTa").ToString();
            txtDonGia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonGia").ToString();
            picAnhSP.Image = Image.FromFile(string.Format(@"{0}", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AnhSP").ToString()));
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa", cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SanPhamDTO xoasp = new SanPhamDTO()
            {
                MaSP = txtMaSP.Text
            };
            DialogResult dlr = MessageBox.Show(string.Format("Bạn muốn xóa sản phẩm {0}?", txtTenSP.Text), cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;
          
            if (sanphamBUS.XoaSP(xoasp))
            {
                MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoiSP_Click(sender, e);
                return;
            }
            else
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            lueLoaiSP.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            picAnhSP.Image = null;
            gctSP.DataSource = null;
            gctSP.DataSource = sanphamBUS.LayDSSP();
        }

       
    }
}