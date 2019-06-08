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
            this.dgvNgayThucHien = new System.Windows.Forms.DataGridView();
            this.cmsThucDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMonSang1 = new System.Windows.Forms.Label();
            this.lbMonSang2 = new System.Windows.Forms.Label();
            this.lbMonXe2 = new System.Windows.Forms.Label();
            this.lbMonXe1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMonTrua2 = new System.Windows.Forms.Label();
            this.lbMonTrua1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMonTrua4 = new System.Windows.Forms.Label();
            this.lbMonTrua3 = new System.Windows.Forms.Label();
            this.lbMonXe4 = new System.Windows.Forms.Label();
            this.lbMonXe3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btnHuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.food_menu_managermentDataSet = new QlThucDon.food_menu_managermentDataSet();
            this.thucDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thucDonTableAdapter = new QlThucDon.food_menu_managermentDataSetTableAdapters.ThucDonTableAdapter();
            this.ngayThucHienThucDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNgayThucHien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgayThucHien)).BeginInit();
            this.cmsThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_menu_managermentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày";
            // 
            // dgvNgayThucHien
            // 
            this.dgvNgayThucHien.AutoGenerateColumns = false;
            this.dgvNgayThucHien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgayThucHien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayThucHienThucDonDataGridViewTextBoxColumn});
            this.dgvNgayThucHien.ContextMenuStrip = this.cmsThucDon;
            this.dgvNgayThucHien.DataSource = this.thucDonBindingSource;
            this.dgvNgayThucHien.Location = new System.Drawing.Point(47, 63);
            this.dgvNgayThucHien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNgayThucHien.Name = "dgvNgayThucHien";
            this.dgvNgayThucHien.RowTemplate.Height = 24;
            this.dgvNgayThucHien.Size = new System.Drawing.Size(186, 334);
            this.dgvNgayThucHien.TabIndex = 1;
            this.dgvNgayThucHien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgayThucHien_CellClick);
            this.dgvNgayThucHien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin thực đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sáng";
            // 
            // lbMonSang1
            // 
            this.lbMonSang1.AutoSize = true;
            this.lbMonSang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonSang1.Location = new System.Drawing.Point(396, 75);
            this.lbMonSang1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonSang1.Name = "lbMonSang1";
            this.lbMonSang1.Size = new System.Drawing.Size(43, 17);
            this.lbMonSang1.TabIndex = 4;
            this.lbMonSang1.Text = "Mon1";
            // 
            // lbMonSang2
            // 
            this.lbMonSang2.AutoSize = true;
            this.lbMonSang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonSang2.Location = new System.Drawing.Point(396, 110);
            this.lbMonSang2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonSang2.Name = "lbMonSang2";
            this.lbMonSang2.Size = new System.Drawing.Size(43, 17);
            this.lbMonSang2.TabIndex = 5;
            this.lbMonSang2.Text = "Mon2";
            // 
            // lbMonXe2
            // 
            this.lbMonXe2.AutoSize = true;
            this.lbMonXe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe2.Location = new System.Drawing.Point(583, 110);
            this.lbMonXe2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe2.Name = "lbMonXe2";
            this.lbMonXe2.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe2.TabIndex = 8;
            this.lbMonXe2.Text = "Mon2";
            // 
            // lbMonXe1
            // 
            this.lbMonXe1.AutoSize = true;
            this.lbMonXe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe1.Location = new System.Drawing.Point(583, 75);
            this.lbMonXe1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe1.Name = "lbMonXe1";
            this.lbMonXe1.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe1.TabIndex = 7;
            this.lbMonXe1.Text = "Mon1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Xế 1";
            // 
            // lbMonTrua2
            // 
            this.lbMonTrua2.AutoSize = true;
            this.lbMonTrua2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua2.Location = new System.Drawing.Point(396, 201);
            this.lbMonTrua2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua2.Name = "lbMonTrua2";
            this.lbMonTrua2.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua2.TabIndex = 11;
            this.lbMonTrua2.Text = "Mon2";
            // 
            // lbMonTrua1
            // 
            this.lbMonTrua1.AutoSize = true;
            this.lbMonTrua1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua1.Location = new System.Drawing.Point(396, 166);
            this.lbMonTrua1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua1.Name = "lbMonTrua1";
            this.lbMonTrua1.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua1.TabIndex = 10;
            this.lbMonTrua1.Text = "Mon1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(316, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Trưa";
            // 
            // lbMonTrua4
            // 
            this.lbMonTrua4.AutoSize = true;
            this.lbMonTrua4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua4.Location = new System.Drawing.Point(396, 269);
            this.lbMonTrua4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua4.Name = "lbMonTrua4";
            this.lbMonTrua4.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua4.TabIndex = 13;
            this.lbMonTrua4.Text = "Mon2";
            // 
            // lbMonTrua3
            // 
            this.lbMonTrua3.AutoSize = true;
            this.lbMonTrua3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonTrua3.Location = new System.Drawing.Point(396, 234);
            this.lbMonTrua3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonTrua3.Name = "lbMonTrua3";
            this.lbMonTrua3.Size = new System.Drawing.Size(43, 17);
            this.lbMonTrua3.TabIndex = 12;
            this.lbMonTrua3.Text = "Mon1";
            // 
            // lbMonXe4
            // 
            this.lbMonXe4.AutoSize = true;
            this.lbMonXe4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe4.Location = new System.Drawing.Point(583, 201);
            this.lbMonXe4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe4.Name = "lbMonXe4";
            this.lbMonXe4.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe4.TabIndex = 16;
            this.lbMonXe4.Text = "Mon2";
            // 
            // lbMonXe3
            // 
            this.lbMonXe3.AutoSize = true;
            this.lbMonXe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonXe3.Location = new System.Drawing.Point(583, 166);
            this.lbMonXe3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonXe3.Name = "lbMonXe3";
            this.lbMonXe3.Size = new System.Drawing.Size(43, 17);
            this.lbMonXe3.TabIndex = 15;
            this.lbMonXe3.Text = "Mon1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(502, 166);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Xế 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(316, 318);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Thông tin dinh dưỡng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(320, 444);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "Xế 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(318, 413);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Trưa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(320, 380);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 17);
            this.label20.TabIndex = 20;
            this.label20.Text = "Xế 1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(318, 344);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Sáng";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(388, 344);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 17);
            this.label22.TabIndex = 23;
            this.label22.Text = "Năng lượng";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(480, 344);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 17);
            this.label23.TabIndex = 24;
            this.label23.Text = "Đạm";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(542, 344);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 17);
            this.label24.TabIndex = 25;
            this.label24.Text = "Chất béo";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(614, 344);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 17);
            this.label25.TabIndex = 26;
            this.label25.Text = "Tinh bột";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(614, 380);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 17);
            this.label26.TabIndex = 30;
            this.label26.Text = "Tinh bột";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(542, 380);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 17);
            this.label27.TabIndex = 29;
            this.label27.Text = "Chất béo";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(480, 380);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 17);
            this.label28.TabIndex = 28;
            this.label28.Text = "Đạm";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(388, 380);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 17);
            this.label29.TabIndex = 27;
            this.label29.Text = "Năng lượng";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(614, 413);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 17);
            this.label30.TabIndex = 34;
            this.label30.Text = "Tinh bột";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(542, 413);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 17);
            this.label31.TabIndex = 33;
            this.label31.Text = "Chất béo";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(480, 413);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 17);
            this.label32.TabIndex = 32;
            this.label32.Text = "Đạm";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(388, 413);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(81, 17);
            this.label33.TabIndex = 31;
            this.label33.Text = "Năng lượng";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(614, 444);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(60, 17);
            this.label34.TabIndex = 38;
            this.label34.Text = "Tinh bột";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(542, 444);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(65, 17);
            this.label35.TabIndex = 37;
            this.label35.Text = "Chất béo";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(480, 444);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 17);
            this.label36.TabIndex = 36;
            this.label36.Text = "Đạm";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(388, 444);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(81, 17);
            this.label37.TabIndex = 35;
            this.label37.Text = "Năng lượng";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(528, 33);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(68, 17);
            this.label38.TabIndex = 39;
            this.label38.Text = "Số lượng:";
            // 
            // btnHuy
            // 
            this.btnHuy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.ButtonText = "Xóa";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledColor = System.Drawing.Color.Gray;
            this.btnHuy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHuy.Iconimage = null;
            this.btnHuy.Iconimage_right = null;
            this.btnHuy.Iconimage_right_Selected = null;
            this.btnHuy.Iconimage_Selected = null;
            this.btnHuy.IconMarginLeft = 0;
            this.btnHuy.IconMarginRight = 0;
            this.btnHuy.IconRightVisible = true;
            this.btnHuy.IconRightZoom = 0D;
            this.btnHuy.IconVisible = true;
            this.btnHuy.IconZoom = 90D;
            this.btnHuy.IsTab = false;
            this.btnHuy.Location = new System.Drawing.Point(164, 413);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnHuy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.btnHuy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuy.selected = false;
            this.btnHuy.Size = new System.Drawing.Size(80, 37);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "Xóa";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Textcolor = System.Drawing.Color.White;
            this.btnHuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 0;
            this.btnLuu.ButtonText = "Chỉnh sửa";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = null;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 90D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(58, 413);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(80, 37);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "Chỉnh sửa";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            // ngayThucHienThucDonDataGridViewTextBoxColumn
            // 
            this.ngayThucHienThucDonDataGridViewTextBoxColumn.DataPropertyName = "NgayThucHienThucDon";
            this.ngayThucHienThucDonDataGridViewTextBoxColumn.HeaderText = "NgayThucHienThucDon";
            this.ngayThucHienThucDonDataGridViewTextBoxColumn.Name = "ngayThucHienThucDonDataGridViewTextBoxColumn";
            // 
            // cbNgayThucHien
            // 
            this.cbNgayThucHien.FormattingEnabled = true;
            this.cbNgayThucHien.Location = new System.Drawing.Point(696, 53);
            this.cbNgayThucHien.Name = "cbNgayThucHien";
            this.cbNgayThucHien.Size = new System.Drawing.Size(121, 21);
            this.cbNgayThucHien.TabIndex = 42;
            this.cbNgayThucHien.SelectedValueChanged += new System.EventHandler(this.cbNgayThucHien_SelectedValueChanged);
            // 
            // UCLoadThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbNgayThucHien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbMonXe4);
            this.Controls.Add(this.lbMonXe3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbMonTrua4);
            this.Controls.Add(this.lbMonTrua3);
            this.Controls.Add(this.lbMonTrua2);
            this.Controls.Add(this.lbMonTrua1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbMonXe2);
            this.Controls.Add(this.lbMonXe1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbMonSang2);
            this.Controls.Add(this.lbMonSang1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNgayThucHien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCLoadThucDon";
            this.Size = new System.Drawing.Size(862, 488);
            this.Load += new System.EventHandler(this.UCLoadThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgayThucHien)).EndInit();
            this.cmsThucDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.food_menu_managermentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thucDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNgayThucHien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMonSang1;
        private System.Windows.Forms.Label lbMonSang2;
        private System.Windows.Forms.Label lbMonXe2;
        private System.Windows.Forms.Label lbMonXe1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMonTrua2;
        private System.Windows.Forms.Label lbMonTrua1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbMonTrua4;
        private System.Windows.Forms.Label lbMonTrua3;
        private System.Windows.Forms.Label lbMonXe4;
        private System.Windows.Forms.Label lbMonXe3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ContextMenuStrip cmsThucDon;
        private System.Windows.Forms.ToolStripMenuItem thêmThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuy;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThucHienThucDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource thucDonBindingSource;
        private food_menu_managermentDataSet food_menu_managermentDataSet;
        private food_menu_managermentDataSetTableAdapters.ThucDonTableAdapter thucDonTableAdapter;
        private System.Windows.Forms.ComboBox cbNgayThucHien;
    }
}
