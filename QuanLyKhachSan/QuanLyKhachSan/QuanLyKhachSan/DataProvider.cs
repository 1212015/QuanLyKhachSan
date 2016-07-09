using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QuanLyKhachSan
{
    public class DataProvider
    {
        private static SqlConnection _con = null;

        static DataProvider()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
            _con = new SqlConnection(strConnection);
        }

        public DataTable GetTable(string sql)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
            _con = new SqlConnection(strConnection);
            SqlDataAdapter ad = new SqlDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }

        public DataTable ExecuteQuery(string strQuery)
        {
            DataTable resTable = new DataTable();

            try
            {
                _con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(strQuery, _con);

                adapter.Fill(resTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Loi khi thuc thi lenh SQL: " + ex.Message);
            }
            finally
            {
                _con.Close();
            }

            return resTable;
        }

        public DataTable ExecuteStoreProc(string storeProcName, IList<string> arrParameterName, ArrayList arrParameterValue)
        {
            DataTable resTable = null;

            try
            {
                _con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = storeProcName;
                cmd.CommandType = CommandType.StoredProcedure;

                //Lay so parameter
                int N = arrParameterName.Count;
                for (int i = 0; i < N; i++)
                {
                    SqlParameter sqlParam = new SqlParameter(arrParameterName[i], arrParameterValue[i]);
                    cmd.Parameters.Add(sqlParam);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resTable);

                _con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi khi thuc thi store procedure: " + ex.Message);
            }

            return resTable;
        }

        public int ExecuteStoreProc_Check(string storeProcName, IList<string> arrParameterName, ArrayList arrParameterValue)
        {
            try
            {
                _con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = storeProcName;
                cmd.CommandType = CommandType.StoredProcedure;

                //Lay so parameter
                int N = arrParameterName.Count;
                for (int i = 0; i < N; i++)
                {
                    SqlParameter sqlParam = new SqlParameter(arrParameterName[i], arrParameterValue[i]);
                    cmd.Parameters.Add(sqlParam);
                }
                cmd.Parameters.Add(new SqlParameter("@ck", System.Data.SqlDbType.Int, 32));
                cmd.Parameters["@ck"].Direction = System.Data.ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                _con.Close();

                return Convert.ToInt32(cmd.Parameters["@ck"].Value);
            }

            catch (Exception ex)
            {
                throw new Exception("Loi khi thuc thi store procedure: " + ex.Message);
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
            _con.Open();
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            _con.Close();
        }
    }
}
