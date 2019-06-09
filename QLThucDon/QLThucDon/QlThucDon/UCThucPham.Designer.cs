namespace QlThucDon
{
    partial class UCThucPham
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbNhomNguyenLieu = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.cmsThucPham = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGlucid_TP = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.lbLipit_TP = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.lbProtid_TP = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lbKcal_TP = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbNhomMonAn = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMonAn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvThanhPhanNguyenLieuCuaMonAn = new System.Windows.Forms.DataGridView();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGludcid_MA = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lbLipit_MA = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.lbProtid_MA = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.lbKcal_MA = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.cmsThucPham.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.cmsMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPhanNguyenLieuCuaMonAn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 37);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nhóm thực phẩm";
            // 
            // cbNhomNguyenLieu
            // 
            this.cbNhomNguyenLieu.FormattingEnabled = true;
            this.cbNhomNguyenLieu.Location = new System.Drawing.Point(155, 37);
            this.cbNhomNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhomNguyenLieu.Name = "cbNhomNguyenLieu";
            this.cbNhomNguyenLieu.Size = new System.Drawing.Size(92, 21);
            this.cbNhomNguyenLieu.TabIndex = 1;
            this.cbNhomNguyenLieu.SelectedIndexChanged += new System.EventHandler(this.cbNhomNguyenLieu_SelectedIndexChanged);
            this.cbNhomNguyenLieu.SelectedValueChanged += new System.EventHandler(this.cbNhomNguyenLieu_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 74);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(135, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Danh sách thực phẩm";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten});
            this.dgvNguyenLieu.ContextMenuStrip = this.cmsThucPham;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(20, 102);
            this.dgvNguyenLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowTemplate.Height = 24;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(226, 221);
            this.dgvNguyenLieu.TabIndex = 3;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieu_CellClick);
            // 
            // cmsThucPham
            // 
            this.cmsThucPham.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsThucPham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.cmsThucPham.Name = "cmsThucPham";
            this.cmsThucPham.Size = new System.Drawing.Size(128, 70);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbGlucid_TP);
            this.panel1.Controls.Add(this.metroLabel13);
            this.panel1.Controls.Add(this.lbLipit_TP);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.lbProtid_TP);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.lbKcal_TP);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Location = new System.Drawing.Point(20, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 179);
            this.panel1.TabIndex = 4;
            // 
            // lbGlucid_TP
            // 
            this.lbGlucid_TP.AutoSize = true;
            this.lbGlucid_TP.Location = new System.Drawing.Point(113, 145);
            this.lbGlucid_TP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGlucid_TP.Name = "lbGlucid_TP";
            this.lbGlucid_TP.Size = new System.Drawing.Size(0, 0);
            this.lbGlucid_TP.TabIndex = 40;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(9, 145);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(57, 19);
            this.metroLabel13.TabIndex = 39;
            this.metroLabel13.Text = "Tinh bột";
            // 
            // lbLipit_TP
            // 
            this.lbLipit_TP.AutoSize = true;
            this.lbLipit_TP.Location = new System.Drawing.Point(113, 115);
            this.lbLipit_TP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLipit_TP.Name = "lbLipit_TP";
            this.lbLipit_TP.Size = new System.Drawing.Size(0, 0);
            this.lbLipit_TP.TabIndex = 38;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(9, 115);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(63, 19);
            this.metroLabel11.TabIndex = 37;
            this.metroLabel11.Text = "Chất béo";
            // 
            // lbProtid_TP
            // 
            this.lbProtid_TP.AutoSize = true;
            this.lbProtid_TP.Location = new System.Drawing.Point(113, 84);
            this.lbProtid_TP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProtid_TP.Name = "lbProtid_TP";
            this.lbProtid_TP.Size = new System.Drawing.Size(0, 0);
            this.lbProtid_TP.TabIndex = 36;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(9, 84);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(67, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "Chất đạm";
            // 
            // lbKcal_TP
            // 
            this.lbKcal_TP.AutoSize = true;
            this.lbKcal_TP.Location = new System.Drawing.Point(113, 52);
            this.lbKcal_TP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKcal_TP.Name = "lbKcal_TP";
            this.lbKcal_TP.Size = new System.Drawing.Size(0, 0);
            this.lbKcal_TP.TabIndex = 34;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 52);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Năng lượng";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 15);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(210, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Giá trị dinh dưỡng của nguyên liệu";
            // 
            // cbNhomMonAn
            // 
            this.cbNhomMonAn.FormattingEnabled = true;
            this.cbNhomMonAn.Location = new System.Drawing.Point(386, 37);
            this.cbNhomMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhomMonAn.Name = "cbNhomMonAn";
            this.cbNhomMonAn.Size = new System.Drawing.Size(106, 21);
            this.cbNhomMonAn.TabIndex = 6;
            this.cbNhomMonAn.SelectedIndexChanged += new System.EventHandler(this.cbNhomMonAn_SelectedIndexChanged);
            this.cbNhomMonAn.SelectedValueChanged += new System.EventHandler(this.cbNhomMonAn_SelectedValueChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(287, 37);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Nhóm món ăn";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(287, 74);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(117, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Danh sách món ăn";
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonAn});
            this.dgvMonAn.ContextMenuStrip = this.cmsMonAn;
            this.dgvMonAn.Location = new System.Drawing.Point(287, 102);
            this.dgvMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.RowTemplate.Height = 24;
            this.dgvMonAn.Size = new System.Drawing.Size(249, 221);
            this.dgvMonAn.TabIndex = 8;
            this.dgvMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonAn_CellClick);
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.Frozen = true;
            this.TenMonAn.HeaderText = "Món ăn";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.ReadOnly = true;
            this.TenMonAn.Width = 250;
            // 
            // cmsMonAn
            // 
            this.cmsMonAn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMonAn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem1,
            this.chỉnhSửaToolStripMenuItem1,
            this.xóaToolStripMenuItem1});
            this.cmsMonAn.Name = "cmsMonAn";
            this.cmsMonAn.Size = new System.Drawing.Size(128, 70);
            // 
            // thêmToolStripMenuItem1
            // 
            this.thêmToolStripMenuItem1.Name = "thêmToolStripMenuItem1";
            this.thêmToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.thêmToolStripMenuItem1.Text = "Thêm";
            this.thêmToolStripMenuItem1.Click += new System.EventHandler(this.thêmToolStripMenuItem1_Click);
            // 
            // chỉnhSửaToolStripMenuItem1
            // 
            this.chỉnhSửaToolStripMenuItem1.Name = "chỉnhSửaToolStripMenuItem1";
            this.chỉnhSửaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.chỉnhSửaToolStripMenuItem1.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem1.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem1_Click);
            // 
            // xóaToolStripMenuItem1
            // 
            this.xóaToolStripMenuItem1.Name = "xóaToolStripMenuItem1";
            this.xóaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xóaToolStripMenuItem1.Text = "Xóa";
            this.xóaToolStripMenuItem1.Click += new System.EventHandler(this.xóaToolStripMenuItem1_Click);
            // 
            // dgvThanhPhanNguyenLieuCuaMonAn
            // 
            this.dgvThanhPhanNguyenLieuCuaMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhPhanNguyenLieuCuaMonAn.Location = new System.Drawing.Point(550, 102);
            this.dgvThanhPhanNguyenLieuCuaMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThanhPhanNguyenLieuCuaMonAn.Name = "dgvThanhPhanNguyenLieuCuaMonAn";
            this.dgvThanhPhanNguyenLieuCuaMonAn.RowTemplate.Height = 24;
            this.dgvThanhPhanNguyenLieuCuaMonAn.Size = new System.Drawing.Size(279, 221);
            this.dgvThanhPhanNguyenLieuCuaMonAn.TabIndex = 10;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(550, 74);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(77, 19);
            this.metroLabel14.TabIndex = 9;
            this.metroLabel14.Text = "Thành phần";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbGludcid_MA);
            this.panel2.Controls.Add(this.metroLabel16);
            this.panel2.Controls.Add(this.lbLipit_MA);
            this.panel2.Controls.Add(this.metroLabel18);
            this.panel2.Controls.Add(this.lbProtid_MA);
            this.panel2.Controls.Add(this.metroLabel20);
            this.panel2.Controls.Add(this.lbKcal_MA);
            this.panel2.Controls.Add(this.metroLabel22);
            this.panel2.Controls.Add(this.metroLabel23);
            this.panel2.Location = new System.Drawing.Point(287, 336);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 179);
            this.panel2.TabIndex = 11;
            // 
            // lbGludcid_MA
            // 
            this.lbGludcid_MA.AutoSize = true;
            this.lbGludcid_MA.Location = new System.Drawing.Point(111, 145);
            this.lbGludcid_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGludcid_MA.Name = "lbGludcid_MA";
            this.lbGludcid_MA.Size = new System.Drawing.Size(0, 0);
            this.lbGludcid_MA.TabIndex = 40;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(8, 145);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(57, 19);
            this.metroLabel16.TabIndex = 39;
            this.metroLabel16.Text = "Tinh bột";
            // 
            // lbLipit_MA
            // 
            this.lbLipit_MA.AutoSize = true;
            this.lbLipit_MA.Location = new System.Drawing.Point(111, 115);
            this.lbLipit_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLipit_MA.Name = "lbLipit_MA";
            this.lbLipit_MA.Size = new System.Drawing.Size(0, 0);
            this.lbLipit_MA.TabIndex = 38;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(8, 115);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(63, 19);
            this.metroLabel18.TabIndex = 37;
            this.metroLabel18.Text = "Chất béo";
            // 
            // lbProtid_MA
            // 
            this.lbProtid_MA.AutoSize = true;
            this.lbProtid_MA.Location = new System.Drawing.Point(111, 84);
            this.lbProtid_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProtid_MA.Name = "lbProtid_MA";
            this.lbProtid_MA.Size = new System.Drawing.Size(0, 0);
            this.lbProtid_MA.TabIndex = 36;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(8, 84);
            this.metroLabel20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(67, 19);
            this.metroLabel20.TabIndex = 35;
            this.metroLabel20.Text = "Chất đạm";
            // 
            // lbKcal_MA
            // 
            this.lbKcal_MA.AutoSize = true;
            this.lbKcal_MA.Location = new System.Drawing.Point(111, 52);
            this.lbKcal_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKcal_MA.Name = "lbKcal_MA";
            this.lbKcal_MA.Size = new System.Drawing.Size(0, 0);
            this.lbKcal_MA.TabIndex = 34;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(8, 52);
            this.metroLabel22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(79, 19);
            this.metroLabel22.TabIndex = 33;
            this.metroLabel22.Text = "Năng lượng";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(8, 15);
            this.metroLabel23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(189, 19);
            this.metroLabel23.TabIndex = 3;
            this.metroLabel23.Text = "Giá trị dinh dưỡng của món ăn";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.Frozen = true;
            this.Ten.HeaderText = "Nguyên Liệu";
            this.Ten.Name = "Ten";
            this.Ten.Width = 200;
            // 
            // UCThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvThanhPhanNguyenLieuCuaMonAn);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbNhomMonAn);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNguyenLieu);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbNhomNguyenLieu);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCThucPham";
            this.Size = new System.Drawing.Size(862, 585);
            this.Load += new System.EventHandler(this.UCThucPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.cmsThucPham.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.cmsMonAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPhanNguyenLieuCuaMonAn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cbNhomNguyenLieu;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbGlucid_TP;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel lbLipit_TP;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lbProtid_TP;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lbKcal_TP;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox cbNhomMonAn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.DataGridView dgvThanhPhanNguyenLieuCuaMonAn;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel lbGludcid_MA;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lbLipit_MA;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel lbProtid_MA;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel lbKcal_MA;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private System.Windows.Forms.ContextMenuStrip cmsThucPham;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMonAn;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    }
}
