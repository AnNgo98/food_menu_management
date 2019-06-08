using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlThucDon
{
    public class AdapterUserToQuanTri : QuanTriVienInterface
    {
        private TaiKhoanBAL TaiKhoan = new TaiKhoanBAL();
        protected User _user;
        int _quyen;

        public AdapterUserToQuanTri(User user)
        {
            _user = user;
        }
       
        public int getID()
        {
            return _user.getID();
        }

        public int getQuyen()
        {
            DataSet ds = TaiKhoan.LayTatCaTaiKhoan();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int id = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString().Split(' ')[0]);
                if (_user.getID() == id)
                {
                    _quyen = Convert.ToInt32(ds.Tables[0].Rows[i][3].ToString().Split(' ')[0]);
                }
            }
            return _quyen;
        }

        public string getTen()
        {
            return _user.getTen();
        }

        public void setID(int id)
        {
            _user.setID(id);
        }

        public void setQuyen(int quyen)
        {
            _quyen = quyen;
        }

        public void setTen(string ten)
        {
            _user.setTen(ten);
        }
    }
}
