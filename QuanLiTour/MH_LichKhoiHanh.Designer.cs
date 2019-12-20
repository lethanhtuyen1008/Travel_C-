namespace QuanLiTour
{
    partial class MH_LichKhoiHanh
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_LichKH = new DevExpress.XtraGrid.GridControl();
            this.gridView_LichKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel_TTLich = new System.Windows.Forms.TableLayoutPanel();
            this.labelIP1 = new ThietKeControls.LabelIP();
            this.labelIP2 = new ThietKeControls.LabelIP();
            this.labelIP3 = new ThietKeControls.LabelIP();
            this.labelIP4 = new ThietKeControls.LabelIP();
            this.cbo_MaLich = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbo_Tour = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_TenLich = new ThietKeControls.TextBoxIP();
            this.txt_SoChoTrong = new ThietKeControls.TextBoxIP();
            this.labelIP6 = new ThietKeControls.LabelIP();
            this.txt_NgayKhoiHanh = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.btn_Huy = new DevComponents.DotNetBar.ButtonX();
            this.btn_Sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_Xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_Them = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LichKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LichKH)).BeginInit();
            this.tableLayoutPanel_TTLich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKhoiHanh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKhoiHanh.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gridControl_LichKH, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel_TTLich, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.0515F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.9485F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 466);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gridControl_LichKH
            // 
            this.gridControl_LichKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_LichKH.Location = new System.Drawing.Point(3, 170);
            this.gridControl_LichKH.MainView = this.gridView_LichKH;
            this.gridControl_LichKH.Name = "gridControl_LichKH";
            this.gridControl_LichKH.Size = new System.Drawing.Size(696, 293);
            this.gridControl_LichKH.TabIndex = 0;
            this.gridControl_LichKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_LichKH});
            this.gridControl_LichKH.Click += new System.EventHandler(this.gridControl_LichKH_Click);
            // 
            // gridView_LichKH
            // 
            this.gridView_LichKH.GridControl = this.gridControl_LichKH;
            this.gridView_LichKH.Name = "gridView_LichKH";
            this.gridView_LichKH.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            // 
            // tableLayoutPanel_TTLich
            // 
            this.tableLayoutPanel_TTLich.ColumnCount = 4;
            this.tableLayoutPanel_TTLich.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_TTLich.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_TTLich.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_TTLich.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_TTLich.Controls.Add(this.labelIP1, 0, 0);
            this.tableLayoutPanel_TTLich.Controls.Add(this.labelIP2, 0, 1);
            this.tableLayoutPanel_TTLich.Controls.Add(this.labelIP3, 2, 0);
            this.tableLayoutPanel_TTLich.Controls.Add(this.labelIP4, 0, 2);
            this.tableLayoutPanel_TTLich.Controls.Add(this.cbo_MaLich, 1, 0);
            this.tableLayoutPanel_TTLich.Controls.Add(this.cbo_Tour, 1, 2);
            this.tableLayoutPanel_TTLich.Controls.Add(this.txt_TenLich, 1, 1);
            this.tableLayoutPanel_TTLich.Controls.Add(this.txt_SoChoTrong, 3, 0);
            this.tableLayoutPanel_TTLich.Controls.Add(this.labelIP6, 2, 1);
            this.tableLayoutPanel_TTLich.Controls.Add(this.txt_NgayKhoiHanh, 3, 1);
            this.tableLayoutPanel_TTLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TTLich.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TTLich.Name = "tableLayoutPanel_TTLich";
            this.tableLayoutPanel_TTLich.RowCount = 3;
            this.tableLayoutPanel_TTLich.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_TTLich.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_TTLich.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_TTLich.Size = new System.Drawing.Size(696, 161);
            this.tableLayoutPanel_TTLich.TabIndex = 1;
            // 
            // labelIP1
            // 
            this.labelIP1.AutoSize = true;
            this.labelIP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelIP1.ForeColor = System.Drawing.Color.Black;
            this.labelIP1.Location = new System.Drawing.Point(3, 0);
            this.labelIP1.Name = "labelIP1";
            this.labelIP1.Size = new System.Drawing.Size(98, 53);
            this.labelIP1.TabIndex = 0;
            this.labelIP1.Text = "Mã lịch";
            // 
            // labelIP2
            // 
            this.labelIP2.AutoSize = true;
            this.labelIP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelIP2.ForeColor = System.Drawing.Color.Black;
            this.labelIP2.Location = new System.Drawing.Point(3, 53);
            this.labelIP2.Name = "labelIP2";
            this.labelIP2.Size = new System.Drawing.Size(98, 53);
            this.labelIP2.TabIndex = 1;
            this.labelIP2.Text = "Tên lịch";
            // 
            // labelIP3
            // 
            this.labelIP3.AutoSize = true;
            this.labelIP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelIP3.ForeColor = System.Drawing.Color.Black;
            this.labelIP3.Location = new System.Drawing.Point(350, 0);
            this.labelIP3.Name = "labelIP3";
            this.labelIP3.Size = new System.Drawing.Size(98, 53);
            this.labelIP3.TabIndex = 2;
            this.labelIP3.Text = "Số chỗ trống";
            // 
            // labelIP4
            // 
            this.labelIP4.AutoSize = true;
            this.labelIP4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelIP4.ForeColor = System.Drawing.Color.Black;
            this.labelIP4.Location = new System.Drawing.Point(3, 106);
            this.labelIP4.Name = "labelIP4";
            this.labelIP4.Size = new System.Drawing.Size(98, 55);
            this.labelIP4.TabIndex = 3;
            this.labelIP4.Text = "Tên tour";
            // 
            // cbo_MaLich
            // 
            this.cbo_MaLich.DisplayMember = "Text";
            this.cbo_MaLich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_MaLich.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_MaLich.FormattingEnabled = true;
            this.cbo_MaLich.ItemHeight = 16;
            this.cbo_MaLich.Location = new System.Drawing.Point(107, 3);
            this.cbo_MaLich.Name = "cbo_MaLich";
            this.cbo_MaLich.Size = new System.Drawing.Size(237, 22);
            this.cbo_MaLich.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_MaLich.TabIndex = 6;
            // 
            // cbo_Tour
            // 
            this.cbo_Tour.DisplayMember = "Text";
            this.cbo_Tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_Tour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_Tour.FormattingEnabled = true;
            this.cbo_Tour.ItemHeight = 16;
            this.cbo_Tour.Location = new System.Drawing.Point(107, 109);
            this.cbo_Tour.Name = "cbo_Tour";
            this.cbo_Tour.Size = new System.Drawing.Size(237, 22);
            this.cbo_Tour.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbo_Tour.TabIndex = 7;
            // 
            // txt_TenLich
            // 
            this.txt_TenLich.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_TenLich.Border.Class = "TextBoxBorder";
            this.txt_TenLich.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenLich.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_TenLich.Location = new System.Drawing.Point(107, 56);
            this.txt_TenLich.Name = "txt_TenLich";
            this.txt_TenLich.PreventEnterBeep = true;
            this.txt_TenLich.Size = new System.Drawing.Size(237, 22);
            this.txt_TenLich.TabIndex = 8;
            // 
            // txt_SoChoTrong
            // 
            this.txt_SoChoTrong.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_SoChoTrong.Border.Class = "TextBoxBorder";
            this.txt_SoChoTrong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SoChoTrong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_SoChoTrong.Location = new System.Drawing.Point(454, 3);
            this.txt_SoChoTrong.Name = "txt_SoChoTrong";
            this.txt_SoChoTrong.PreventEnterBeep = true;
            this.txt_SoChoTrong.Size = new System.Drawing.Size(239, 22);
            this.txt_SoChoTrong.TabIndex = 9;
            // 
            // labelIP6
            // 
            this.labelIP6.AutoSize = true;
            this.labelIP6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelIP6.ForeColor = System.Drawing.Color.Black;
            this.labelIP6.Location = new System.Drawing.Point(350, 53);
            this.labelIP6.Name = "labelIP6";
            this.labelIP6.Size = new System.Drawing.Size(98, 53);
            this.labelIP6.TabIndex = 5;
            this.labelIP6.Text = "Ngày khời hành";
            // 
            // txt_NgayKhoiHanh
            // 
            this.txt_NgayKhoiHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NgayKhoiHanh.EditValue = null;
            this.txt_NgayKhoiHanh.Location = new System.Drawing.Point(454, 56);
            this.txt_NgayKhoiHanh.Name = "txt_NgayKhoiHanh";
            this.txt_NgayKhoiHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgayKhoiHanh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgayKhoiHanh.Size = new System.Drawing.Size(239, 22);
            this.txt_NgayKhoiHanh.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Luu, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btn_Huy, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btn_Sua, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btn_Xoa, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_Them, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(118, 242);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Location = new System.Drawing.Point(3, 195);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(112, 44);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.Symbol = "";
            this.btn_Luu.SymbolColor = System.Drawing.Color.Blue;
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Huy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Huy.Enabled = false;
            this.btn_Huy.Location = new System.Drawing.Point(3, 147);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(112, 42);
            this.btn_Huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Huy.Symbol = "";
            this.btn_Huy.SymbolColor = System.Drawing.Color.Red;
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Sua.Location = new System.Drawing.Point(3, 99);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(112, 42);
            this.btn_Sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sua.Symbol = "";
            this.btn_Sua.SymbolColor = System.Drawing.Color.Aqua;
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "  Sửa lịch";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.Location = new System.Drawing.Point(3, 51);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(112, 42);
            this.btn_Xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Xoa.Symbol = "";
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa lịch";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Them.Location = new System.Drawing.Point(3, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(112, 42);
            this.btn_Them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Them.Symbol = "";
            this.btn_Them.SymbolColor = System.Drawing.Color.Green;
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm lịch";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // MH_LichKhoiHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MH_LichKhoiHanh";
            this.Text = "MH_LichKhoiHanh";
            this.Load += new System.EventHandler(this.MH_LichKhoiHanh_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LichKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LichKH)).EndInit();
            this.tableLayoutPanel_TTLich.ResumeLayout(false);
            this.tableLayoutPanel_TTLich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKhoiHanh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKhoiHanh.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gridControl_LichKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_LichKH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TTLich;
        private ThietKeControls.LabelIP labelIP1;
        private ThietKeControls.LabelIP labelIP2;
        private ThietKeControls.LabelIP labelIP3;
        private ThietKeControls.LabelIP labelIP4;
        private ThietKeControls.LabelIP labelIP6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_MaLich;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbo_Tour;
        private ThietKeControls.TextBoxIP txt_TenLich;
        private ThietKeControls.TextBoxIP txt_SoChoTrong;
        private DevExpress.XtraEditors.DateEdit txt_NgayKhoiHanh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private DevComponents.DotNetBar.ButtonX btn_Huy;
        private DevComponents.DotNetBar.ButtonX btn_Sua;
        private DevComponents.DotNetBar.ButtonX btn_Xoa;
        private DevComponents.DotNetBar.ButtonX btn_Them;
    }
}