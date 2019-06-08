using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlThucDon
{
    public class QuanTriVien : QuanTriVienInterface
    {
        private int _id;
        private string _ten;
        private int _quyen;

        public int getID()
        {
            return _id;
        }

        public int getQuyen()
        {
            return _quyen;
        }

        public string getTen()
        {
            return _ten;
        }

        public void setID(int id)
        {
            this._id = id;
        }

        public void setQuyen(int quyen)
        {
            this._quyen = quyen;
        }

        public void setTen(string ten)
        {
            this._ten = ten;
        }
    }
}
