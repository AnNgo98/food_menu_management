using BusinessLogicLayer;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QlThucDon
{
    public partial class FormLogin : MetroForm
    {
        User userCurrent = new User();
        private TaiKhoanBAL TaiKhoan = new TaiKhoanBAL();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
        }

        private string AccountValidation(string username, string password)
        {
            string flag = "";
            DataSet ds = TaiKhoan.LayTatCaTaiKhoan();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string user = ds.Tables[0].Rows[i][0].ToString().Split(' ')[0];
                string pass = ds.Tables[0].Rows[i][1].ToString().Split(' ')[0];
                if (user.Equals(username) && pass.Equals(password))
                {
                    flag = ds.Tables[0].Rows[i][2].ToString();
                    break;
                }
            }
            return flag;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '•';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KiemTra(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
                FormMain frm = new FormMain(userCurrent);
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
        }

        private bool KiemTra(string user, string pass)
        {
           
            bool check = false;
            DataSet ds = TaiKhoan.LayTatCaTaiKhoan();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int id = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString().Split(' ')[0]);
                string taikhoan = ds.Tables[0].Rows[i][1].ToString().Split(' ')[0];
                string matkhau = ds.Tables[0].Rows[i][2].ToString().Split(' ')[0];
                if (taikhoan.Equals(user) && matkhau.Equals(pass))
                {
                    userCurrent.setID(id);
                    userCurrent.setTen(taikhoan);
                    check = true;
                }
            }
            return check;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}