using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ThucDonBAL
    {
        private DAL db;

        public ThucDonBAL()
        {
            db = new DAL();
        }

        public string ThemThucDon(DateTime ngaytao,DateTime ngaylap,int sosuatan,int idMon)
        {
            string query = "spThemThucDon";
            //return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure,
                new SqlParameter("@NgayLap", ngaytao),
                new SqlParameter("@NgayThucHien", ngaylap),
                new SqlParameter("@SoPhanAn", sosuatan),
                new SqlParameter("@IDMonAn", idMon));
        }
    }
}

