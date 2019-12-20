using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class TuyenLe : Label
    {
        public TuyenLe()
        {
            TextBox x = new TextBox();
            x.Text = "Lê Thanh Tuyên";
            Point pt = new Point( 0, 0);
            x.Location = pt;
            this.Controls.Add(x);
        }
    }
}
