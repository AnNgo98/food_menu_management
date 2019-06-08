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
using MetroFramework.Forms;

namespace QlThucDon
{
    public partial class UCThucDon : UserControl
    {
        private MonAnBAL MonAn = new MonAnBAL();
        private NhomMonAnBAL NhomMonAn = new NhomMonAnBAL();
        private NguyenLieuBAL NguyenLieu = new NguyenLieuBAL();
        private ThucDonBAL ThucDon = new ThucDonBAL();
        private BuaAnBAL BuaAn = new BuaAnBAL();

        
        string monSang1;
        string monSang2;

        string monXe11;
        string monXe12;

        string monTrua1;
        string monTrua2;
        string monTrua3;
        string monTrua4;

        string monXe21;
        string monXe22;
        public UCThucDon()
        {
            InitializeComponent();
        }

        private static UCThucDon _instance;
        public static UCThucDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCThucDon();
                return _instance;
            }
        }

        private void UCThucDon_Load(object sender, EventArgs e)
        {
            DataSet dsBuaAn = BuaAn.LayTatCaBuaAn();
            lbSang.Text=dsBuaAn.Tables[0].Rows[0][1].ToString();
            lbXeSang.Text = dsBuaAn.Tables[0].Rows[1][1].ToString();
            lbTrua.Text = dsBuaAn.Tables[0].Rows[2][1].ToString();
            lbXeChieu.Text = dsBuaAn.Tables[0].Rows[3][1].ToString();
        }

        //Hiển thị món
        private void cbSang1_SelectedValueChanged(object sender, EventArgs e)
        {

            int MonSang1 = Convert.ToInt32(cbSang1.SelectedIndex.ToString());
            DataSet dsMonSang = MonAn.LayMonAnTheoID(MonSang1 + 1);
            cbMonSang1.DataSource = dsMonSang.Tables[0];
            cbMonSang1.ValueMember = dsMonSang.Tables[0].Columns[0].ToString();
            cbMonSang1.DisplayMember = dsMonSang.Tables[0].Columns[1].ToString();
            if (cbSang1.SelectedIndex >= 0)
            {
                monSang1 = cbSang1.SelectedValue.ToString();
            }

        }

        private void cbSang2_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonSang2 = Convert.ToInt32(cbSang2.SelectedIndex.ToString());
            DataSet dsMonSang1 = MonAn.LayMonAnTheoID(MonSang2 + 1);
            cbMonSang2.DataSource = dsMonSang1.Tables[0];
            cbMonSang2.ValueMember = dsMonSang1.Tables[0].Columns[0].ToString();
            cbMonSang2.DisplayMember = dsMonSang1.Tables[0].Columns[1].ToString();
            if (cbSang2.SelectedIndex >= 0)
            {
                monSang2 = cbMonSang2.SelectedValue.ToString();
            }
        }

        private void cbXe11_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonXe11 = Convert.ToInt32(cbXe11.SelectedIndex.ToString());
            DataSet dsMonXe11 = MonAn.LayMonAnTheoID(MonXe11 + 1);
            cbMonXe11.DataSource = dsMonXe11.Tables[0];
            cbMonXe11.ValueMember = dsMonXe11.Tables[0].Columns[0].ToString();
            cbMonXe11.DisplayMember = dsMonXe11.Tables[0].Columns[1].ToString();
            if (cbMonXe11.SelectedIndex >= 0)
            {
                monXe11 = cbMonXe11.SelectedValue.ToString();
            }
        }

        private void cbXe12_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonXe12 = Convert.ToInt32(cbXe12.SelectedIndex.ToString());
            DataSet dsMonXe12 = MonAn.LayMonAnTheoID(MonXe12 + 1);
            cbMonXe12.DataSource = dsMonXe12.Tables[0];
            cbMonXe12.ValueMember = dsMonXe12.Tables[0].Columns[0].ToString();
            cbMonXe12.DisplayMember = dsMonXe12.Tables[0].Columns[1].ToString();
            if (cbMonXe12.SelectedIndex >= 0)
            {
                monXe12 = cbMonXe12.SelectedValue.ToString();
            }
        }

        private void cbTrua1_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonTrua1 = Convert.ToInt32(cbTrua1.SelectedIndex.ToString());
            DataSet dsMonTrua1 = MonAn.LayMonAnTheoID(MonTrua1 + 1);
            cbMonTrua1.DataSource = dsMonTrua1.Tables[0];
            cbMonTrua1.ValueMember = dsMonTrua1.Tables[0].Columns[0].ToString();
            cbMonTrua1.DisplayMember = dsMonTrua1.Tables[0].Columns[1].ToString();
            if (cbMonTrua1.SelectedIndex >= 0)
            {
                monTrua1 = cbMonTrua1.SelectedValue.ToString();
            }
        }

        private void cbTrua2_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonTrua2 = Convert.ToInt32(cbTrua2.SelectedIndex.ToString());
            DataSet dsMonTrua2 = MonAn.LayMonAnTheoID(MonTrua2 + 1);
            cbMonTrua2.DataSource = dsMonTrua2.Tables[0];
            cbMonTrua2.ValueMember = dsMonTrua2.Tables[0].Columns[0].ToString();
            cbMonTrua2.DisplayMember = dsMonTrua2.Tables[0].Columns[1].ToString();
            if (cbMonTrua2.SelectedIndex >= 0)
            {
                monTrua2 = cbMonTrua2.SelectedValue.ToString();
            }
        }

        private void cbTrua3_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonTrua3 = Convert.ToInt32(cbTrua3.SelectedIndex.ToString());
            DataSet dsMonTrua3 = MonAn.LayMonAnTheoID(MonTrua3 + 1);
            cbMonTrua3.DataSource = dsMonTrua3.Tables[0];
            cbMonTrua3.ValueMember = dsMonTrua3.Tables[0].Columns[0].ToString();
            cbMonTrua3.DisplayMember = dsMonTrua3.Tables[0].Columns[1].ToString();
            if (cbMonTrua3.SelectedIndex >= 0)
            {
                monTrua3 = cbMonTrua3.SelectedValue.ToString();
            }
        }

        private void cbTrua4_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonTrua4 = Convert.ToInt32(cbTrua4.SelectedIndex.ToString());
            DataSet dsMonTrua4 = MonAn.LayMonAnTheoID(MonTrua4 + 1);
            cbMonTrua4.DataSource = dsMonTrua4.Tables[0];
            cbMonTrua4.ValueMember = dsMonTrua4.Tables[0].Columns[0].ToString();
            cbMonTrua4.DisplayMember = dsMonTrua4.Tables[0].Columns[1].ToString();
            if (cbMonTrua4.SelectedIndex >= 0)
            {
                monTrua4 = cbMonTrua4.SelectedValue.ToString();
            }

        }

        private void cbXe21_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonXe21 = Convert.ToInt32(cbXe21.SelectedIndex.ToString());
            DataSet dsMonXe21 = MonAn.LayMonAnTheoID(MonXe21 + 1);
            cbMonXe21.DataSource = dsMonXe21.Tables[0];
            cbMonXe21.ValueMember = dsMonXe21.Tables[0].Columns[0].ToString();
            cbMonXe21.DisplayMember = dsMonXe21.Tables[0].Columns[1].ToString();
            if (cbMonXe21.SelectedIndex >= 0)
            {
                monXe21 = cbMonXe21.SelectedValue.ToString();
            }

        }

        private void cbXe22_SelectedValueChanged(object sender, EventArgs e)
        {
            int MonXe22 = Convert.ToInt32(cbXe22.SelectedIndex.ToString());
            DataSet dsMonXe22 = MonAn.LayMonAnTheoID(MonXe22 + 1);
            cbMonXe22.DataSource = dsMonXe22.Tables[0];
            cbMonXe22.ValueMember = dsMonXe22.Tables[0].Columns[0].ToString();
            cbMonXe22.DisplayMember = dsMonXe22.Tables[0].Columns[1].ToString();
            if (cbMonXe22.SelectedIndex >= 0)
            {
                monXe22 = cbMonXe22.SelectedValue.ToString();
            }
        }


        //Hiển thị datagridview
        //Tạo 1 dataset tổng rồi add từng cái vào       

        private void cbMonSang1_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
            try
            {
                string x = cbMonSang1.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void cbMonSang2_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
            try
            {
                string y = cbMonSang2.SelectedValue.ToString();
                //MessageBox.Show(y);
            }
            catch (Exception)
            {

            }
        }

        private void cbMonXe11_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void cbMonXe12_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void cbMonTrua1_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void cbMonTrua2_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void cbMonTrua3_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void cbMonTrua4_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void cbMonXe21_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void cbMonXe22_SelectedValueChanged(object sender, EventArgs e)
        {
            GetNguyenLieu();
        }

        private void GetNguyenLieu()
        {
            //dsNguyenLieu nguyên liệu tổng, đưa xuống datagridview
            DataSet dsNguyenLieu = new DataSet();
            //dsMon lấy nguyên liệu của món đã chọn
            DataSet dsMon;
            float Lipid = 0;
            float Protid = 0;
            float Kcal = 0;
            float Glucid = 0;
            //Nếu cb món có giá trị khác null, tức là đã chọn.
            if (cbMonSang1.SelectedIndex >= 0)
            {
                try
                {
                    int ChiTietMon = Convert.ToInt32(cbMonSang1.SelectedValue.ToString());
                    dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                    dsNguyenLieu = dsMon;

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
                catch (Exception)
                {

                  
                }
            }

            if (cbMonSang2.SelectedIndex>0)
            {
                int ChiTietMon = Convert.ToInt32(cbMonSang2.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);

                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonXe11.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonXe11.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);
                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonXe12.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonXe12.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);
                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonTrua1.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonTrua1.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);
                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonTrua2.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonTrua2.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);
                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonTrua3.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonTrua3.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);
                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonTrua4.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonTrua4.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);
                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonXe21.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonXe21.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);
                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (cbMonXe22.ValueMember != "")
            {
                int ChiTietMon = Convert.ToInt32(cbMonXe22.SelectedValue.ToString());
                dsMon = NguyenLieu.LayNguyenLieuMonAnTheoID(ChiTietMon);
                //Nếu rỗng thì gán luôn
                if (dsNguyenLieu.Tables.Count == 0)
                {
                    dsNguyenLieu = dsMon;
                }
                else
                {   //Không rỗng thì ta thêm vào
                    foreach (DataRow dr in dsMon.Tables[0].Rows)
                    {
                        dsNguyenLieu.Tables[0].Rows.Add(dr.ItemArray);

                    }

                    DataSet dsDinhDuong = MonAn.LayNguyenLieuMonAnTheoIDMon(ChiTietMon);
                    for (int i = 0; i < dsDinhDuong.Tables[0].Rows.Count; i++)
                    {
                        Glucid += float.Parse(dsDinhDuong.Tables[0].Rows[i][0].ToString());
                        Kcal += float.Parse(dsDinhDuong.Tables[0].Rows[i][1].ToString());
                        Lipid += float.Parse(dsDinhDuong.Tables[0].Rows[i][2].ToString());
                        Protid += float.Parse(dsDinhDuong.Tables[0].Rows[i][3].ToString());
                    }
                    lblTinhBot.Text = Glucid.ToString() + " Gam";
                    lblNangLuong.Text = Kcal.ToString() + " Kcal";
                    lblChatBeo.Text = Lipid.ToString() + " Gam";
                    lblChatDam.Text = Protid.ToString() + " Gam";
                }
            }

            if (dsNguyenLieu.Tables.Count != 0)
            {
                dgvNguyenLieu.DataSource = dsNguyenLieu.Tables[0];
            }
        }

        private void cbSang1_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn = NhomMonAn.LayTatCaNhomMonAn();

            cbSang1.DataSource = dsNhomMonAn.Tables[0];
            cbSang1.ValueMember = dsNhomMonAn.Tables[0].Columns[0].ToString();
            cbSang1.DisplayMember = dsNhomMonAn.Tables[0].Columns[1].ToString();

        }

        private void cbSang2_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn1 = NhomMonAn.LayTatCaNhomMonAn();

            cbSang2.DataSource = dsNhomMonAn1.Tables[0];
            cbSang2.ValueMember = dsNhomMonAn1.Tables[0].Columns[0].ToString();
            cbSang2.DisplayMember = dsNhomMonAn1.Tables[0].Columns[1].ToString();
        }

        private void cbXe11_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn2 = NhomMonAn.LayTatCaNhomMonAn();

            cbXe11.DataSource = dsNhomMonAn2.Tables[0];
            cbXe11.ValueMember = dsNhomMonAn2.Tables[0].Columns[0].ToString();
            cbXe11.DisplayMember = dsNhomMonAn2.Tables[0].Columns[1].ToString();
        }

        private void cbXe12_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn3 = NhomMonAn.LayTatCaNhomMonAn();

            cbXe12.DataSource = dsNhomMonAn3.Tables[0];
            cbXe12.ValueMember = dsNhomMonAn3.Tables[0].Columns[0].ToString();
            cbXe12.DisplayMember = dsNhomMonAn3.Tables[0].Columns[1].ToString();
        }

        private void cbTrua1_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn4 = NhomMonAn.LayTatCaNhomMonAn();

            cbTrua1.DataSource = dsNhomMonAn4.Tables[0];
            cbTrua1.ValueMember = dsNhomMonAn4.Tables[0].Columns[0].ToString();
            cbTrua1.DisplayMember = dsNhomMonAn4.Tables[0].Columns[1].ToString();
        }

        private void cbTrua2_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn5 = NhomMonAn.LayTatCaNhomMonAn();

            cbTrua2.DataSource = dsNhomMonAn5.Tables[0];
            cbTrua2.ValueMember = dsNhomMonAn5.Tables[0].Columns[0].ToString();
            cbTrua2.DisplayMember = dsNhomMonAn5.Tables[0].Columns[1].ToString();
        }

        private void cbTrua3_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn6 = NhomMonAn.LayTatCaNhomMonAn();

            cbTrua3.DataSource = dsNhomMonAn6.Tables[0];
            cbTrua3.ValueMember = dsNhomMonAn6.Tables[0].Columns[0].ToString();
            cbTrua3.DisplayMember = dsNhomMonAn6.Tables[0].Columns[1].ToString();
        }

        private void cbTrua4_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn7 = NhomMonAn.LayTatCaNhomMonAn();

            cbTrua4.DataSource = dsNhomMonAn7.Tables[0];
            cbTrua4.ValueMember = dsNhomMonAn7.Tables[0].Columns[0].ToString();
            cbTrua4.DisplayMember = dsNhomMonAn7.Tables[0].Columns[1].ToString();
        }

        private void cbXe21_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn8 = NhomMonAn.LayTatCaNhomMonAn();

            cbXe21.DataSource = dsNhomMonAn8.Tables[0];
            cbXe21.ValueMember = dsNhomMonAn8.Tables[0].Columns[0].ToString();
            cbXe21.DisplayMember = dsNhomMonAn8.Tables[0].Columns[1].ToString();
        }

        private void cbXe22_Click(object sender, EventArgs e)
        {
            DataSet dsNhomMonAn9 = NhomMonAn.LayTatCaNhomMonAn();

            cbXe22.DataSource = dsNhomMonAn9.Tables[0];
            cbXe22.ValueMember = dsNhomMonAn9.Tables[0].Columns[0].ToString();
            cbXe22.DisplayMember = dsNhomMonAn9.Tables[0].Columns[1].ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbSang1.SelectedIndex = -1;
            cbSang2.SelectedIndex = -1;
            cbXe11.SelectedIndex = -1;
            cbXe12.SelectedIndex = -1;
            cbXe21.SelectedIndex = -1;
            cbXe22.SelectedIndex = -1;
            cbTrua1.SelectedIndex = -1;
            cbTrua2.SelectedIndex = -1;
            cbTrua3.SelectedIndex = -1;
            cbTrua4.SelectedIndex = -1;
            dgvNguyenLieu.DataSource = null;
            lblChatBeo.Text = "";
            lblChatDam.Text = "";
            lblNangLuong.Text = "";
            lblTinhBot.Text = "";
            txtSuatAn.Text = "";

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            //string value1 = cbMonSang1.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value1))
            //{

            //}
            //string value2 = cbMonSang2.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value2))
            //{

            //}
            //string value3 = cbMonXe11.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value3))
            //{

            //}
            //string value4 = cbMonXe12.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value4))
            //{

            //}
            //string value5 = cbMonTrua1.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value5))
            //{

            //}
            //string value6 = cbMonTrua2.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value6))
            //{

            //}
            //string value7 = cbMonXe21.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value7))
            //{

            //}
            //string value8 = cbMonXe22.ValueMember.ToString();
            //if (!String.IsNullOrEmpty(value8))
            //{

            //}

            try
            {
               
                string SuatAn = txtSuatAn.Text.Trim();
                int SoSuatAn;
                bool isSoSuatAn = int.TryParse(SuatAn, out SoSuatAn);
                if (isSoSuatAn)
                {
                    if (Convert.ToInt32(txtSuatAn.Text) < 0)
                    {
                        MessageBox.Show("Vui lòng nhập ít nhất 1 suất ăn.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số suất ăn hợp lệ");
                    return;
                }

                DateTime ngay = dtNgay.Value.Date;
                //var ngayString = ngay.ToString("dd/MM/yyyy");
                DateTime now = DateTime.Now;
                //var nowString = now.ToString("dd/MM/yyyy");

                //if(cbMonSang1 != null)
                //{

                //}
                string idBua1 = "1";
                string idMon1 = cbMonSang1.SelectedValue.ToString();

                if ((cbSang1.ValueMember.ToString() == "")
                    && (cbSang2.ValueMember.ToString() == "")
                    && cbXe11.ValueMember.ToString() == "" && cbXe12.ValueMember.ToString() == "" && cbTrua1.ValueMember.ToString() == "" && cbTrua2.ValueMember.ToString() == "" && cbTrua3.ValueMember.ToString() == "" && cbTrua4.ValueMember.ToString() == "" && cbXe21.ValueMember.ToString() == "" && cbXe22.ValueMember.ToString() == ""
                    )
                {
                    MessageBox.Show("Vui lòng nhập ít nhất 1 món ăn.");
                    return;
                }

                ThucDon.ThemThucDon(now,ngay,SoSuatAn,idMon1,idBua1);

                MessageBox.Show("Thêm thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //if (cbMonSang1.SelectedIndex.ToString() == "-1")
            //{
            //    MessageBox.Show("cbMonSang1 rỗng");
            //    //save
            //}
            //else
            //{
            //    //ThucDon.ThemThucDon=
            //    MessageBox.Show(cbMonSang1.SelectedValue.ToString());
      
            //}

            //if (cbMonSang2.SelectedIndex.ToString() == "-1")
            //{
                
            //    //MessageBox.Show("cbMonSang2 rỗng");
            //    //save
            //}
        }

        private void cbMonSang1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

