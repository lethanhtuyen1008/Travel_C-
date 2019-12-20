using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS_QuanLiTour;
using DTO_QuanLiTour;
using System.Threading;
using DAL_QuanLiTour;
using System.Drawing.Imaging;

namespace QuanLiTour
{
    public partial class MH_QuanLyTour : Form
    {
        BUS_ChuongTrinhTour bus = new BUS_ChuongTrinhTour();
        BUS_ChiTietChuongTrinh busctct = new BUS_ChiTietChuongTrinh();
        BUS_DiaDiem busDiaDiem = new BUS_DiaDiem();
        XuLiData xuli = new XuLiData();
        BUS_Tours busTours = new BUS_Tours();
        BUS_GiaTour busgia = new BUS_GiaTour();
        BUS_DatTour busdt = new BUS_DatTour();
        string imglocation = "";//string filename
        public MH_QuanLyTour()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            gridControl_Tours.DataSource = busTours.getListTour();
        }
        public void loaddatatoText()
        {
            txt_MaTour.DataBindings.Clear();
            txt_MaTour.DataBindings.Add("Text", gridControl_Tours.DataSource, "MATOUR");
            cbo_MaLoai.DataBindings.Clear();
            cbo_MaLoai.DataBindings.Add("Text", gridControl_Tours.DataSource, "MALOAI");
            txt_TenTour.DataBindings.Clear();
            txt_TenTour.DataBindings.Add("Text", gridControl_Tours.DataSource, "TENTOUR");
            txt_SoCho.DataBindings.Clear();
            txt_SoCho.DataBindings.Add("Text", gridControl_Tours.DataSource, "SOCHO");
            txt_SoNgay.DataBindings.Clear();
            txt_SoNgay.DataBindings.Add("Text", gridControl_Tours.DataSource, "SONGAY");
            label_TenTour.DataBindings.Clear();
            label_TenTour.DataBindings.Add("Text", gridControl_Tours.DataSource, "TENTOUR");

            cbo_MaGiaVe.DataBindings.Clear();
            cbo_MaGiaVe.DataBindings.Add("Text", gridControl_Tours.DataSource, "MAGIAVE");
        }
        private void MH_QuanLyTour_Load(object sender, EventArgs e)
        {
            LoadData();
            xuli.DongText(tableLayoutPanel_TTTours, gridControl_Tours);
            loaddatatoText();
            btn_LuuTour.Enabled = false;
            btn_HuyTour.Enabled = false;
            xuli.loadComboBox(cbo_MaLoai, "SELECT * FROM LOAITOUR", "TENLOAI", "MALOAI");
            Thread.Sleep(3000);
        }
        private void btn_ThemTour_Click(object sender, EventArgs e)
        {
            btn_ChonAnh.Visible = true;
            xuli.MoVaXoaText(tableLayoutPanel_TTTours, gridControl_Tours);
            check = true;
            txt_MaTour.Text = busTours.getMaTour();
            txt_MaTour.Enabled = false;
            btn_LuuTour.Enabled = false;
            btn_HuyTour.Enabled = false;
            labelIP_TenTour.Visible = true;
            txt_TenTour.Visible = true;
            btn_LuuTour.Enabled = true;
            btn_HuyTour.Enabled = true;
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            btn_ChonAnh.Visible = true;
            check = false;
            xuli.MoText(tableLayoutPanel_TTTours, gridControl_Tours);
            txt_MaTour.Enabled = false;
            labelIP_TenTour.Visible = true;
            txt_TenTour.Visible = true;
            btn_LuuTour.Enabled = true;
            btn_HuyTour.Enabled = true;
        }

        private void btn_XoaTour_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int x = gridView_Tour.FocusedRowHandle;
                string data = gridView_Tour.GetRowCellValue(x, "MaTour").ToString();
                if (busTours.deleteTour(data)) MessageBox.Show("Xóa thành công tour: " + data);
                else MessageBox.Show("Xóa không thành công tour: " + data);
                LoadData();
            }
        }
        bool check = true;
        private void btn_LuuTour_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker_NgayKH.Value.Date.ToShortDateString());
            if (xuli.checkInput(tableLayoutPanel_TTTours))
            {
                if (pictureBox_Tour.Image !=null)
                {
                    if (check == true)
                    {
                        MemoryStream stream = new MemoryStream();
                        pictureBox_Tour.Image.Save(stream, ImageFormat.Jpeg);
                        TourEdit add = new TourEdit(txt_MaTour.Text.Trim(), cbo_MaLoai.SelectedValue.ToString(), txt_TenTour.Text, int.Parse(txt_SoNgay.Text), int.Parse(txt_SoCho.Text), stream.ToArray(), cbo_MaGiaVe.SelectedValue.ToString());
                        if (busTours.addTours(add))
                            MessageBox.Show("Thêm tour thành công");
                        else
                            MessageBox.Show("Thêm tour không thành công");
                    }
                    else
                    {
                        MemoryStream stream = new MemoryStream();
                        pictureBox_Tour.Image.Save(stream, ImageFormat.Jpeg);
                        TourEdit add = new TourEdit(txt_MaTour.Text.Trim(), cbo_MaLoai.SelectedValue.ToString(), txt_TenTour.Text, int.Parse(txt_SoNgay.Text), int.Parse(txt_SoCho.Text), stream.ToArray(), cbo_MaGiaVe.Text);
                        if (busTours.updateTours(add))
                            MessageBox.Show("Cập nhật tour thành công");
                        else
                            MessageBox.Show("Cập nhật tour không thành công");
                    }
                    btn_ChonAnh.Visible = false;
                    LoadData();
                    xuli.DongText(tableLayoutPanel_TTTours, gridControl_Tours);
                    labelIP_TenTour.Visible = true;
                    txt_TenTour.Visible = true;
                    btn_LuuTour.Enabled = false;
                    btn_HuyTour.Enabled = false;
                }
                else {
                    MessageBox.Show("Chưa chọ hình ảnh mô tả");
                }
            }
        }

        private void btn_HuyTour_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                LoadData();
                xuli.DongText(tableLayoutPanel_TTTours, gridControl_Tours);
            }
            btn_ChonAnh.Visible = false;
            labelIP_TenTour.Visible = true;
            txt_TenTour.Visible = true;
            btn_LuuTour.Enabled = false;
            btn_HuyTour.Enabled = false;
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imglocation = open.FileName.ToString();
                pictureBox_Tour.ImageLocation = imglocation;
            }
        }

        private void cbo_MaLoai_DropDown(object sender, EventArgs e)
        {
            xuli.loadComboBox(cbo_MaLoai,"SELECT * FROM LOAITOUR","TENLOAI","MALOAI");
        }

        private void cbo_MaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ChuongTrinhTour_Click(object sender, EventArgs e)
        {
            int x = gridView_Tour.FocusedRowHandle;
            string data = gridView_Tour.GetRowCellValue(x, "MaTour").ToString();
            MH_ChuongTrinhTour frm = new MH_ChuongTrinhTour(data);
            frm.Show();
        }

        private void btn_ChiTietTour_Click(object sender, EventArgs e)
        {
            int x = gridView_Tour.FocusedRowHandle;
            string data = gridView_Tour.GetRowCellValue(x, "MaTour").ToString();
            MH_ChiTietTour frm = new MH_ChiTietTour(data);
            frm.Show();
        }

        private void btn_LichTrinh_Click(object sender, EventArgs e)
        {
            MH_LichKhoiHanh frm = new MH_LichKhoiHanh();
            frm.Show();
        }

        private void btn_DatTour_Click(object sender, EventArgs e)
        {
            int x = gridView_Tour.FocusedRowHandle;
            string data = gridView_Tour.GetRowCellValue(x, "MaTour").ToString();
            MH_DatTour a = new MH_DatTour(data);
            a.Show();
        }

        private void gridView_Tour_Click(object sender, EventArgs e)
        {
            loaddatatoText();
            int x = gridView_Tour.FocusedRowHandle;// row selected
            string data = gridView_Tour.GetRowCellValue(x, "MaTour").ToString(); // matour selected
            tableLayoutPanel_Design.Controls.Clear();// update layout chuongtrinh
            LoadPageChuongTrinh(data); //load chương trình
            MemoryStream memo = new MemoryStream(busTours.getImageTour(data));
            Image img = Image.FromStream(memo);
            if (img == null)
            {
                return;
            }
            pictureBox_Tour.Image = img;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadPageChuongTrinh(string ma)
        {
            List<DTO_ChuongTrinhTour> list = bus.getListChuongTrinhTour(ma); // get list chuong trinh tour của matour
            int i = 1;
            foreach (DTO_ChuongTrinhTour k in list) // duyệt list chương trình tour của tour
            {
                List<DIADIEMDULICH> listDiaDiem = new List<DIADIEMDULICH>(); // khai báo list địa điểm
                //MessageBox.Show(k.MACHUONGTRINH.ToString());
                List<CHITIETCHUONGTRINH> lct = busctct.getListChuongTrinh(k.MACHUONGTRINH.ToString()); // get list chiet tiet của chương trình
                foreach (CHITIETCHUONGTRINH itemChitiet in lct) //duyệt list chi tiết chuong trình
                {
                    //MessageBox.Show(itemChitiet.MADIADIEM.ToString());
                    DIADIEMDULICH itemDiaDiem = busDiaDiem.getDiaDiem(itemChitiet.MADIADIEM.ToString()); // lấy ra địa điểm có mã địa điểm hợp lệ
                    listDiaDiem.Add(itemDiaDiem); // thêm vào list địa điểm
                }
                if (lct.Count > 0)
                {
                    string stt = "Ngày " + i;
                    string ten = k.TENCHUONGTRINH.ToString();
                    string ngay = k.NGAY.ToString();
                    string chit = k.GHICHU.ToString();
                    ThietKeControls.itemCTTour a = new ThietKeControls.itemCTTour(stt, ngay, ten, listDiaDiem);
                    a.Dock = DockStyle.Fill;
                    tableLayoutPanel_Design.Controls.Add(a);
                    i++;
                }
                listDiaDiem.Clear();
            }
        }

        private void tableLayoutPanel_Design_Paint(object sender, PaintEventArgs e)
        {
            //tableLayoutPanel_Design.AutoScroll = true;
            //tableLayoutPanel_Design.HorizontalScroll.Enabled = false;
            //tableLayoutPanel_Design.HorizontalScroll.Visible = false;
            //tableLayoutPanel_Design.AutoScroll = true;
        }

        private void cbo_MaGiaVe_DropDown(object sender, EventArgs e)
        {
           cbo_MaGiaVe.DataSource =  busgia.getListGia();
           cbo_MaGiaVe.DisplayMember = "GHICHU";
           cbo_MaGiaVe.ValueMember = "MAGIAVE";
        }

        private void btn_CapNhatGia_Click(object sender, EventArgs e)
        {
            int x = gridView_Tour.FocusedRowHandle;
            string data = gridView_Tour.GetRowCellValue(x, "MaGiaVe").ToString();
            MH_GiaTour frm = new MH_GiaTour(data);
            frm.Show();
        }

        private void cbo_LichKhoiHanh_DropDown(object sender, EventArgs e)
        {

        }

        private void btn_DatTour_Click_1(object sender, EventArgs e)
        {
            int x = gridView_Tour.FocusedRowHandle;
            string data = gridView_Tour.GetRowCellValue(x, "MaTour").ToString();
            MessageBox.Show(data);
            //busdt.ActionDatTour(data);
            MH_DatTour frm = new MH_DatTour(data);
            frm.Show();
        }
    }
}