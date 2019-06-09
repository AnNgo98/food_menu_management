namespace QlThucDon
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThucPham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThucDon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelInfor = new System.Windows.Forms.Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThucPham);
            this.panel1.Controls.Add(this.btnThucDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(15, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 517);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.ButtonText = "Đóng";
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
            this.btnHuy.Location = new System.Drawing.Point(3, 460);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(67)))));
            this.btnHuy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(78)))), ((int)(((byte)(149)))));
            this.btnHuy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuy.selected = false;
            this.btnHuy.Size = new System.Drawing.Size(139, 37);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Textcolor = System.Drawing.Color.White;
            this.btnHuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThucPham
            // 
            this.btnThucPham.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnThucPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnThucPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThucPham.BorderRadius = 0;
            this.btnThucPham.ButtonText = "Thực Phẩm";
            this.btnThucPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucPham.DisabledColor = System.Drawing.Color.Gray;
            this.btnThucPham.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThucPham.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThucPham.Iconimage")));
            this.btnThucPham.Iconimage_right = null;
            this.btnThucPham.Iconimage_right_Selected = null;
            this.btnThucPham.Iconimage_Selected = null;
            this.btnThucPham.IconMarginLeft = 0;
            this.btnThucPham.IconMarginRight = 0;
            this.btnThucPham.IconRightVisible = true;
            this.btnThucPham.IconRightZoom = 0D;
            this.btnThucPham.IconVisible = true;
            this.btnThucPham.IconZoom = 60D;
            this.btnThucPham.IsTab = false;
            this.btnThucPham.Location = new System.Drawing.Point(0, 228);
            this.btnThucPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnThucPham.Name = "btnThucPham";
            this.btnThucPham.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnThucPham.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnThucPham.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThucPham.selected = false;
            this.btnThucPham.Size = new System.Drawing.Size(142, 49);
            this.btnThucPham.TabIndex = 3;
            this.btnThucPham.Text = "Thực Phẩm";
            this.btnThucPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucPham.Textcolor = System.Drawing.Color.Black;
            this.btnThucPham.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucPham.Click += new System.EventHandler(this.btnThucPham_Click);
            // 
            // btnThucDon
            // 
            this.btnThucDon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnThucDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnThucDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThucDon.BorderRadius = 0;
            this.btnThucDon.ButtonText = "Thực đơn";
            this.btnThucDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThucDon.DisabledColor = System.Drawing.Color.Gray;
            this.btnThucDon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThucDon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnThucDon.Iconimage")));
            this.btnThucDon.Iconimage_right = null;
            this.btnThucDon.Iconimage_right_Selected = null;
            this.btnThucDon.Iconimage_Selected = null;
            this.btnThucDon.IconMarginLeft = 0;
            this.btnThucDon.IconMarginRight = 0;
            this.btnThucDon.IconRightVisible = true;
            this.btnThucDon.IconRightZoom = 0D;
            this.btnThucDon.IconVisible = true;
            this.btnThucDon.IconZoom = 60D;
            this.btnThucDon.IsTab = false;
            this.btnThucDon.Location = new System.Drawing.Point(0, 183);
            this.btnThucDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnThucDon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnThucDon.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThucDon.selected = false;
            this.btnThucDon.Size = new System.Drawing.Size(142, 49);
            this.btnThucDon.TabIndex = 2;
            this.btnThucDon.Text = "Thực đơn";
            this.btnThucDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucDon.Textcolor = System.Drawing.Color.Black;
            this.btnThucDon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // panelInfor
            // 
            this.panelInfor.Location = new System.Drawing.Point(158, 49);
            this.panelInfor.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Size = new System.Drawing.Size(842, 528);
            this.panelInfor.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(787, 19);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 13);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "lblTen";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 593);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.panelInfor);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnThucPham;
        private Bunifu.Framework.UI.BunifuFlatButton btnThucDon;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuy;
        private System.Windows.Forms.Label lblTen;
    }
}