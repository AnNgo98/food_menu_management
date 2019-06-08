using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlThucDon
{
    interface UserInterface
    {
        int getID();
        void setID(int id);

        string getTen();
        void setTen(string ten);
    }
}
