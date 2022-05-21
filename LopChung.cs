using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLQUANAN
{
    class LopChung
    {
        SqlConnection conn;
        public LopChung()
        {
            string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winform C#\QLQUANAN\QLQUANAN.mdf;Integrated Security=True";
            conn = new SqlConnection(db);
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object TraVeGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet getData(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string sql)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            conn.Open();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
