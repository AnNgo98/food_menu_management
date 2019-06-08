namespace QlThucDon
{
    partial class crudMonAn
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
            this.btnHuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvNguyenLieuCuaMonAn = new System.Windows.Forms.DataGridView();
            this.cbNguyenLieu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtKhoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuCuaMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.ButtonText = "Hủy";
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
            this.btnHuy.Location = new System.Drawing.Point(301, 290);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnHuy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.btnHuy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuy.selected = false;
            this.btnHuy.Size = new System.Drawing.Size(80, 37);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
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
            this.btnLuu.ButtonText = "Lưu";
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
            this.btnLuu.Location = new System.Drawing.Point(205, 290);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(80, 37);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(120, 73);
            this.txtTenMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(261, 20);
            this.txtTenMonAn.TabIndex = 18;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 75);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Tên món ăn";
            // 
            // dgvNguyenLieuCuaMonAn
            // 
            this.dgvNguyenLieuCuaMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieuCuaMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbNguyenLieu,
            this.txtKhoiLuong});
            this.dgvNguyenLieuCuaMonAn.Location = new System.Drawing.Point(39, 105);
            this.dgvNguyenLieuCuaMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNguyenLieuCuaMonAn.Name = "dgvNguyenLieuCuaMonAn";
            this.dgvNguyenLieuCuaMonAn.RowTemplate.Height = 24;
            this.dgvNguyenLieuCuaMonAn.Size = new System.Drawing.Size(342, 171);
            this.dgvNguyenLieuCuaMonAn.TabIndex = 29;
            this.dgvNguyenLieuCuaMonAn.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenLieuCuaMonAn_CellValueChanged);
            this.dgvNguyenLieuCuaMonAn.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNguyenLieuCuaMonAn_DataBindingComplete);
            this.dgvNguyenLieuCuaMonAn.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNguyenLieuCuaMonAn_DataError);
            this.dgvNguyenLieuCuaMonAn.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvNguyenLieuCuaMonAn_DefaultValuesNeeded);
            this.dgvNguyenLieuCuaMonAn.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvNguyenLieuCuaMonAn_EditingControlShowing);
            // 
            // cbNguyenLieu
            // 
            this.cbNguyenLieu.DataPropertyName = "IDNguyenLieu";
            this.cbNguyenLieu.Frozen = true;
            this.cbNguyenLieu.HeaderText = "Nguyên liệu";
            this.cbNguyenLieu.Name = "cbNguyenLieu";
            this.cbNguyenLieu.Width = 170;
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.DataPropertyName = "KhoiLuong";
            this.txtKhoiLuong.Frozen = true;
            this.txtKhoiLuong.HeaderText = "Khối lượng (gram)";
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.Width = 130;
            // 
            // crudMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 381);
            this.Controls.Add(this.dgvNguyenLieuCuaMonAn);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "crudMonAn";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Load += new System.EventHandler(this.crudMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieuCuaMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnHuy;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvNguyenLieuCuaMonAn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKhoiLuong;
    }
}