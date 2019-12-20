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
using DTO_QuanLiTour;
using DAL_QuanLiTour;

namespace QuanLiTour
{
    public partial class MH_GiaTour : Form
    {
        BUS_ChiTietGiaTour bus = new BUS_ChiTietGiaTour();
        BUS_GiaTour busgi = new BUS_GiaTour();
        XuLiData xuli = new XuLiData();
        float tongtien = 0;
        private string  magiave;
        bool check = true;
        public MH_GiaTour(string magiave)
        {
            InitializeComponent();
            this.magiave = magiave;
        }
        public void LoadData()
        {
            gridControl_ChiTietGia.DataSource = bus.getListChiTietGia(this.magiave);
            loadtotext();
        }
        public void loadtotext()
        {
            txt_MaGiave.DataBindings.Clear();
            txt_MaGiave.DataBindings.Add("text", gridControl_ChiTietGia.DataSource, "MAGIAVE");
            txt_GhiChu.DataBindings.Clear();
            txt_GhiChu.DataBindings.Add("text", gridControl_ChiTietGia.DataSource, "GHICHU");
        }
        private void MH_GiaTour_Load(object sender, EventArgs e)
        {
            LoadData();
            xuli.DongText(tableLayoutPanel_TTGia, gridControl_ChiTietGia);
        }

        private void gridControl_ChiTietGia_Click(object sender, EventArgs e)
        {
            tongtien = 0;
            int x = gridView_ChiTietGia.FocusedRowHandle;// row selected
            string data = gridView_ChiTietGia.GetRowCellValue(x, "MAGIAVE").ToString(); // matour selected
            List<CHITIETGIAVE> giave = busgi.getChiTietGia(data);
            foreach (CHITIETGIAVE item in giave)
            {
                tongtien += float.Parse(item.GIA.ToString());
                //MessageBox.Show(item.MALOAIKHACH.ToString());
                if (item.MALOAIKHACH.Trim().CompareTo("LK0001")==0)
                    txt_NguoiGia.Text = item.GIA.ToString();

                if (item.MALOAIKHACH.Trim() == "LK0002")
                    txt_NguoiLon.Text = item.GIA.ToString();
                //else
                //    txt_NguoiLon.Text = 0.ToString();

                if (item.MALOAIKHACH.Trim() == "LK0003")
                    txt_ThanhNien.Text = item.GIA.ToString();
                //else
                //    txt_ThanhNien.Text = 0.ToString();

                if (item.MALOAIKHACH == "LK0004")
                    txt_TreEm.Text = item.GIA.ToString();
                //else
                //    txt_TreEm.Text = 0.ToString();
            }
            txt_TongTien.Text = tongtien.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            check = true;
            xuli.MoVaXoaText(tableLayoutPanel_CTgia, gridControl_ChiTietGia);
            txt_GhiChu.Enabled = true;
            txt_MaGiave.Text = busgi.getMaGiave();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            check = false;
            xuli.MoText(tableLayoutPanel_CTgia, gridControl_ChiTietGia);
            txt_GhiChu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (xuli.checkInput(tableLayoutPanel_CTgia))
            {
                try
                {
                    if (check)
                    {
                        try
                        {
                            float tien = 0;
                            tien = float.Parse(txt_NguoiGia.Text) + float.Parse(txt_NguoiLon.Text) + float.Parse(txt_ThanhNien.Text) + float.Parse(txt_TreEm.Text);
                            GIAVE a = new GIAVE();
                            a.MAGIAVE = txt_MaGiave.Text;
                            a.GHICHU = txt_GhiChu.Text;
                            a.TONGGIA = tien;
                            busgi.addGiaVe(a);
                            CHITIETGIAVE b = new CHITIETGIAVE();
                            b.MAGIAVE = txt_MaGiave.Text;
                            b.MALOAIKHACH = "LK0001";
                            b.GIA = float.Parse(txt_NguoiGia.Text);
                            b.GHICHU = "1";
                            CHITIETGIAVE c = new CHITIETGIAVE();
                            c.MAGIAVE = txt_MaGiave.Text;
                            c.MALOAIKHACH = "LK0002";
                            c.GIA = float.Parse(txt_NguoiLon.Text);
                            c.GHICHU = "1";
                            CHITIETGIAVE d = new CHITIETGIAVE();
                            d.MAGIAVE = txt_MaGiave.Text;
                            d.MALOAIKHACH = "LK0003";
                            d.GIA = float.Parse(txt_ThanhNien.Text);
                            d.GHICHU = "1";
                            CHITIETGIAVE f = new CHITIETGIAVE();
                            f.MAGIAVE = txt_MaGiave.Text;
                            f.MALOAIKHACH = "LK0004";
                            f.GIA = float.Parse(txt_TreEm.Text);
                            f.GHICHU = "1";
                            bool x = bus.addCTGV(b);
                            bool y = bus.addCTGV(c);
                            bool k = bus.addCTGV(d);
                            bool n = bus.addCTGV(f);
                            MessageBox.Show("Thêm giá tour thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Thêm giá tour thất bại");
                        }
                    }
                    else
                    {
                        try
                        {
                            float tien = 0;
                            tien = float.Parse(txt_NguoiGia.Text) + float.Parse(txt_NguoiLon.Text) + float.Parse(txt_ThanhNien.Text) + float.Parse(txt_TreEm.Text);

                            CHITIETGIAVE b = new CHITIETGIAVE();
                            b.MAGIAVE = txt_MaGiave.Text;
                            b.MALOAIKHACH = "LK0001";
                            b.GIA = float.Parse(txt_NguoiGia.Text);
                            b.GHICHU = "";
                            CHITIETGIAVE c = new CHITIETGIAVE();
                            c.MAGIAVE = txt_MaGiave.Text;
                            c.MALOAIKHACH = "LK0002";
                            c.GIA = float.Parse(txt_NguoiLon.Text);
                            c.GHICHU = "";
                            CHITIETGIAVE d = new CHITIETGIAVE();
                            d.MAGIAVE = txt_MaGiave.Text;
                            d.MALOAIKHACH = "LK0003";
                            d.GIA = float.Parse(txt_ThanhNien.Text);
                            d.GHICHU = "";
                            CHITIETGIAVE f = new CHITIETGIAVE();
                            f.MAGIAVE = txt_MaGiave.Text;
                            f.MALOAIKHACH = "LK0004";
                            f.GIA = float.Parse(txt_TreEm.Text);
                            f.GHICHU = "";
                            bus.addCTGV(b);
                            bus.addCTGV(c);
                            bus.addCTGV(d);
                            bus.addCTGV(f);
                            GIAVE a = new GIAVE();
                            a.MAGIAVE = txt_MaGiave.Text;
                            a.GHICHU = txt_GhiChu.Text;
                            a.TONGGIA = tien;
                            MessageBox.Show("Thêm giá tour thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Thêm giá tour thất bại");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lưu thất bại");
                }
            }
        }
    }
}
