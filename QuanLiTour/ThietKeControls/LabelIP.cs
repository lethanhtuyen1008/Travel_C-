using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;


namespace ThietKeControls
{
    public class LabelIP: Label
    {
        public LabelIP()
        {
            this.Dock = DockStyle.Fill;
            this.ForeColor = Color.Black;
            this.Font = new Font(this.Font, FontStyle.Bold);

        }
    }
}
