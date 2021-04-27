using System;
using System.Collections.Generic;

using System.Text;

using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
  public   class size
    {
      public int Insert(Model.size model)
      {

          StringBuilder sql = new StringBuilder();

          sql.Append("insert into size ");

          sql.Append(" values (");

          sql.Append("@sizid,@sizename");

          sql.Append(")");

          SqlParameter[] par = {
                              new SqlParameter("@sizid",SqlDbType.VarChar,50),
                              new SqlParameter("@sizename",SqlDbType.VarChar,50)
                                                    
                             };

          par[0].Value = model.sizeid;
          par[1].Value = model.sizename;
          return Common.DbHelperSQL.ExecuteSql(sql.ToString(), par);

      }
      public int delete(string size_id)
      {

          StringBuilder sql = new StringBuilder();

          sql.Append("delete from [size] ");
          sql.Append("where _sizeid=@sizeid");
          SqlParameter[] par = {
                              new SqlParameter("@sizeid",SqlDbType.VarChar,50)
                                };

          par[0].Value = size_id;
          return Common.DbHelperSQL.ExecuteSql(sql.ToString(), par);
 
      }
      public DataSet select_size(string size_id)
      {
          StringBuilder sql = new StringBuilder();

          sql.Append("select * from [size] ");
          sql.Append("where _sizeid=@sizeid");

          SqlParameter[] par = {
                              new SqlParameter("@sizeid",SqlDbType.VarChar,50)
                                };

          par[0].Value = size_id;
          return Common.DbHelperSQL.Query(sql.ToString(), par);
 
      }
      public int delete_1(int u_id)
      {
          string sql = "delete from size where _id=" + u_id + "";
          return Common.DB.ExecuteSql(sql);
      }
    }
}
