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
        private MonTrongThucDonBAL MonTrongThucDon = new MonTrongThucDonBAL();
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
            lbMonSang1.Text = "";
            lbMonSang2.Text = "";
            lbMonTrua1.Text = "";
            lbMonTrua2.Text = "";
            lbMonTrua3.Text = "";
            lbMonTrua4.Text = "";
            lbMonXe1.Text = "";
            lbMonXe2.Text = "";
            lbMonXe3.Text = "";
            lbMonXe4.Text = "";
           
            DataSet dsNgayThucDon = ThucDon.LayTatCaThucDon();
            //for (int i = 0; i < dsNgayThucDon.Tables[0].Rows.Count; i++)
            //{
            //dgvNgayThucHien.DataSource = dsNgayThucDon.Tables[0].Rows[i][1].ToString();
            //}

            cbNgayThucHien.DataSource = dsNgayThucDon.Tables[0];
      
            cbNgayThucHien.ValueMember = dsNgayThucDon.Tables[0].Columns[0].ToString();

            cbNgayThucHien.DisplayMember = dsNgayThucDon.Tables[0].Columns[1].ToString();
 
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
   
        private void cbNgayThucHien_SelectedValueChanged(object sender, EventArgs e)
        {

            string monSang = "";
            string monTrua = "";
            string monXe1 = "";
            string monXe2 = "";
            try
                {
                    int ngay = Convert.ToInt32(cbNgayThucHien.SelectedValue.ToString());
                    DataSet dsMon = MonTrongThucDon.LayMonTrongThucDonTheoID(ngay);
                    lbMonSang1.Text = "";
                    lbMonSang2.Text = "";
                    lbMonTrua1.Text = "";
                    lbMonTrua2.Text = "";
                    lbMonXe1.Text = "";
                    lbMonXe2.Text = "";
                    lbMonXe3.Text = "";
                    lbMonXe4.Text = "";
                    if (dsMon.Tables[0].Rows[0][4].ToString() == "1")
                    {
                        for (int i = 0; i < dsMon.Tables[0].Rows.Count; i++)
                            {
                                monSang = dsMon.Tables[0].Rows[i][1].ToString();
                                if (i == 0)
                                {
                                lbMonSang1.Text = monSang.ToString();
                                }
                                if (i == 1)
                                {
                                lbMonSang2.Text = monSang.ToString();
                                }
                            }   
                    }
                    if (dsMon.Tables[0].Rows[0][4].ToString() == "3")
                    {
                        for (int i = 0; i < dsMon.Tables[0].Rows.Count; i++)
                        {
                            monTrua = dsMon.Tables[0].Rows[i][1].ToString();
                            if (i == 0)
                            {
                                lbMonTrua1.Text = monTrua.ToString();
                            }
                            if (i == 1)
                            {
                                lbMonTrua2.Text = monTrua.ToString();
                            }
                        }
                       
                    }
                    if (dsMon.Tables[0].Rows[0][4].ToString() == "2")
                    {
                        for (int i = 0; i < dsMon.Tables[0].Rows.Count; i++)
                        {
                            monXe1 = dsMon.Tables[0].Rows[i][1].ToString();
                            if (i == 0)
                            {
                                lbMonXe1.Text = monXe1.ToString();
                            }
                            if (i == 1)
                            {
                                lbMonXe2.Text = monXe1.ToString();
                            }
                        }
                        
                    
                    }
                    if (dsMon.Tables[0].Rows[0][4].ToString() == "4")
                    {
                        for (int i = 0; i < dsMon.Tables[0].Rows.Count; i++)
                        {
                            monXe2 = dsMon.Tables[0].Rows[i][1].ToString();
                        if (i == 0)
                        {
                            lbMonXe3.Text = monXe2.ToString();
                        }
                        if(i==1)
                        {
                            lbMonXe4.Text = monXe2.ToString();
                        }
                    }
                }
                lbSoLuong.Text = "Số lượng: " + dsMon.Tables[0].Rows[0][2].ToString();
            }
                catch (Exception)
                {


                }
               


            //lbMonSang1.Text = dsMonSang1.Tables[0].Rows[0][1].ToString();
            //if (cbNgayThucHien.SelectedIndex >= 0)
            //{
            //    monSang1 = cbNgayThucHien.SelectedValue.ToString();
            //}
        }

      
    }
}
