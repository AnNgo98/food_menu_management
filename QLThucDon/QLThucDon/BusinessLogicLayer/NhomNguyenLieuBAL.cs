using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NhomNguyenLieuBAL
    {
        //private DAL db;

        //public NhomNguyenLieuBAL()
        //{
        //    db = new DAL();
        //}

        public DataSet LayTatCaNhomNguyenLieu()
        {
            string query = "SELECT TenNhom as 'Nhóm Nguyên Liệu' FROM NhomNguyenLieu";
            return DataProvider.Ins.db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayTatCaThuocTinhNhomNguyenLieu()
        {
            string query = "SELECT * FROM NhomNguyenLieu";
            return DataProvider.Ins.db.ExecuteQuery(query, CommandType.Text, null);
        }


    }
}
