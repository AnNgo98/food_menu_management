using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class NguyenLieuBAL
    {
        private DAL db;

        public NguyenLieuBAL()
        {
            db = new DAL();
        }

        public DataSet LayNguyenLieuMonAnTheoID(int id)
        {
            string query = "select MonAn.TenMonAn,NguyenLieu.Ten,NguyenLieu.Kcal,NguyenLieu.Protid,NguyenLieu.Lipid,NguyenLieu.Glucid from MonAn,CongThucMonAn,NguyenLieu where MonAn.IDMonAn = CongThucMonAn.IDMonAn and CongThucMonAn.IDNguyenLieu = NguyenLieu.IDNguyenLieu and MonAn.IDMonAn = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayTatCaNguyenLieu()
        {
            string query = "SELECT * FROM NguyenLieu";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayNguyenLieuTheoTenNhom(string tenNhom)
        {
            string query = "SELECT * FROM NguyenLieu, NhomNguyenLieu WHERE NguyenLieu.IDNhomNguyenLieu = NhomNguyenLieu.IDNhomNguyenLieu AND NhomNguyenLieu.TenNhom = '" + tenNhom + "'";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public string XoaNguyenLieu(int maNguyenLieu)
        {
            string query = "spDeleteNguyenLieu";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaNguyenLieu", maNguyenLieu));
        }

        public string ThemMoiNguyenLieu(string tenNguyenLieu, float lipid, float protid, float kcal, float glucid, int idNhomNguyenLieu)
        {
            string query = "spInsertNguyenLieu";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@TenNguyenLieu", tenNguyenLieu),
                new SqlParameter("@Lipid", lipid),
                new SqlParameter("@Protid", protid),
                new SqlParameter("@Kcal", kcal),
                new SqlParameter("@Glucid", glucid),
                new SqlParameter("@IDNhomNguyenLieu", idNhomNguyenLieu));
        }

        public string ChinhSuaNguyenLieu(int idNguyenLieu, string tenNguyenLieu, float lipid, float protid, float kcal, float glucid, int idNhomNguyenLieu)
        {
            string query = "spUpdateNguyenLieu";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure,
                new SqlParameter("@TenNguyenLieu", tenNguyenLieu),
                new SqlParameter("@IDNhomNguyenLieu", idNhomNguyenLieu),
                new SqlParameter("@Kcal", kcal),
                new SqlParameter("@Lipid", lipid),
                new SqlParameter("@Glucid", glucid),
                new SqlParameter("@Protid", protid),
                new SqlParameter("@IDNguyenLieu", idNguyenLieu));
        }

        public DataSet LayNguyenLieuTheoID(int id)
        {
            string query = "SELECT * FROM NguyenLieu, NhomNguyenLieu WHERE NguyenLieu.IDNhomNguyenLieu = NhomNguyenLieu.IDNhomNguyenLieu AND NhomNguyenLieu.IDNhomNguyenLieu = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet GetNguyenLieuByID(int id)
        {
            string query = "SELECT IDNguyenLieu, Ten, Lipid, Protid, Kcal, Glucid FROM NguyenLieu WHERE IDNguyenLieu = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet GetNguyenLieuByIDCoNhomNguyenLieu(int id)
        {
            string query = "SELECT IDNguyenLieu, Ten, Lipid, Protid, Kcal, Glucid, IDNhomNguyenLieu FROM NguyenLieu WHERE IDNguyenLieu = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayNguyenLieuChoChinhSuaThucPham(int id)
        {
            string query = "SELECT IDNguyenLieu, Ten, Lipid, Protid, Kcal, Glucid, NguyenLieu.IDNhomNguyenLieu, NhomNguyenLieu.TenNhom FROM NguyenLieu, NhomNguyenLieu WHERE NguyenLieu.IDNhomNguyenLieu = NhomNguyenLieu.IDNhomNguyenLieu AND IDNguyenLieu = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet LayNguyenLieuTheoMaNguyenLieu(int id)
        {
            string query = "SELECT * FROM NguyenLieu WHERE IDNguyenLieu = " + id;
            return db.ExecuteQuery(query, CommandType.Text, null);
        }
    }
}