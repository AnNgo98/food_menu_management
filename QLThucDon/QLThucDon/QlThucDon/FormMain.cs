using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace QlThucDon
{
    public partial class FormMain : MetroForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            panelInfor.Controls.Add(UCThucDon.Instance);
            UCThucDon.Instance.Dock = DockStyle.Fill;
            UCThucDon.Instance.BringToFront();
        }

        private void btnThucPham_Click(object sender, EventArgs e)
        {
            panelInfor.Controls.Add(UCThucPham.Instance);
            UCThucPham.Instance.Dock = DockStyle.Fill;
            UCThucPham.Instance.BringToFront();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelInfor.Controls.Add(UCThucDon.Instance);
            UCThucDon.Instance.Dock = DockStyle.Fill;
            UCThucDon.Instance.BringToFront();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmLogin frm = new frmLogin();
            //frm.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}