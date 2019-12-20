using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
using DAL_QuanLiTour;
namespace BUS_QuanLiTour
{
    public class BUS_DanhSachDiKiem
    {
        DAL_DanhSachDiKem dal = new DAL_DanhSachDiKem();
        public List<DANHSACHNGUOIDIKEM> getListDanhSachDiKem()
        {
            return dal.getListDanhSachDK();
        }
        public bool addDanhSachDiKem(DANHSACHNGUOIDIKEM a)
        {
            return dal.addDSDiKem(a);
        }
        public bool editDanhSachDiKem(DANHSACHNGUOIDIKEM a)
        {
            return dal.editDSDiKem(a);
        }
        public bool deleteDanhSachDiKem(string a)
        {
            return dal.deleteDSDiKem(a);
        }
        public string getMaDS()
        {
            return dal.getMaDS();
        }

    }
}
