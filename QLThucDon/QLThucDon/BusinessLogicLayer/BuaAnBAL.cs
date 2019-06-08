using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BuaAnBAL
    {
        //private DAL db;

        //public BuaAnBAL()
        //{
        //    db = new DAL();
        //}

        //public DataSet LayTatCaBuaAn()
        //{
        //    string query = "LayBuaAn";
        //    return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        //}

        //--------
        public DataSet LayTatCaBuaAn()
        {
            string query = "LayBuaAn";
            return DataProvider.Ins.db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }
    }
}