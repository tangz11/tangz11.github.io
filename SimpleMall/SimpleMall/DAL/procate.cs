using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class procate
    {
       public int Insert(Model.procate model)
       {

           StringBuilder sql = new StringBuilder();

           sql.Append("insert into procate ");

           sql.Append(" values (");

           sql.Append("@catename,@fathercateid");

           sql.Append(")");

           SqlParameter[] par = {
                              new SqlParameter("@catename",SqlDbType.VarChar,50),
                              new SqlParameter("@fathercateid",SqlDbType.Int,4),
                             
                             
                             };


           par[0].Value = model.catename;
           par[1].Value = model.fathercateid;
         





           return Common.DbHelperSQL.ExecuteSql(sql.ToString(), par);

       }
       public DataSet dataset()
       {
           StringBuilder sql = new StringBuilder();

           sql.Append("select * from procate");

           return Common.DbHelperSQL.Query(sql.ToString());
 
       }
       public DataSet data_set()
       {
           StringBuilder sql = new StringBuilder();

           sql.Append("select * from procate,fathercate where procate._fathercateid=fathercate._fathercateid");

           return Common.DbHelperSQL.Query(sql.ToString());
 
       }
       public string select_name(int cate_id)
       {
           string sql = "select _catename from procate where _cateid="+cate_id+"";
           return Convert.ToString(Common.DB.ExecuteScalar(sql));

       }
       public int num(int f_id)
       {
           string sql = "select count(*) from procate where _fathercateid=" + f_id + "";
           return Convert.ToInt32(Common.DB.ExecuteScalar(sql));
       }
       public int update(Model.procate mym)
       {
           string sql = "update procate set _catename='" + mym.catename + "', _fathercateid=" + mym.fathercateid + " where _cateid="+mym.cateid+"";
           return Convert.ToInt32(Common.DB.ExecuteSql(sql)); 
       }
       public int delete(int cate_id)
       {
           string sql = "delete from procate where _cateid=" + cate_id + "";
           return Convert.ToInt32(Common.DB.ExecuteSql(sql)); 
       }
       public DataSet data_f(int f_cateid)
       {
           string sql = "select *  from procate where _fathercateid=" + f_cateid + "";
           return Common.DB.dataSet(sql);
       }
    }
}
