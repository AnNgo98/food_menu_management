using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
namespace QlThucDon
{
    public partial class UCLoadThucDon : UserControl
    {
        private ThucDonBAL ThucDon = new ThucDonBAL();
        public int MaNgayDuocChon = 0;
        public UCLoadThucDon()
        {
            InitializeComponent();
        }
        private static UCLoadThucDon _instance;
        public static UCLoadThucDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCLoadThucDon();
                return _instance;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCLoadThucDon_Load(object sender, EventArgs e)
        {
            
            DataSet dsNgayThucDon = ThucDon.LayTatCaThucDon();
            //for (int i = 0; i < dsNgayThucDon.Tables[0].Rows.Count; i++)
            //{
            //dgvNgayThucHien.DataSource = dsNgayThucDon.Tables[0].Rows[i][1].ToString();
            //}
            cbNgayThucHien.DataSource = dsNgayThucDon.Tables[0];
            cbNgayThucHien.ValueMember = dsNgayThucDon.Tables[0].Columns[0].ToString();
            cbNgayThucHien.DisplayMember = dsNgayThucDon.Tables[0].Columns[1].ToString();
            cbNgayThucHien.SelectedIndex = -1;
        }

        private void dgvNgayThucHien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //int index = dgvNgayThucHien.CurrentCell.RowIndex;

            //MaNgayDuocChon = int.Parse(dgvNgayThucHien.Rows[index].Cells[0].Value.ToString());
            //MaNgayDuocChon = ThucDon.LayNguyenLieuChoChinhSuaThucPham(MaNguyenLieuDuocChon);

            //lbKcal_TP.Text = dgvNguyenLieu.Rows[index].Cells[5].Value.ToString() + " kcal";
            //lbProtid_TP.Text = dgvNguyenLieu.Rows[index].Cells[4].Value.ToString() + " gam";
            //lbLipit_TP.Text = dgvNguyenLieu.Rows[index].Cells[3].Value.ToString() + " gam";
            //lbGlucid_TP.Text = dgvNguyenLieu.Rows[index].Cells[6].Value.ToString() + " gam";
        }
        string monSang1;
        private void cbNgayThucHien_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonSang1 = Convert.ToInt32(cbNgayThucHien.SelectedIndex.ToString());
            DataSet dsMonSang1 = ThucDon.LayMonTrongThucDonTheoID(MonSang1 + 1);
            lbMonSang1.Text = dsMonSang1.Tables[0].ToString();
            if (cbNgayThucHien.SelectedIndex >= 0)
            {
                monSang1 = cbNgayThucHien.SelectedValue.ToString();
            }
        }
    }
}
