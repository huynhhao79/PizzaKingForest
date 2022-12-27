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
namespace DXApplication1
{
    public partial class frmKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        KhuyenMaiBUS khuyemaiBUS = new KhuyenMaiBUS();
        private HardCode cons = new HardCode();
        string str, str2;
        public string strMANV
        {
            get { return str; }
            set { str = value; }
        }
        public string strQuyen
        {
            get { return str2; }
            set { str2 = value; }
        }
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            if (str2 != cons.PER)
            {
                btnThemKM.Enabled = btnXoaKM.Enabled = btnSuaKhuyenMai.Enabled = false;
            }
            
            gctKM.DataSource = khuyemaiBUS.LayDSKM();
            txtMaKM.Enabled = false;
            txtMaKM.Text =string.Format("KM{0}",(khuyemaiBUS.DemDSKM().Count + 1).ToString("000"));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            if (txtMaKM.Text.Trim().Length == 0) //Chưa nhập Mã Khuyến mãi
            {
                MessageBox.Show("Bạn chưa nhập mã khuyến mãi! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtoNgayBD.Text.Trim().Length == 0) //Chưa nhập ngày bắt đầu
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu ! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtoNgayKT.Text.Trim().Length == 0) //Chưa nhập ngày bắt đầu
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc ! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0) //Chưa nhập số lượng!
            {

                MessageBox.Show("Bạn chưa nhập số lượng! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGiaGiam.Text.Trim().Length == 0) //Chưa nhập giá giảm
            {
                MessageBox.Show("Bạn chưa nhập giá giảm! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToDateTime(dtoNgayBD.EditValue) < DateTime.Now)
            {
                MessageBox.Show("Bạn phải nhập ngày lớn hơn ngày hiện tại ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDateTime(dtoNgayKT.EditValue) < Convert.ToDateTime(dtoNgayBD.EditValue) || Convert.ToDateTime(dtoNgayKT.EditValue) == Convert.ToDateTime(dtoNgayBD.EditValue))
            {
                MessageBox.Show(" Bạn phải nhập ngày kết thúc lớn ngày bắt đầu!", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ( int.Parse( txtSoLuong.Text)<0 || int.Parse (txtSoLuong.Text)>50)
            {
                MessageBox.Show(" Số lượng phải lớn hơn 0 hoặc nhỏ hơn 50 !", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhuyenMaiDTO khuyenmaithem = new KhuyenMaiDTO()
            {
                MaKM = txtMaKM.Text,
                NgayBD = Convert.ToDateTime(dtoNgayBD.EditValue),
                NgayKT = Convert.ToDateTime(dtoNgayKT.EditValue),
                GiaGiam = Convert.ToDecimal(txtGiaGiam.Text),
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
                TrangThai = cons.IsExit

            };
            if (khuyemaiBUS.Them(khuyenmaithem))
            {
                MessageBox.Show(cons.SUCCES, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi_Click(sender, e);
                gctKM.DataSource = null;
                gctKM.DataSource = khuyemaiBUS.LayDSKM();
                return;
            }
            else
                MessageBox.Show(cons.FAIL, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gctKM_MouseClick(object sender, MouseEventArgs e)
        {
           
            txtMaKM.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKM").ToString();
            dtoNgayBD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayBD").ToString();
            dtoNgayKT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayKT").ToString();
            txtSoLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoLuong").ToString();
            txtGiaGiam.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiaGiam").ToString();
        }

        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            if (dtoNgayBD.Text.Trim().Length == 0 || dtoNgayKT.Text.Trim().Length == 0 || txtSoLuong.Text.Trim().Length == 0 || txtGiaGiam.Text.Trim().Length == 0)
            {
                MessageBox.Show(cons.INFO, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            KhuyenMaiDTO xoakhuyenmai = new KhuyenMaiDTO()
            {
                MaKM = txtMaKM.Text
            };
            DialogResult dlr = MessageBox.Show(string.Format("Bạn muốn xóa khuyến mãi {0}?", txtMaKM.Text), cons.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) return;
            if (khuyemaiBUS.XoaKM(xoakhuyenmai))
            {
                MessageBox.Show(cons.SUCCES, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi_Click(sender, e);
                gctKM.DataSource = null;
                gctKM.DataSource = khuyemaiBUS.LayDSKM();
                return;
            }
            else
                MessageBox.Show(cons.FAIL, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtGiaGiam.Text = string.Empty;
            txtMaKM.Text = string.Empty;
            dtoNgayBD.Text = string.Empty;
            dtoNgayKT.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtMaKM.Text = string.Format("KM{0}", (khuyemaiBUS.DemDSKM().Count + 1).ToString("000"));
        }

        private void btnSuaKhuyenMai_Click(object sender, EventArgs e)
        {
            if (txtMaKM.Text.Trim().Length == 0) //Chưa nhập Mã Khuyến mãi
            {
                MessageBox.Show("Bạn chưa chọn dòng cần sửa! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtoNgayBD.Text.Trim().Length == 0) //Chưa nhập ngày bắt đầu
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu ! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtoNgayKT.Text.Trim().Length == 0) //Chưa nhập ngày bắt đầu
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc ! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0) //Chưa nhập số lượng!
            {

                MessageBox.Show("Bạn chưa nhập số lượng! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGiaGiam.Text.Trim().Length == 0) //Chưa nhập giá giảm
            {
                MessageBox.Show("Bạn chưa nhập giá giảm! ", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToDateTime(dtoNgayKT.EditValue) < Convert.ToDateTime(dtoNgayBD.EditValue))
            {
                MessageBox.Show(" Bạn phải nhập ngày kết thúc lớn ngày bắt đầu!", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDateTime(dtoNgayKT.EditValue) < DateTime.Now)
            {
                MessageBox.Show(" Bạn phải nhập ngày kết thúc lớn hơn ngày hiện tại!", cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhuyenMaiDTO khuyenmaisua = new KhuyenMaiDTO()
            {
                MaKM = txtMaKM.Text,
                NgayBD = Convert.ToDateTime(dtoNgayBD.EditValue),
                NgayKT = Convert.ToDateTime(dtoNgayKT.EditValue),
                GiaGiam = Convert.ToDecimal(txtGiaGiam.Text),
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
            };
            if(khuyemaiBUS.sua(khuyenmaisua))
            {
                MessageBox.Show(cons.SUCCES, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(cons.FAIL, cons.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            gctKM.DataSource = null;
            gctKM.DataSource = khuyemaiBUS.LayDSKM();
            
        }


    }
}