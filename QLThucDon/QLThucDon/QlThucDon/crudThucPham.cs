using BusinessLogicLayer;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QlThucDon
{
    public partial class crudThucPham : MetroForm
    {
        public int update = 0;

        public int MaNguyenLieu = 0;

        private NguyenLieuBAL NguyenLieu = new NguyenLieuBAL();
        private NhomNguyenLieuBAL NhomNguyenLieu = new NhomNguyenLieuBAL();
        DataSet SelectedNguyenLieu;

        public crudThucPham()
        {
            InitializeComponent();
            update = 0;
        }

        public crudThucPham(DataSet NguyenLieuDuocChon, int flag)
        {
            InitializeComponent();
            update = flag;
            MaNguyenLieu = int.Parse(NguyenLieuDuocChon.Tables[0].Rows[0]["IDNguyenLieu"].ToString());
            txtTenNguyenLieu.Text = NguyenLieuDuocChon.Tables[0].Rows[0]["Ten"].ToString();
            txtProtid.Text = NguyenLieuDuocChon.Tables[0].Rows[0]["Protid"].ToString();
            txtLipit.Text = NguyenLieuDuocChon.Tables[0].Rows[0]["Lipid"].ToString();
            txtGlucid.Text = NguyenLieuDuocChon.Tables[0].Rows[0]["Glucid"].ToString();
            txtKcal.Text = NguyenLieuDuocChon.Tables[0].Rows[0]["Kcal"].ToString();
            SelectedNguyenLieu = NguyenLieuDuocChon;
        }

        private void LoadComboboxNhomNguyenLieu()
        {
            cbNhomNguyenLieu.DataSource = NhomNguyenLieu.LayTatCaThuocTinhNhomNguyenLieu().Tables[0].DefaultView;
            cbNhomNguyenLieu.DisplayMember = "TenNhom";
            cbNhomNguyenLieu.ValueMember = "IDNhomNguyenLieu";
        }

        public crudThucPham(string cot1, string cot2, string cot3, string cot4, string cot5, string cot6)
        {
            InitializeComponent();
            txtTenNguyenLieu.Text = cot1;
            //
            txtProtid.Text = cot2;
            txtLipit.Text = cot3;
            txtGlucid.Text = cot4;
            txtKcal.Text = cot5;
        }

        private void crudThucPham_Load(object sender, EventArgs e)
        {
            LoadComboboxNhomNguyenLieu();
            if(update == 1)
                cbNhomNguyenLieu.Text = SelectedNguyenLieu.Tables[0].Rows[0]["TenNhom"].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (update == 0)
                {
                    string TenNguyenLieu = txtTenNguyenLieu.Text;
                    float Kcal = float.Parse(txtKcal.Text);
                    float Protid = float.Parse(txtProtid.Text);
                    int NhomNguyenLieu = int.Parse(cbNhomNguyenLieu.SelectedValue.ToString());
                    float Lipit = float.Parse(txtLipit.Text);
                    float Glucid = float.Parse(txtGlucid.Text);
                    string status = "";
                    status = NguyenLieu.ThemMoiNguyenLieu(TenNguyenLieu, Kcal, Protid, Lipit, Glucid, NhomNguyenLieu);
                    if (status != "Successful")
                        throw new Exception(status);
                    MessageBox.Show("Thêm thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    //this.Close();
                }
                if (update == 1)
                {
                    string TenNguyenLieu = txtTenNguyenLieu.Text;
                    float Kcal = (float)Math.Ceiling(float.Parse(txtKcal.Text));
                    float Protid = (float)Math.Ceiling(float.Parse(txtProtid.Text));
                    float Lipit = (float)Math.Ceiling(float.Parse(txtLipit.Text));
                    float Glucid = (float)Math.Ceiling(float.Parse(txtGlucid.Text));
                    int NhomNguyenLieu = int.Parse(cbNhomNguyenLieu.SelectedValue.ToString());
                    string status = "";
                    status = NguyenLieu.ChinhSuaNguyenLieu(MaNguyenLieu, TenNguyenLieu, Lipit, Protid, Kcal, Glucid, NhomNguyenLieu);
                    if (status != "Successful")
                        throw new Exception(status);
                    MessageBox.Show("Sửa thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    //this.Close();
                }
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Mã không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            txtTenNguyenLieu.Text = "";
            txtKcal.Text = "";
            txtProtid.Text = "";
            txtLipit.Text = "";
            txtGlucid.Text = "";
            this.Hide();
        }

        private void LoadData()
        {
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}