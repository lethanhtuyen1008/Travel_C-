using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class UC_DiaDiem
    {
        private string _TenDiaDiem;

        public string TenDiaDiem
        {
            get { return _TenDiaDiem; }
            set { _TenDiaDiem = value; }
        }
        private string _ChiTiet;

        public string ChiTiet
        {
            get { return _ChiTiet; }
            set { _ChiTiet = value; }
        }
        public UC_DiaDiem(string ten, string chitiet)
        {
            this.ChiTiet = chitiet;
            this.TenDiaDiem = ten;
        }
    }
}
