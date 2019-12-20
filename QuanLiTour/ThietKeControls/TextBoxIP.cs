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
    public class TextBoxIP : TextBoxX
    {
    
        public TextBoxIP()
        {
            this.Enter += TextBoxIP_Enter;
            this.Leave += TextBoxIP_Leave;
            this.Dock = DockStyle.Top;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.Font = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            this.Height = 12;
            this.BackColor = Color.White;
            this.Multiline = false;
        }
        private void TextBoxIP_Enter(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.BackColor = Color.Azure;
            a.ForeColor = Color.Black;
        }
        private void TextBoxIP_Leave(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.BackColor = Color.White;
            a.ForeColor = Color.Black;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxIP
            // 
            // 
            // 
            // 
            this.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ResumeLayout(false);

        }
    }
}
