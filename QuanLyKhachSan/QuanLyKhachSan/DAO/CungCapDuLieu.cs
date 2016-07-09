using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAO
{
    public class CungCapDuLieu
    {
        private static SqlConnection _con = null;

        static CungCapDuLieu()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
            _con = new SqlConnection(strConnection);
        }

        public DataTable GetTable(string sql)
        {
            string strConnection = @"Data Source=.;Initial Catalog=QLKS;Integrated Security=True";
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
            string strConnection = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
            _con = new SqlConnection(strConnection);
            try
            {
                SqlCommand cmd = new SqlCommand(storeProcName, _con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Lay so parameter
                int N = arrParameterName.Count;
                for (int i = 0; i < N; i++)
                {
                    SqlParameter sqlParam = new SqlParameter(arrParameterName[i], arrParameterValue[i]);
                    cmd.Parameters.Add(sqlParam);
                }
                _con.Open();
                cmd.ExecuteNonQuery();
                _con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi khi thuc thi store procedure: " + ex.Message);
            }

            return resTable;
        }

        public DataTable ExecuteStoreProc_Data(string storeProcName, IList<string> arrParameterName, ArrayList arrParameterValue)
        {
            DataTable resTable = new DataTable();
            string strConnection = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
            _con = new SqlConnection(strConnection);
            try
            {
                _con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(storeProcName, _con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                //Lay so parameter
                int N = arrParameterName.Count;
                for (int i = 0; i < N; i++)
                {
                    SqlParameter sqlParam = new SqlParameter(arrParameterName[i], arrParameterValue[i]);
                    adapter.SelectCommand.Parameters.Add(sqlParam);
                }
                adapter.Fill(resTable);
                _con.Close();
                return resTable;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi khi thuc thi store procedure: " + ex.Message);
            }
                return resTable;
        }

        public int ExecuteStoreProc_Check(string storeProcName, IList<string> arrParameterName, ArrayList arrParameterValue)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["QLKS"].ConnectionString;
            _con = new SqlConnection(strConnection);
            try
            {
                SqlCommand cmd = new SqlCommand(storeProcName,_con);
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

                _con.Open();
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
