using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
        string strconn = "";

        //查询
        public DataTable GetDateTable(string strsql)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                SqlDataAdapter sda = new SqlDataAdapter(strsql,conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }


        //增删改

    }
}
