using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DAL_QuanLiTour
{
    public class DAL_DiaDiem
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public DataTable getListDiaDiem(string madd)
        {
            var a = db.DIADIEMDULICHes.Select(t => t);
            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in a)
            {
                if (firstPass)
                {
                    Array.ForEach(item.GetType().GetProperties(), p => resultTable.Columns.Add(new DataColumn(p.Name)));
                    firstPass = false;
                }
                var newRow = resultTable.NewRow();
                Array.ForEach(item.GetType().GetProperties(), p => newRow[p.Name] = p.GetValue(item, null));
                resultTable.Rows.Add(newRow);
            }
            return resultTable;
        }
        public List<DIADIEMDULICH> getAllDD()
        {
            return db.DIADIEMDULICHes.Select(t => t).ToList<DIADIEMDULICH>();
        }
        public DIADIEMDULICH getDiaDiem(string ma)
        {
            DIADIEMDULICH a = db.DIADIEMDULICHes.Where(t => t.MADIADIEM.Equals(ma)).FirstOrDefault();
            return a;
        }
    }
}
