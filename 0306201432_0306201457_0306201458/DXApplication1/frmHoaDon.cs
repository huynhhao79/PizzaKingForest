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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
       
        HoaDonBUS hoadonBUS = new HoaDonBUS();
        CTHoaDonBUS cthoadonBUS = new CTHoaDonBUS();
        HardCode cod = new HardCode();
        string str1, str2, str, str3 = string.Empty;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public string strMAHD
        {
            get { return str1; }
            set { str1 = value; }
        }
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
     
        private void btnThoatHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            if (str2 != cod.PER )
            {
                btnXoaHD.Enabled = false;
            }
            gtcHD.DataSource = hoadonBUS.LayDSHD();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                 HoaDonDTO mahd = new HoaDonDTO()
               {
                 MaHD = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString()
               };
                 DialogResult dlr = MessageBox.Show(string.Format("Bạn muốn xóa hóa đơn {0}?", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString()), cod.Tiltle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (dlr == DialogResult.No) return;

                    if (hoadonBUS.XoaHD(mahd))
                {
                 MessageBox.Show(cod.SUCCES, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 gtcHD.DataSource = null;
                 gtcHD.DataSource = hoadonBUS.LayDSHD();
                 gtcCTHD.DataSource = null;           
                 return;
                }
            }
            catch(Exception X)
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            
                
        }

        private void gtcHD_MouseClick(object sender, MouseEventArgs e)
        {
            gtcCTHD.DataSource = null;
            gtcCTHD.DataSource = cthoadonBUS.LayDSCTHD_HD(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString());
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            
            try
            {
                frmXemBaoCaoTK frm = new frmXemBaoCaoTK();
                frm.InHD(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString());
                frm.ShowDialog();
            }
            catch(Exception X)
            {
                MessageBox.Show(cod.FAIL, cod.Tiltle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}