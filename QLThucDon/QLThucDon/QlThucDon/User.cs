using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlThucDon
{
    public class User : UserInterface
    {
        private int _id;
        private string _ten;

        public int getID()
        {
            return _id;
        }

        public string getTen()
        {
            return _ten;
        }

        public void setID(int id)
        {
            this._id = id;
        }

        public void setTen(string ten)
        {
            this._ten = ten;
        }
    }
}
