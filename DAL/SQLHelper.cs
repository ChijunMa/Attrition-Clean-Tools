using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class SQLHelper
    {
        private static string Getstring()
        {
            FileStream fs = new FileStream("SQLConfig.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sqlstrings = sr.ReadLine();
            sr.Close();
            fs.Close();
            return sqlstrings;
 
        }


        // private static string connString = Getstring();

        private static string connString =Getstring();
        public static object GetSingleReslt(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {

                throw new Exception("与数据连接发生异常，无法连接到数据库。详细信息如下\r\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("与数据连接发生异常，无法连接到数据库。详细信息如下\r\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
