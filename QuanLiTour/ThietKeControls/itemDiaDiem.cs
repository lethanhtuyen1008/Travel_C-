using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public partial class itemDiaDiem : UserControl
    {
        public itemDiaDiem(string TenDiaDiem, string chitiet)
        {
            InitializeComponent();
            lbl_TenDiaDiem.Text = TenDiaDiem;
            lbl_ChiTietDiaDiem.Text = chitiet;
        }
    }
}
