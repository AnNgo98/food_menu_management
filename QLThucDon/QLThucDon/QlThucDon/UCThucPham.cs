using BusinessLogicLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QlThucDon
{
    public partial class UCThucPham : UserControl
    {
        private NhomNguyenLieuBAL NhomNguyenLieu = new NhomNguyenLieuBAL();
        private NhomMonAnBAL NhomMonAn = new NhomMonAnBAL();
        private NguyenLieuBAL NguyenLieu = new NguyenLieuBAL();
        private MonAnBAL MonAn = new MonAnBAL();

        public int MaNguyenLieuDuocChon = 0;
        public int MaMonAnDuocChon = 0;
        public DataSet NguyenLieuDuocChon;
        public DataSet MonAnDuocChon;

        public UCThucPham()
        {
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
        }

        private static UCThucPham _instance;

        public static UCThucPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCThucPham();
                return _instance;
            }
        }

        private void UCThucPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbNhomNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbNhomNguyenLieu_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet dsNguyenLieu;
            string nhomNguyenLieu = cbNhomNguyenLieu.SelectedValue.ToString();
            if (nhomNguyenLieu == null || nhomNguyenLieu == "" || nhomNguyenLieu == "0" || nhomNguyenLieu == "System.Data.DataRowView")
            {
                dsNguyenLieu = NguyenLieu.LayTatCaNguyenLieu();
                dgvNguyenLieu.DataSource = dsNguyenLieu.Tables[0];
            }
            else
            {
                int id = (Convert.ToInt32(cbNhomNguyenLieu.SelectedValue.ToString()));
                dsNguyenLieu = NguyenLieu.LayNguyenLieuTheoID(id);
                dgvNguyenLieu.DataSource = dsNguyenLieu.Tables[0];
            }
        }

        private void cbNhomMonAn_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet dsMonAn;
            string nhomMonAn = cbNhomMonAn.SelectedValue.ToString();
            if (nhomMonAn == "" || nhomMonAn == "0" || nhomMonAn == "System.Data.DataRowView")
            {
                dsMonAn = MonAn.LayTatCaMonAn();
                dgvMonAn.DataSource = dsMonAn.Tables[0];
            }
            else
            {
                int id = (Convert.ToInt32(cbNhomMonAn.SelectedValue.ToString()));
                dsMonAn = MonAn.LayMonAnTheoIDNhomMonAn(id);
                dgvMonAn.DataSource = dsMonAn.Tables[0];
            }
        }

        private void cbNhomMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNguyenLieu.CurrentCell.RowIndex;

            MaNguyenLieuDuocChon = int.Parse(dgvNguyenLieu.Rows[index].Cells[0].Value.ToString());
            NguyenLieuDuocChon = NguyenLieu.LayNguyenLieuChoChinhSuaThucPham(MaNguyenLieuDuocChon);

            lbKcal_TP.Text = dgvNguyenLieu.Rows[index].Cells[5].Value.ToString() + " kcal";
            lbProtid_TP.Text = dgvNguyenLieu.Rows[index].Cells[4].Value.ToString() + " gam";
            lbLipit_TP.Text = dgvNguyenLieu.Rows[index].Cells[3].Value.ToString() + " gam";
            lbGlucid_TP.Text = dgvNguyenLieu.Rows[index].Cells[6].Value.ToString() + " gam";
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMonAn.CurrentCell.RowIndex;

            MaMonAnDuocChon = Convert.ToInt32(dgvMonAn.Rows[index].Cells[0].Value.ToString());
            MonAnDuocChon = MonAn.LayDinhDuongCuaMonAn1(MaMonAnDuocChon);
            //DataSet dsDinhDuong = MonAn.LayDinhDuongCuaMonAn1(MaMonAnDuocChon);

            dgvThanhPhanNguyenLieuCuaMonAn.DataSource = MonAnDuocChon.Tables[0];

            double totalKcal = 0, totalProtid = 0, totalLipit = 0, totalGludcid = 0;

            foreach (DataRow dr in MonAnDuocChon.Tables[0].Rows)
            {
                totalKcal += Convert.ToDouble(dr["Kcal"].ToString());
                totalProtid += Convert.ToDouble(dr["Protid"].ToString());
                totalLipit += Convert.ToDouble(dr["Lipid"].ToString());
                totalGludcid += Convert.ToDouble(dr["Glucid"].ToString());
            }

            lbKcal_MA.Text = totalKcal.ToString() + " kcal";
            lbProtid_MA.Text = totalProtid.ToString() + " gam";
            lbLipit_MA.Text = totalLipit.ToString() + " gam";
            lbGludcid_MA.Text = totalGludcid.ToString() + " gam";
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crudThucPham crudThucPham = new crudThucPham();
            crudThucPham.ShowDialog();

            LoadData();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crudThucPham crudThucPham = new crudThucPham(NguyenLieuDuocChon, 1);
            crudThucPham.ShowDialog();

            LoadData();
        }

        private void LoadData()
        {
            //DataSet dsNhomNguyenLieu = NhomNguyenLieu.LayTatCaThuocTinhNhomNguyenLieu();
            DataSet dsNhomNguyenLieu = NhomNguyenLieu.LayTatCaThuocTinhNhomNguyenLieu();
            DataTable dtNhomNguyenLieu = dsNhomNguyenLieu.Tables[0];
            DataRow topItemNhomNguyenLieu = dtNhomNguyenLieu.NewRow();
            topItemNhomNguyenLieu[0] = 0;
            topItemNhomNguyenLieu[1] = "Tất cả";
            dtNhomNguyenLieu.Rows.InsertAt(topItemNhomNguyenLieu, 0);
            //cbNhomNguyenLieu.ValueMember = "IDNhomNguyenLieu";
            //cbNhomNguyenLieu.DisplayMember = "TenNhom";
            cbNhomNguyenLieu.DataSource = dtNhomNguyenLieu;
            //cbNhomNguyenLieu.DataSource = dsNhomNguyenLieu.Tables[0];
            cbNhomNguyenLieu.DisplayMember = dsNhomNguyenLieu.Tables[0].Columns[1].ToString();
            cbNhomNguyenLieu.ValueMember = dsNhomNguyenLieu.Tables[0].Columns[0].ToString();

            DataSet dsNhomMonAn = NhomMonAn.LayTatCaNhomMonAn();
            DataTable dtNhomMonAn = dsNhomMonAn.Tables[0];
            DataRow topItemNhomMonAn = dtNhomMonAn.NewRow();
            topItemNhomMonAn[0] = 0;
            topItemNhomMonAn[1] = "Tất cả";

            dtNhomMonAn.Rows.InsertAt(topItemNhomMonAn, 0);
            cbNhomMonAn.DataSource = dtNhomMonAn;
            //cbNhomMonAn.DataSource = dsNhomMonAn.Tables[0];
            cbNhomMonAn.DisplayMember = dsNhomMonAn.Tables[0].Columns[1].ToString();
            cbNhomMonAn.ValueMember = dsNhomMonAn.Tables[0].Columns[0].ToString();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "";
                DialogResult result = MessageBox.Show("Có chắc chắn muốn xóa?", "STATUS", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    status = NguyenLieu.XoaNguyenLieu(MaNguyenLieuDuocChon);
                    if (status != "Successful")
                        throw new Exception(status);
                    MessageBox.Show("Xóa thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Mã không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crudMonAn crudMonAn = new crudMonAn();
            crudMonAn.ShowDialog();

            LoadData();
        }

        private void chỉnhSửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crudMonAn crudMonAn = new crudMonAn(MonAnDuocChon, 1);
            crudMonAn.ShowDialog();

            LoadData();
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dgvNguyenLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}