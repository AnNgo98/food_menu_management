using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace QlThucDon
{
    public partial class FormMain : MetroForm
    {
        //int quyen;
        public FormMain(User user)
        {
            InitializeComponent();
            AdapterUserToQuanTri adapter = new AdapterUserToQuanTri(user);
            lblTen.Text = Convert.ToString(adapter.getQuyen());
           // lblTen.Text = user.getTen();
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
            //lblTen.Text=
            
            
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