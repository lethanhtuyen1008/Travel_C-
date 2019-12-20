using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLiTour;
using DAL_QuanLiTour;

namespace QuanLiTour
{
    public partial class MH_ChiTietTour : Form
    {
        private string matour;
        XuLiData xuli = new XuLiData();
        BUS_ChiTietTour bus = new BUS_ChiTietTour();
        bool check = true;
        public MH_ChiTietTour(string matour)
        {
            InitializeComponent();
            this.matour = matour;
        }
        public void LoadData() 
        {
            dataGridView_ChiTietTour.DataSource = bus.getChiTietThamQuan(this.matour);
            loaddatatotext();
        }
        public void LoadCombobox()
        {
            cbo_MaQuocGia.DataSource = bus.getQuocGia();
            cbo_MaQuocGia.DisplayMember = "TENQUOCGIA";
            cbo_MaQuocGia.ValueMember = "MAQUOCGIA";

            cbo_TenTinh.DataSource = bus.getTinh();
            cbo_TenTinh.DisplayMember = "TENTINH";
            cbo_TenTinh.ValueMember = "MATINH";
            cbo_TenTinh.SelectedIndex = 0;

            cbo_TenDiaDiem.DataSource = bus.getDiaDiem();
            cbo_TenDiaDiem.DisplayMember = "TENDIADIEM";
            cbo_TenDiaDiem.ValueMember = "MADIADIEM";

        }
        public void checkLoaiTour()
        {
            if (bus.getLoaiTour(this.matour))
                cbo_MaQuocGia.Enabled = false;
            else
                cbo_TenTinh.Enabled = false;
        }
        private void loaddatatotext()
        {
            cbo_MaTour.DataBindings.Clear();
            cbo_MaTour.DataBindings.Add("text", dataGridView_ChiTietTour.DataSource, "TENTOUR");

            cbo_MaQuocGia.DataBindings.Clear();
            cbo_MaQuocGia.DataBindings.Add("text", dataGridView_ChiTietTour.DataSource, "TENQUOCGIA");

            cbo_TenTinh.DataBindings.Clear();
            cbo_TenTinh.DataBindings.Add("text", dataGridView_ChiTietTour.DataSource, "TINH");

            cbo_TenDiaDiem.DataBindings.Clear();
            cbo_TenDiaDiem.DataBindings.Add("text", dataGridView_ChiTietTour.DataSource, "TENDIADIEM");

            txt_GhiChu.DataBindings.Clear();
            txt_GhiChu.DataBindings.Add("text", dataGridView_ChiTietTour.DataSource, "GHICHU");

        }
        private void MH_ChiTietTour_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombobox();
            checkLoaiTour();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            xuli.MoVaXoaTextBox(tableLayoutPanel_TTCTTour, dataGridView_ChiTietTour);
            check = true;
            cbo_MaTour.Enabled = false;
            cbo_MaTour.Text = this.matour;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(xuli.checkInput(tableLayoutPanel_TTCTTour)){
                try
                {
                    if (check)
                    {
                        CHITIETTHAMQUAN a = new CHITIETTHAMQUAN();
                        a.MADIADIEM = cbo_TenDiaDiem.SelectedValue.ToString();
                        a.MATOUR = cbo_MaTour.Text.ToString();
                        a.GHICHU = txt_GhiChu.Text;
                        if (bus.addCTTour(a))
                            MessageBox.Show("Thêm chi tiết tham quan cho tour " + cbo_MaTour.Text + " thành công");
                        else
                            MessageBox.Show("Thêm chi tiết tham quan cho tour " + cbo_MaTour.Text.Trim() + " không thành công");
                    }
                    else
                    {
                        CHITIETTHAMQUAN a = new CHITIETTHAMQUAN();
                        a.MADIADIEM = cbo_TenDiaDiem.SelectedValue.ToString();
                        a.MATOUR = cbo_MaTour.Text.ToString();
                        a.GHICHU = txt_GhiChu.Text;
                        if (bus.updateCTTour(a))
                            MessageBox.Show("Sửa chi tiết tham quan cho tour " + cbo_MaTour.Text + " thành công");
                        else
                            MessageBox.Show("Sửa chi tiết tham quan cho tour " + cbo_MaTour.Text.Trim() + " không thành công");
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm chi tiết tham quan cho tour " + cbo_MaTour.Text.Trim() + "không thành công");
                }
            }
            btn_Luu.Enabled = false;
            xuli.DongTextBox(tableLayoutPanel_TTCTTour, dataGridView_ChiTietTour);
            LoadData();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            xuli.DongTextBox(tableLayoutPanel_TTCTTour, dataGridView_ChiTietTour);
            LoadData();
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
        }

        private void cbo_TenDiaDiem_DropDown(object sender, EventArgs e)
        {
            cbo_TenDiaDiem.DataSource = bus.getListDiaDiem(cbo_TenTinh.SelectedValue.ToString());
            cbo_TenDiaDiem.DisplayMember = "TENDIADIEM";
            cbo_TenDiaDiem.ValueMember = "MADIADIEM";
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            xuli.MoTextBox(tableLayoutPanel_TTCTTour, dataGridView_ChiTietTour);
            check = false;
            cbo_MaTour.Enabled = false;
            cbo_MaTour.Text = this.matour;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
        }

        private void cbo_TenDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
