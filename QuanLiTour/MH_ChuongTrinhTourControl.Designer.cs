namespace QuanLiTour
{
    partial class MH_ChuongTrinhTourControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_TenChuongTrinh = new System.Windows.Forms.Label();
            this.lbl_Ngay = new System.Windows.Forms.Label();
            this.label_SoNgay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TenChuongTrinh
            // 
            this.label_TenChuongTrinh.AutoSize = true;
            this.label_TenChuongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TenChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenChuongTrinh.ForeColor = System.Drawing.Color.Crimson;
            this.label_TenChuongTrinh.Location = new System.Drawing.Point(162, 0);
            this.label_TenChuongTrinh.Name = "label_TenChuongTrinh";
            this.label_TenChuongTrinh.Size = new System.Drawing.Size(698, 47);
            this.label_TenChuongTrinh.TabIndex = 2;
            this.label_TenChuongTrinh.Text = "Thành phố Hồ Chí Minh -  Trương Gia Giới";
            this.label_TenChuongTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Ngay
            // 
            this.lbl_Ngay.AutoSize = true;
            this.lbl_Ngay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngay.Location = new System.Drawing.Point(3, 47);
            this.lbl_Ngay.Name = "lbl_Ngay";
            this.lbl_Ngay.Size = new System.Drawing.Size(153, 20);
            this.lbl_Ngay.TabIndex = 1;
            this.lbl_Ngay.Text = "12/5/2019";
            this.lbl_Ngay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SoNgay
            // 
            this.label_SoNgay.AutoSize = true;
            this.label_SoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoNgay.ForeColor = System.Drawing.Color.Crimson;
            this.label_SoNgay.Location = new System.Drawing.Point(3, 0);
            this.label_SoNgay.Name = "label_SoNgay";
            this.label_SoNgay.Size = new System.Drawing.Size(153, 47);
            this.label_SoNgay.TabIndex = 0;
            this.label_SoNgay.Text = "Ngày 1";
            this.label_SoNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.53998F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.46002F));
            this.tableLayoutPanel1.Controls.Add(this.label_SoNgay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Ngay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_TenChuongTrinh, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(863, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MH_ChuongTrinhTourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MH_ChuongTrinhTourControl";
            this.Size = new System.Drawing.Size(863, 235);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_TenChuongTrinh;
        private System.Windows.Forms.Label lbl_Ngay;
        private System.Windows.Forms.Label label_SoNgay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;



    }
}
