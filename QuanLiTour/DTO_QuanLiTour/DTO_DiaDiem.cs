using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_DiaDiem
    {
        private string _MADIADIEM;

        public string MADIADIEM
        {
            get { return _MADIADIEM; }
            set { _MADIADIEM = value; }
        }
        private string _MAQUOCGIA;

        public string MAQUOCGIA
        {
            get { return _MAQUOCGIA; }
            set { _MAQUOCGIA = value; }
        }
        private string _MATINH;

        public string MATINH
        {
            get { return _MATINH; }
            set { _MATINH = value; }
        }
        private string _TENDIADIEM;

        public string TENDIADIEM
        {
            get { return _TENDIADIEM; }
            set { _TENDIADIEM = value; }
        }
        private byte[] _HINH;

        public byte[] HINH
        {
            get { return _HINH; }
            set { _HINH = value; }
        }
        private string _CHITIET;

        public string CHITIET
        {
            get { return _CHITIET; }
            set { _CHITIET = value; }
        }
    }
}
