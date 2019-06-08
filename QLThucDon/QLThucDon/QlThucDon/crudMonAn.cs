using BusinessLogicLayer;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QlThucDon
{
    public partial class crudMonAn : MetroForm
    {
        //private ComboBox comboBox;

        private NhomNguyenLieuBAL NhomNguyenLieu = new NhomNguyenLieuBAL();
        private NguyenLieuBAL NguyenLieu = new NguyenLieuBAL();
        private MonAnBAL MonAn = new MonAnBAL();

        private DataSet dsNguyenLieu;
        private DataTable dtNguyenLieu;



        public int update = 0;
        public int MaMonAnDuocChon = 0;
        DataSet MonAnDuocChonSelected;

        //DataSet dsNguyenLieu;
        //DataTable dtNguyenLieu;

        public crudMonAn()
        {
            InitializeComponent();

            dsNguyenLieu = NguyenLieu.LayTatCaNguyenLieu();
            dtNguyenLieu = dsNguyenLieu.Tables[0];
        }

        public crudMonAn(DataSet MonAnDuocChon, int flag)
        {
            InitializeComponent();

            update = flag;
            MonAnDuocChonSelected = MonAnDuocChon;
            dsNguyenLieu = NguyenLieu.LayTatCaNguyenLieu();
            dtNguyenLieu = dsNguyenLieu.Tables[0];
            MaMonAnDuocChon = int.Parse(MonAnDuocChon.Tables[0].Rows[0]["IDMonAn"].ToString());
            txtTenMonAn.Text = MonAnDuocChon.Tables[0].Rows[0]["TenMonAn"].ToString();

            cbNguyenLieu.DataSource = dtNguyenLieu;
            cbNguyenLieu.DisplayMember = dsNguyenLieu.Tables[0].Columns[1].ToString();
            cbNguyenLieu.ValueMember = dsNguyenLieu.Tables[0].Columns[0].ToString();
            //foreach (DataRow dr in MonAnDuocChonSelected.Tables[0].Rows)
            //{
            //    //dgvNguyenLieuCuaMonAn.Rows[i].Cells[0].Value.ToString();
            //    this.dgvNguyenLieuCuaMonAn.Rows.Add(dr["Ten"].ToString(), dr["KhoiLuong"].ToString());
            //}
        }

        private void LoadComboboxNguyenLieu()
        {
            cbNguyenLieu.DataSource = dtNguyenLieu;
            cbNguyenLieu.DisplayMember = dsNguyenLieu.Tables[0].Columns[1].ToString();
            cbNguyenLieu.ValueMember = dsNguyenLieu.Tables[0].Columns[0].ToString();                      
        }

        private void crudMonAn_Load(object sender, EventArgs e)
        {
            LoadComboboxNguyenLieu();
        }

        private void dgvNguyenLieuCuaMonAn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ////
            //comboBox = e.Control as ComboBox;
            //MessageBox.Show(comboBox.ValueMember);
            //if(comboBox != null && comboBox.ValueMember == "IDNhomNguyenLieu")
            //{
            //    comboBox.SelectedValueChanged -= new EventHandler(comboBox_SelectedValueChanged);

            //    //
            //    comboBox.SelectedValueChanged += comboBox_SelectedValueChanged;
            //}
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox comboBoxNguyenLieu = (sender as ComboBox);
            //MessageBox.Show(comboBoxNguyenLieu.ValueMember);

            //string selected = (sender as ComboBox).SelectedValue.ToString();
            //int maNhomNguyenLieu = int.Parse(selected);

            //if (selected == "" || selected == "0" || selected == "System.Data.DataRowView" || maNhomNguyenLieu == 0)
            //{
            //    dsNguyenLieu = NguyenLieu.LayTatCaNguyenLieu();
            //    cbNguyenLieu.DataSource = dsNguyenLieu.Tables[0];

            //    cbNguyenLieu.DisplayMember = dsNguyenLieu.Tables[0].Columns[1].ToString();
            //    cbNguyenLieu.ValueMember = dsNguyenLieu.Tables[0].Columns[0].ToString();

            //    dgvNguyenLieuCuaMonAn.Rows.Add(null, dsNguyenLieu.Tables[0].Columns[1].ToString());
            //}
            //else
            //{
            //    dsNguyenLieu = NguyenLieu.LayNguyenLieuTheoID(maNhomNguyenLieu);
            //    cbNguyenLieu.DataSource = dsNguyenLieu.Tables[0];
            //    cbNguyenLieu.DisplayMember = dsNguyenLieu.Tables[0].Columns[1].ToString();
            //    cbNguyenLieu.ValueMember = dsNguyenLieu.Tables[0].Columns[0].ToString();
            //}

            //LoadComboboxNhomNguyenLieu();
        }

        private void dgvNguyenLieuCuaMonAn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string TenMonAn = txtTenMonAn.Text;
                if (TenMonAn == "")
                {
                    MessageBox.Show("Vui lòng nhập tên món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(dgvNguyenLieuCuaMonAn.Rows.Count == 1)
                {
                    MessageBox.Show("Bạn chưa nhập thành phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int rows = 0; rows < dgvNguyenLieuCuaMonAn.Rows.Count - 1; rows++)
                {
                    int idNguyenLieuCuaMonAn = int.Parse(dgvNguyenLieuCuaMonAn.Rows[rows].Cells[0].Value.ToString());
                    float khoiLuong = float.Parse(dgvNguyenLieuCuaMonAn.Rows[rows].Cells[1].Value.ToString());
                    string statusMonAn = "";
                    statusMonAn = MonAn.ThemMonAn(TenMonAn, idNguyenLieuCuaMonAn, khoiLuong);
                    if (statusMonAn != "Successful")
                        throw new Exception(statusMonAn);
                }

                MessageBox.Show("Thêm thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        private void dgvNguyenLieuCuaMonAn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvNguyenLieuCuaMonAn.Rows)
            {
                if (row.Cells[0] is DataGridViewComboBoxCell && row.Index == 1)
                    (row.Cells[0] as DataGridViewComboBoxCell).Items.Add("A");
                else
                    (row.Cells[0] as DataGridViewComboBoxCell).Items.Add("B");
            }
        }

        private void dgvNguyenLieuCuaMonAn_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dgvNguyenLieuCuaMonAn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dgvNguyenLieuCuaMonAn.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dgvNguyenLieuCuaMonAn.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dgvNguyenLieuCuaMonAn_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //DataGridViewRow RowSample = new DataGridViewRow();
            //DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
            //CellSample.DataSource = dsNguyenLieu.Tables[0].ColumnChanged; // list of the string items that I want to insert in ComboBox

            //e.Row.Cells[0] = 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}