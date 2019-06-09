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
        private MonAn monAn = new MonAn();

        public int MaNguyenLieuDuocChon = 0;
        public int MaMonAnDuocChon = 0;
        public DataSet NguyenLieuDuocChon;
        public DataSet MonAnDuocChon;
        //ChatDinhDuong Glu;
        //ChatDinhDuong Li;
        //ChatDinhDuong Kc;
        //ChatDinhDuong Pr;
        //ChatDinhDuong GluMA;
        //ChatDinhDuong LiMA;
        //ChatDinhDuong KcMA;
        //ChatDinhDuong PrMA;
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
            //Glu = new ChatDinhDuong(lbGlucid_TP);
            //Li = new ChatDinhDuong(lbLipit_TP);
            //Kc = new ChatDinhDuong(lbKcal_TP);
            //Pr = new ChatDinhDuong(lbProtid_TP);
            //monAn.AddChatDinhDuong(Glu);
            //monAn.AddChatDinhDuong(Li);
            //monAn.AddChatDinhDuong(Kc);
            //monAn.AddChatDinhDuong(Pr);      

            //GluMA = new ChatDinhDuong(lbGludcid_MA);
            //LiMA = new ChatDinhDuong(lbLipit_MA);
            //KcMA = new ChatDinhDuong(lbKcal_MA);
            //PrMA = new ChatDinhDuong(lbProtid_MA);
            //monAn.AddChatDinhDuong(GluMA);
            //monAn.AddChatDinhDuong(LiMA);
            //monAn.AddChatDinhDuong(KcMA);
            //monAn.AddChatDinhDuong(PrMA);
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

            //lbKcal_TP.Text = dgvNguyenLieu.Rows[index].Cells[5].Value.ToString() + " kcal";
            //lbProtid_TP.Text = dgvNguyenLieu.Rows[index].Cells[4].Value.ToString() + " gam";
            //lbLipit_TP.Text = dgvNguyenLieu.Rows[index].Cells[3].Value.ToString() + " gam";
            //lbGlucid_TP.Text = dgvNguyenLieu.Rows[index].Cells[6].Value.ToString() + " gam";
            //Kc.Value = float.Parse(dgvNguyenLieu.Rows[index].Cells[5].Value.ToString());
            //Pr.Value = float.Parse(dgvNguyenLieu.Rows[index].Cells[4].Value.ToString());
            //Li.Value = float.Parse(dgvNguyenLieu.Rows[index].Cells[3].Value.ToString());
            //Glu.Value = float.Parse(dgvNguyenLieu.Rows[index].Cells[6].Value.ToString());
            monAn.update();
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMonAn.CurrentCell.RowIndex;

            MaMonAnDuocChon = Convert.ToInt32(dgvMonAn.Rows[index].Cells[0].Value.ToString());
            MonAnDuocChon = MonAn.LayDinhDuongCuaMonAn1(MaMonAnDuocChon);

            dgvThanhPhanNguyenLieuCuaMonAn.DataSource = MonAnDuocChon.Tables[0];

            double totalKcal = 0, totalProtid = 0, totalLipit = 0, totalGludcid = 0;

            foreach (DataRow dr in MonAnDuocChon.Tables[0].Rows)
            {
                totalKcal += Convert.ToDouble(dr["Kcal"].ToString());
                totalProtid += Convert.ToDouble(dr["Protid"].ToString());
                totalLipit += Convert.ToDouble(dr["Lipid"].ToString());
                totalGludcid += Convert.ToDouble(dr["Glucid"].ToString());
            }
            //KcMA.Value = float.Parse(totalKcal.ToString());
            //PrMA.Value = float.Parse(totalProtid.ToString());
            //LiMA.Value = float.Parse(totalLipit.ToString());
            //GluMA.Value = float.Parse(totalGludcid.ToString());
            monAn.update();
            
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
            DataSet dsNhomNguyenLieu = NhomNguyenLieu.LayTatCaThuocTinhNhomNguyenLieu();
            DataTable dtNhomNguyenLieu = dsNhomNguyenLieu.Tables[0];
            DataRow topItemNhomNguyenLieu = dtNhomNguyenLieu.NewRow();
            topItemNhomNguyenLieu[0] = 0;
            topItemNhomNguyenLieu[1] = "Tất cả";
            dtNhomNguyenLieu.Rows.InsertAt(topItemNhomNguyenLieu, 0);
            cbNhomNguyenLieu.DataSource = dtNhomNguyenLieu;
            cbNhomNguyenLieu.DisplayMember = dsNhomNguyenLieu.Tables[0].Columns[1].ToString();
            cbNhomNguyenLieu.ValueMember = dsNhomNguyenLieu.Tables[0].Columns[0].ToString();

            DataSet dsNhomMonAn = NhomMonAn.LayTatCaNhomMonAn();
            DataTable dtNhomMonAn = dsNhomMonAn.Tables[0];
            DataRow topItemNhomMonAn = dtNhomMonAn.NewRow();
            topItemNhomMonAn[0] = 0;
            topItemNhomMonAn[1] = "Tất cả";

            dtNhomMonAn.Rows.InsertAt(topItemNhomMonAn, 0);
            cbNhomMonAn.DataSource = dtNhomMonAn;
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
    }
}