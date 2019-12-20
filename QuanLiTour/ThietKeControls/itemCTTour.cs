using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLiTour;
using DAL_QuanLiTour;

namespace ThietKeControls
{
    public partial class itemCTTour : UserControl
    {
        private string sn = "";
        private string ng = "";
        private string ten = "";
        public itemCTTour(string stt, string ngay, string ten, List<DIADIEMDULICH> a)
        {
            InitializeComponent();
            this.sn = stt;
            this.ng = ngay;
            this.ten = ten;
            lbl_SoNgay.Text = this.sn;
            lbl_Ngay.Text = this.ng;
            lbl_TenChuongTrinh.Text = this.ten;
            foreach (DIADIEMDULICH item in a)
            {
                string tendd = "";
                string chitiet = "";
                if (item.TENDIADIEM.ToString() != "" && item.CHITIET.ToString() != "")
                {
                    tendd = item.TENDIADIEM.ToString();
                    chitiet = item.CHITIET.ToString();
                    itemDiaDiem itemd = new itemDiaDiem(tendd, chitiet);
                    tableLayoutPanel_DiaDiem.Controls.Add(itemd);
                    this.Height += 80;
                }
            }

            this.Dock = DockStyle.Fill;
        }
        
        private void itemCTTour_Load(object sender, EventArgs e)
        {
            lbl_SoNgay.Text = this.sn;
            this.Dock = DockStyle.Fill;
        }
    }
}
