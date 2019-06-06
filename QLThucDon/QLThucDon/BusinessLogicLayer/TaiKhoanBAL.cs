using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class TaiKhoanBAL
    {
        private DAL db;
        
        public TaiKhoanBAL()
        {
            db = new DAL();
        }

        public DataSet LayTatCaTaiKhoan()
        {
            string query = "SELECT * FROM TaiKhoan";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }
    }
}
