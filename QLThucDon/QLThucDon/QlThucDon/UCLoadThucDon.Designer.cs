namespace QlThucDon
{
    partial class UCLoadThucDon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsThucDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.food_menu_managermentDataSet = new QlThucDon.food_menu_managermentDataSet();
            this.thucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucDonTableAdapter = new QlThucDon.food_menu_managermentDataSetTableAdapters.ThucDonTableAdapter();
            this.cbNgayThucHien = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbMonXe4 = new System.Windows.Forms.Label();
            this.lbMonXe3 = new System.Windows.Forms.Label();
            this.lbXe2 = new System.Windows.Forms.Label();
            this.lbMonTrua4 = new System.Windows.Forms.Label();
            this.lbMonTrua3 = new System.Windows.Forms.Label();
            this.lbMonTrua2 = new System.Windows.Forms.Label();
            this.lbMonTrua1 = new System.Windows.Forms.Label();
            this.lbBuoiTrua = new System.Windows.Forms.Label();
            this.lbMonXe2 = new System.Windows.Forms.Label();
            this.lbMonXe1 = new System.Windows.Forms.Label();
            this.lbXe1 = new System.Windows.Forms.Label();
            this.lbMonSang2 = new System.Windows.Forms.Label();
            this.lbMonSang1 = new System.Windows.Forms.Label();
            this.lbBuoiSang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_menu_managermentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày thực hiện:";
            // 
            // cmsThucDon
            // 
            this.cmsThucDon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsThucDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThựcĐơnToolStripMenuItem,
            this.sửaThựcĐơnToolStripMenuItem,
            this.xóaThựcĐơnToolStripMenuItem});
            this.cmsThucDon.Name = "cmsThucDon";
            this.cmsThucDon.Size = new System.Drawing.Size(157, 70);
            // 
            // thêmThựcĐơnToolStripMenuItem
            // 
            this.thêmThựcĐơnToolStripMenuItem.Name = "thêmThựcĐơnToolStripMenuItem";
            this.thêmThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.thêmThựcĐơnToolStripMenuItem.Text = "Thêm thực đơn";
            // 
            // sửaThựcĐơnToolStripMenuItem
            // 
            this.sửaThựcĐơnToolStripMenuItem.Name = "sửaThựcĐơnToolStripMenuItem";
            this.sửaThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sửaThựcĐơnToolStripMenuItem.Text = "Sửa thực đơn";
            // 
            // xóaThựcĐơnToolStripMenuItem
            // 
            this.xóaThựcĐơnToolStripMenuItem.Name = "xóaThựcĐơnToolStripMenuItem";
            this.xóaThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.xóaThựcĐơnToolStripMenuItem.Text = "Xóa thực đơn";
            // 
            // food_menu_managermentDataSet
            // 
            this.food_menu_managermentDataSet.DataSetName = "food_menu_managermentDataSet";
            this.food_menu_managermentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thucDonBindingSource
            // 
            this.thucDonBindingSource.DataMember = "ThucDon";
            this.thucDonBindingSource.DataSource = this.food_menu_managermentDataSet;
            // 
            // thucDonTableAdapter
            // 
            this.thucDonTableAdapter.ClearBeforeFill = true;
            // 
            // cbNgayThucHien
            // 
            this.cbNgayThucHien.FormattingEnabled = true;
            this.cbNgayThucHien.Location = new System.Drawing.Point(454, 46);
            this.cbNgayThucHien.Name = "cbNgayThucHien";
            this.cbNgayThucHien.Size = new System.Drawing.Size(140, 21);
            this.cbNgayThucHien.TabIndex = 42;
            this.cbNgayThucHien.SelectedValueChanged += new System.EventHandler(this.cbNgayThucHien_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.lbMonXe4);
            this.panel1.Controls.Add(this.lbMonXe3);
            this.panel1.Controls.Add(this.lbXe2);
            this.panel1.Controls.Add(this.lbMonTrua4);
            this.panel1.Controls.Add(this.lbMonTrua3);
            this.panel1.Controls.Add(this.lbMonTrua2);
            this.panel1.Controls.Add(this.lbMonTrua1);
            this.panel1.Controls.Add(this.lbBuoiTrua);
            this.panel1.Controls.Add(this.lbMonXe2);
            this.panel1.Controls.Add(this.lbMonXe1);
            this.panel1.Controls.Add(this.lbXe1);
            this.panel1.Controls.Add(this.lbMonSang2);
            this.panel1.Controls.Add(this.lbMonSang1);
            this.panel1.Controls.Add(this.lbBuoiSang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 326);
            this.panel1.TabIndex = 43;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(435, 22);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(68, 17);
            this.lbSoLuong.TabIndex = 55;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // lbMonXe4
            // 
            this.lbMonXe4.AutoSize = true;
            this.lbMonXe4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe4.Location = new System.Drawing.Point(515, 189);
            this.lbMonXe4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe4.Name = "lbMonXe4";
            this.lbMonXe4.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe4.TabIndex = 54;
            this.lbMonXe4.Text = "Mon2";
            // 
            // lbMonXe3
            // 
            this.lbMonXe3.AutoSize = true;
            this.lbMonXe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe3.Location = new System.Drawing.Point(515, 154);
            this.lbMonXe3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe3.Name = "lbMonXe3";
            this.lbMonXe3.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe3.TabIndex = 53;
            this.lbMonXe3.Text = "Mon1";
            // 
            // lbXe2
            // 
            this.lbXe2.AutoSize = true;
            this.lbXe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXe2.Location = new System.Drawing.Point(435, 154);
            this.lbXe2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXe2.Name = "lbXe2";
            this.lbXe2.Size = new System.Drawing.Size(41, 17);
            this.lbXe2.TabIndex = 52;
            this.lbXe2.Text = "Xế 2:";
            // 
            // lbMonTrua4
            // 
            this.lbMonTrua4.AutoSize = true;
            this.lbMonTrua4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua4.Location = new System.Drawing.Point(259, 257);
            this.lbMonTrua4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua4.Name = "lbMonTrua4";
            this.lbMonTrua4.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua4.TabIndex = 51;
            this.lbMonTrua4.Text = "Mon2";
            // 
            // lbMonTrua3
            // 
            this.lbMonTrua3.AutoSize = true;
            this.lbMonTrua3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua3.Location = new System.Drawing.Point(259, 222);
            this.lbMonTrua3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua3.Name = "lbMonTrua3";
            this.lbMonTrua3.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua3.TabIndex = 50;
            this.lbMonTrua3.Text = "Mon1";
            // 
            // lbMonTrua2
            // 
            this.lbMonTrua2.AutoSize = true;
            this.lbMonTrua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua2.Location = new System.Drawing.Point(259, 189);
            this.lbMonTrua2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua2.Name = "lbMonTrua2";
            this.lbMonTrua2.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua2.TabIndex = 49;
            this.lbMonTrua2.Text = "Mon2";
            // 
            // lbMonTrua1
            // 
            this.lbMonTrua1.AutoSize = true;
            this.lbMonTrua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua1.Location = new System.Drawing.Point(259, 154);
            this.lbMonTrua1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua1.Name = "lbMonTrua1";
            this.lbMonTrua1.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua1.TabIndex = 48;
            this.lbMonTrua1.Text = "Mon1";
            // 
            // lbBuoiTrua
            // 
            this.lbBuoiTrua.AutoSize = true;
            this.lbBuoiTrua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuoiTrua.Location = new System.Drawing.Point(194, 151);
            this.lbBuoiTrua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuoiTrua.Name = "lbBuoiTrua";
            this.lbBuoiTrua.Size = new System.Drawing.Size(42, 17);
            this.lbBuoiTrua.TabIndex = 47;
            this.lbBuoiTrua.Text = "Trưa:";
            // 
            // lbMonXe2
            // 
            this.lbMonXe2.AutoSize = true;
            this.lbMonXe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe2.Location = new System.Drawing.Point(515, 98);
            this.lbMonXe2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe2.Name = "lbMonXe2";
            this.lbMonXe2.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe2.TabIndex = 46;
            this.lbMonXe2.Text = "Mon2";
            // 
            // lbMonXe1
            // 
            this.lbMonXe1.AutoSize = true;
            this.lbMonXe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe1.Location = new System.Drawing.Point(515, 63);
            this.lbMonXe1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe1.Name = "lbMonXe1";
            this.lbMonXe1.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe1.TabIndex = 45;
            this.lbMonXe1.Text = "Mon1";
            // 
            // lbXe1
            // 
            this.lbXe1.AutoSize = true;
            this.lbXe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXe1.Location = new System.Drawing.Point(435, 63);
            this.lbXe1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXe1.Name = "lbXe1";
            this.lbXe1.Size = new System.Drawing.Size(41, 17);
            this.lbXe1.TabIndex = 44;
            this.lbXe1.Text = "Xế 1:";
            // 
            // lbMonSang2
            // 
            this.lbMonSang2.AutoSize = true;
            this.lbMonSang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonSang2.Location = new System.Drawing.Point(259, 98);
            this.lbMonSang2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonSang2.Name = "lbMonSang2";
            this.lbMonSang2.Size = new System.Drawing.Size(43, 17);
            this.lbMonSang2.TabIndex = 43;
            this.lbMonSang2.Text = "Mon2";
            // 
            // lbMonSang1
            // 
            this.lbMonSang1.AutoSize = true;
            this.lbMonSang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonSang1.Location = new System.Drawing.Point(259, 63);
            this.lbMonSang1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonSang1.Name = "lbMonSang1";
            this.lbMonSang1.Size = new System.Drawing.Size(43, 17);
            this.lbMonSang1.TabIndex = 42;
            this.lbMonSang1.Text = "Mon1";
            // 
            // lbBuoiSang
            // 
            this.lbBuoiSang.AutoSize = true;
            this.lbBuoiSang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuoiSang.Location = new System.Drawing.Point(191, 63);
            this.lbBuoiSang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuoiSang.Name = "lbBuoiSang";
            this.lbBuoiSang.Size = new System.Drawing.Size(45, 17);
            this.lbBuoiSang.TabIndex = 41;
            this.lbBuoiSang.Text = "Sáng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Thông tin thực đơn:";
            // 
            // UCLoadThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbNgayThucHien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCLoadThucDon";
            this.Size = new System.Drawing.Size(862, 488);
            this.Load += new System.EventHandler(this.UCLoadThucDon_Load);
            this.cmsThucDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.food_menu_managermentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsThucDon;
        private System.Windows.Forms.ToolStripMenuItem thêmThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.BindingSource thucDonBindingSource;
        private food_menu_managermentDataSet food_menu_managermentDataSet;
        private food_menu_managermentDataSetTableAdapters.ThucDonTableAdapter thucDonTableAdapter;
        private System.Windows.Forms.ComboBox cbNgayThucHien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbMonXe4;
        private System.Windows.Forms.Label lbMonXe3;
        private System.Windows.Forms.Label lbXe2;
        private System.Windows.Forms.Label lbMonTrua4;
        private System.Windows.Forms.Label lbMonTrua3;
        private System.Windows.Forms.Label lbMonTrua2;
        private System.Windows.Forms.Label lbMonTrua1;
        private System.Windows.Forms.Label lbBuoiTrua;
        private System.Windows.Forms.Label lbMonXe2;
        private System.Windows.Forms.Label lbMonXe1;
        private System.Windows.Forms.Label lbXe1;
        private System.Windows.Forms.Label lbMonSang2;
        private System.Windows.Forms.Label lbMonSang1;
        private System.Windows.Forms.Label lbBuoiSang;
        private System.Windows.Forms.Label label2;
    }
}
