namespace QuanLiTour
{
    partial class MH_CauHinhServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cauHinhServer1 = new QuanLiTour.CauHinhServer();
            this.SuspendLayout();
            // 
            // cauHinhServer1
            // 
            this.cauHinhServer1.Location = new System.Drawing.Point(64, 42);
            this.cauHinhServer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cauHinhServer1.Name = "cauHinhServer1";
            this.cauHinhServer1.Size = new System.Drawing.Size(725, 462);
            this.cauHinhServer1.TabIndex = 0;
            // 
            // MH_CauHinhServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 573);
            this.Controls.Add(this.cauHinhServer1);
            this.Name = "MH_CauHinhServer";
            this.Text = "MH_CauHinhServer";
            this.ResumeLayout(false);

        }

        #endregion

        private CauHinhServer cauHinhServer1;
    }
}