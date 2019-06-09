using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
namespace BusinessLogicLayer
{
    public class MonTrongThucDonBAL
    {
        public DataSet LayMonTrongThucDonTheoID(int id)
        {
            string query = "SELECT MonTrongThucDon.IDMonAn,MonAn.TenMonAn,ThucDon.SoKhauPhan,BuaAn.Bua,BuaAn.IDBua FROM MonTrongThucDon,ThucDon,MonAn,BuaAn Where MonTrongThucDon.IDThucDon = ThucDon.IDThucDon AND MonTrongThucDon.IDMonAn = MonAn.IDMonAn AND MonTrongThucDon.IDBua = BuaAn.IDBua AND ThucDon.IDThucDon =" + id;
            return DataProvider.Ins.db.ExecuteQuery(query, CommandType.Text, null);
        }
    }
}