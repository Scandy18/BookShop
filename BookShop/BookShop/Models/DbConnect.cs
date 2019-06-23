using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BookShop.Models
{
    public class DbConnect
    {
        protected SqlConnection conn;

        public void OpenConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString);
            try
            {
                if (conn.State.ToString() != "Open")
                    conn.Open();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int InsertData(string sql)
        {
            try
            {
                if (conn.State.ToString() == "Open")
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    return  cmd.ExecuteNonQuery();
                }
                return 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataSet List(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable Detail(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Delete(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}