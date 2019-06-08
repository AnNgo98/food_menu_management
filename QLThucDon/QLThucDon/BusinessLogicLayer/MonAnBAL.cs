using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class MonAnBAL
    {
        private DAL db;

        public MonAnBAL()
        {
            db = new DAL();
        }

        public DataSet LayNguyenLieuMonAnTheoIDMon(int id)
        {
            string query = "select NguyenLieu.Glucid,NguyenLieu.Kcal,NguyenLieu.Lipid,NguyenLieu.Protid from MonAn,CongThucMonAn,NguyenLieu where CongThucMonAn.IDNguyenLieu = NguyenLieu.IDNguyenLieu and CongThucMonAn.IDMonAn = MonAn.IDMonAn and MonAn.IDMonAn = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public string ThemMonAn(string tenMonAn, int idNguyenLieu, float khoiLuong)
        {
            return db.ExecuteNonQuery("spThemMonAn", CommandType.StoredProcedure,
                new SqlParameter("@IDNguyenLieu", idNguyenLieu),
                new SqlParameter("@TenMonAn", tenMonAn),
                new SqlParameter("@KhoiLuong", khoiLuong));
        }

        public DataSet LayTatCaMonAn()
        {
            string query = "SELECT * FROM MonAn";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayMonAnTheoID(int id)
        {
            string query = "SELECT * FROM MonAn,NhomMonAn Where MonAn.IDNhomMonAn = NhomMonAn.IDNhomMonAn AND NhomMonAn.IDNhomMonAn =" + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayMonAnTheoTenNhomMonAn(string tenNhom)
        {
            string query = "SELECT * FROM MonAn, NhomMonAn WHERE MonAn.IDNhomMonAn = NhomMonAn.IDNhomMonAn AND NhomMonAn.TenNhom = '" + tenNhom + "'";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayDinhDuongCuaMonAn(int id)
        {
            string query = "SELECT NguyenLieu.Ten, NguyenLieu.Lipid, NguyenLieu.Protid, NguyenLieu.Kcal, NguyenLieu.Glucid FROM MonAn, NhomMonAn, CongThucMonAn, NguyenLieu WHERE MonAn.IDNhomMonAn = NhomMonAn.IDNhomMonAn AND CongThucMonAn.IDNguyenLieu = NguyenLieu.IDNguyenLieu AND CongThucMonAn.IDMonAn = MonAn.IDMonAn AND MonAn.IDMonAn = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayDinhDuongCuaMonAn1(int id)
        {
            string query = "SELECT NguyenLieu.Ten, NguyenLieu.Lipid, NguyenLieu.Protid, NguyenLieu.Kcal, NguyenLieu.Glucid, MonAn.IDMonAn, MonAn.TenMonAn, CongThucMonAn.KhoiLuong FROM MonAn, CongThucMonAn, NguyenLieu WHERE CongThucMonAn.IDNguyenLieu = NguyenLieu.IDNguyenLieu AND CongThucMonAn.IDMonAn = MonAn.IDMonAn AND MonAn.IDMonAn = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayMonAnTheoIDNhomMonAn(int id)
        {
            string query = "SELECT * FROM MonAn, NhomMonAn WHERE MonAn.IDNhomMonAn = NhomMonAn.IDNhomMonAn AND NhomMonAn.IDNhomMonAn = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayDinhMucDinhDuongCuaMonAn(int id)
        {
            string query = "SELECT Ten, Lipid, Protid, Kcal, Glucid" +
                            "FROM CongThucMonAn, MonAn, NguyenLieu" +
                            "WHERE CongThucMonAn.IDMonAn = MonAn.IDMonAn AND CongThucMonAn.IDNguyenLieu = NguyenLieu.IDNguyenLieu AND MonAn.IDMonAn = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }
    }
}