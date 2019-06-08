using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class NhomMonAnBAL
    {
        //private DAL db;

        //public NhomMonAnBAL()
        //{
        //    db = new DAL();
        //}

        public DataSet LayTatCaNhomMonAn()
        {
            string query = "SELECT * FROM NhomMonAn";
            return DataProvider.Ins.db.ExecuteQuery(query, CommandType.Text, null);
        }
    }
}