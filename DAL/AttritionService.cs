using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AttritionService
    {
        #region 抛料数据

        /// <summary>
        /// 获取抛料总数
        /// </summary>
        /// <param name="Timefrom"></param>
        /// <param name="Timeend"></param>
        /// <returns>int 抛料总数</returns>
        public int GetAllReject(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "select sum(sRejectVacuum + sRejectIdent + sTrackEmpty)  from CompDetail ";
            sql += " where lIdBlock between (select MIN(lidblock) from CompBlock where dtCreated between '{0}' and '{1}')";
            sql += " and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            int AllReject = Convert.ToInt32(SQLHelper.GetSingleReslt(sql));

            try
            {
                return AllReject;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        /// <summary>
        /// 获取所有拾取数量
        /// </summary>
        /// <param name="Timefrom"></param>
        /// <param name="Timeend"></param>
        /// <returns>int 拾取shuliang</returns>
        public int GetAllPicked(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "SELECT SUM (sAccessTotal) from CompDetail";
            sql += " where lIdBlock between (select MIN(lidblock) from CompBlock where dtCreated between '{0}' and '{1}')";
            sql += " and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            int AllPick = Convert.ToInt32(SQLHelper.GetSingleReslt(sql));

            try
            {
                return AllPick;
            }
            catch (Exception newex)
            {

                throw newex;
            }

        }

        /// <summary>
        /// 获取所有需求数量
        /// </summary>
        /// <param name="Timefrom"></param>
        /// <param name="Timeend"></param>
        /// <returns>int 需求</returns>
        public int GetAllPlaceMent(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "SELECT SUM (sPlacedComponents) from CompDetail";
            sql += " where lIdBlock between (select MIN(lidblock) from CompBlock where dtCreated between '{0}' and '{1}')";
            sql += " and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            int AllPick = Convert.ToInt32(SQLHelper.GetSingleReslt(sql));

            try
            {
                return AllPick;
            }
            catch (Exception newex)
            {

                throw newex;
            }

        }



        /// <summary>
        /// 获取所有Ident抛料数量
        /// </summary>
        /// <param name="Timefrom"></param>
        /// <param name="Timeend"></param>
        /// <returns>identQTY</returns>
        public int GetAllIdent(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "select sum( sRejectIdent )  from CompDetail ";
            sql += "  where lIdBlock between (select MIN(lidblock) from CompBlock where dtCreated between '{0}' and '{1}')";
            sql += "  and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            int RejectQTY = Convert.ToInt32(SQLHelper.GetSingleReslt(sql));

            try
            {
                return RejectQTY;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// 获取所有Feeder抛料数量
        /// </summary>
        /// <param name="Timefrom"></param>
        /// <param name="Timeend"></param>
        /// <returns>FeederQTY</returns>
        public int GetAllFeeder(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "select sum( sTrackEmpty )  from CompDetail ";
            sql += "  where lIdBlock between (select MIN(lidblock) from CompBlock where dtCreated between '{0}' and '{1}')";
            sql += "  and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            int RejectQTY = Convert.ToInt32(SQLHelper.GetSingleReslt(sql));

            try
            {
                return RejectQTY;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// 获取所有vacuum抛料数量
        /// </summary>
        /// <param name="Timefrom"></param>
        /// <param name="Timeend"></param>
        /// <returns>VacuumQTY</returns>
        public int GetAllVacuum(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "select sum( sRejectVacuum )  from CompDetail ";
            sql += "  where lIdBlock between (select MIN(lidblock) from CompBlock where dtCreated between '{0}' and '{1}')";
            sql += "  and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            int RejectQTY = Convert.ToInt32(SQLHelper.GetSingleReslt(sql));

            try
            {
                return RejectQTY;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region 清除拾取数量
        public int CleanVacuumPickupQTY(DateTime Timefrom, DateTime Timeend)
        {
            string sql = "update CompDetail set sAccessTotal= sPlacedComponents ";
            sql += " where sRejectVacuum >0  and lIdBlock between";
            sql += " ( select MIN ( lidblock) from CompBlock where dtCreated between '{0}' and '{1}')  and  ";
            sql += " ( select max ( lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            try
            {
                int Cleanresult = Convert.ToInt32(SQLHelper.Update(sql));
                return Cleanresult;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public int CleanIdentPickupQTY(DateTime Timefrom, DateTime Timeend)
        {
            string sql = "update CompDetail set sAccessTotal= sPlacedComponents ";
            sql += " where sRejectIdent >0  and lIdBlock between";
            sql += " ( select MIN ( lidblock) from CompBlock where dtCreated between '{0}' and '{1}')  and  ";
            sql += " ( select max ( lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            try
            {
                int Cleanresult = Convert.ToInt32(SQLHelper.Update(sql));
                return Cleanresult;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public int CleanFeederPickupQTY(DateTime Timefrom, DateTime Timeend)
        {
            string sql = "update CompDetail set sAccessTotal= sPlacedComponents ";
            sql += " where sTrackEmpty >0  and lIdBlock between";
            sql += " ( select MIN ( lidblock) from CompBlock where dtCreated between '{0}' and '{1}')  and  ";
            sql += " ( select max ( lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            try
            {
                int Cleanresult = Convert.ToInt32(SQLHelper.Update(sql));
                return Cleanresult;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion


        #region 修改抛料数量

        public int EditIdentQTY(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "update CompDetail set sRejectIdent= 0  where   sRejectIdent >0  and ";
            sql += " lIdBlock between";
            sql += " ( select MIN ( lidblock) from CompBlock where dtCreated between  '{0}' and '{1}') ";
            sql += "  and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            try
            {
                int EditQTY = SQLHelper.Update(sql);
                return EditQTY;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int EditVacuumQTY(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "update CompDetail set sRejectVacuum= 0  where   sRejectVacuum >0  and ";
            sql += " lIdBlock between";
            sql += " ( select MIN ( lidblock) from CompBlock where dtCreated between  '{0}' and '{1}') ";
            sql += "  and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            try
            {
                int EditQTY = SQLHelper.Update(sql);
                return EditQTY;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int EditFeederQTY(DateTime Timefrom, DateTime Timeend)
        {

            string sql = "update CompDetail set sTrackEmpty= 0  where   sTrackEmpty >0  and ";
            sql += " lIdBlock between";
            sql += " ( select MIN ( lidblock) from CompBlock where dtCreated between  '{0}' and '{1}') ";
            sql += "  and  (select max(lidblock) from CompBlock where dtCreated between '{2}' and '{3}')";
            sql = string.Format(sql, Timefrom, Timeend, Timefrom, Timeend);
            try
            {
                int EditQTY = SQLHelper.Update(sql);
                return EditQTY;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        public bool TestConnect (string ServerName,string Uid,string Pwd)
        {
            string ConnString = "Server={0};Database=SiplaceOIS;Uid={1};Pwd={2}";
            ConnString = string.Format(ConnString, ServerName, Uid, Pwd);
            SqlConnection conn = new SqlConnection(ConnString);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex )
            {

                throw new Exception("❶与数据库连接出现错误\r\n❷如果具体信息仅有一行,请检查帐号密码\r\n❸如果具体信息有很多行，请检查SQLServerName是否存在\r\n******************************************\r\n具体信息如下\r\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
 
        }
    }
}
