using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public  class  user
    {
        //注册会员
        public int insert(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into [user] ( _username,_pwd,_email,_qq,_msn,_safequestion,_safepwd ) values(@username,@pwd,@email,@qq,@msn,@safeque,@safepwd)");
            SqlParameter[] par ={
                                    new SqlParameter("@username",SqlDbType.VarChar,50),
                                    new SqlParameter ("@pwd",SqlDbType .VarChar,50),
                                    new SqlParameter ("@email",SqlDbType .VarChar,50),
                                    new SqlParameter ("@qq",SqlDbType .VarChar,50),
                                    new SqlParameter ("@msn",SqlDbType .VarChar,50),
                                    new SqlParameter ("@safeque",SqlDbType .VarChar,150),
                                    new SqlParameter ("@safepwd",SqlDbType .VarChar,150)
                                };
            par[0].Value = aa.username;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            par[2].Value = aa.email;
            par[3].Value = aa.qq;
            par[4].Value = aa.msn;
            par[5].Value = aa.safequestion;
            par[6].Value = aa.safepwd;

            return Common.DbHelperSQL.ExecuteSql(sql.ToString(),par);
        }
        //判断该用户邮箱是否存在
        public DataSet  pan(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select _userid from [user] where _email=@email");
            SqlParameter[] par ={
                                    new SqlParameter("@email",SqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            return Common.DbHelperSQL.Query(sql.ToString(),par);
        }
        public SqlDataReader dd(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select _userid from [user] where _email=@email");
            SqlParameter[] par ={
                                    new SqlParameter("@email",SqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
    
        //读取会员信息
        public SqlDataReader seleus(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from [user] where  _userid=@id");
            SqlParameter[] par ={
                                    new SqlParameter("@id",SqlDbType .Int,4)
                                };
            par[0].Value = aa.userid;
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
        //更新会员信息
        public int upuse(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update [user] set _username=@username,_pwd=@pwd,_email=@email,_qq=@qq,_msn=@msn,_safequestion=@safeque,_safepwd=@safepwd  where _userid=@id");
            SqlParameter[] par ={
                                    new  SqlParameter("@id",SqlDbType.Int,4),
                                    new  SqlParameter("@username",SqlDbType.VarChar,50),
                                    new  SqlParameter("@pwd",SqlDbType.VarChar,50),
                                    new  SqlParameter("@email",SqlDbType.VarChar,50),
                                    new  SqlParameter("@qq",SqlDbType.VarChar,50),
                                    new  SqlParameter("@msn",SqlDbType.VarChar,50),
                                    new  SqlParameter("@safeque",SqlDbType.VarChar ,150),
                                    new  SqlParameter("@safepwd",SqlDbType.VarChar ,150)
                                };
            par[0].Value = aa.userid;
            par[1].Value = aa.username;
            par[2].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            par[3].Value = aa.email;
            par[4].Value = aa.qq;
            par[5].Value = aa.msn;
            par[6].Value = aa.safequestion;
            par[7].Value = aa.safepwd;

            return Common.DbHelperSQL.ExecuteSql(sql.ToString(),par);
        }
        //会员登入
        public SqlDataReader   login(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select  _userid from [user] where _email=@email and _pwd=@pwd");
            SqlParameter[] par ={
                                    new SqlParameter("@email",SqlDbType.VarChar,50),
                                    new SqlParameter("@pwd",SqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            //
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
        //session
        public SqlDataReader lo(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from [user] where _email=@email and _pwd=@pwd");
            SqlParameter[] par ={
                                    new SqlParameter("@email",SqlDbType.VarChar,50),
                                    new SqlParameter("@pwd",SqlDbType.VarChar,50)
                                };
            par[0].Value = aa.email;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
        //个人资料
        public SqlDataReader drs(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from [user] where _userid=@userid");
            SqlParameter[] par ={
                                    new SqlParameter("@userid",SqlDbType.VarChar,50)
                                };
            par[0].Value = aa.userid;
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
        //修改个人资料
        public int upd(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update [user] set _msn=@msn,_qq=@qq,_safequestion=@safe,_safepwd=@pwd where _userid=@id");
            SqlParameter[] par ={
                                    new SqlParameter("@msn",SqlDbType.VarChar,50),
                                    new SqlParameter("@qq",SqlDbType.VarChar,50),
                                    new SqlParameter("@safe",SqlDbType.VarChar,50),
                                    new SqlParameter("@pwd",SqlDbType.VarChar,50),
                                    new SqlParameter("@id",SqlDbType.VarChar,50)   
                                };
            par[0].Value = aa.msn;
            par[1].Value = aa.qq;
            par[2].Value = aa.safequestion;
            par[3].Value = aa.safepwd;
            par[4].Value = aa.userid;
            return Common.DbHelperSQL.ExecuteSql(sql.ToString(),par);
            
        }
        //判断该密码是否正确
        public SqlDataReader  drpw(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from [user]  where _pwd=@pwd and _userid=@id");
            SqlParameter[] par ={
                                    new SqlParameter("@pwd",SqlDbType.VarChar,50),
                                    new SqlParameter("@id",SqlDbType.Int,4)
                                };
            par[0].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            par[1].Value = aa.userid;
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
        //会员收藏夹
        public int seleid(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from collect where _userid=@id");
            SqlParameter[] par ={
                                    new SqlParameter("@id",SqlDbType.Int ,4)
                                };
            par[0].Value = aa.userid;
            return Common.DbHelperSQL.ExecuteSql(sql.ToString(),par);
        }
        //记住上次登入时间时间
        public int update(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update  [user] set _logintime=@time  where _userid=@id");
            SqlParameter[] par = {
                                     new SqlParameter("@id",SqlDbType.Int,4),
                                     new SqlParameter("@time",SqlDbType.DateTime,16)
                                 };
            par[0].Value = aa.userid;
            par[1].Value = aa.time;
            return Common.DbHelperSQL.ExecuteSql(sql.ToString(),par);
        }
        public SqlDataReader drti(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from [user] where _userid=@id");
            SqlParameter[] par = {
                                     new  SqlParameter("@id",SqlDbType.Int,4)
                                 };
            par[0].Value = aa.userid;
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
        //更改密码
        public int upwd(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update [user] set _pwd=@apwd  where _userid=@id " );
            SqlParameter[] par ={
                                    new SqlParameter("@id",SqlDbType.Int,4),
                                    new SqlParameter("@apwd",SqlDbType.VarChar,50)
                                };
            par[0].Value = aa.userid;
            par[1].Value = Common.DESEncrypt.Encrypt(aa.pwd);
            return Common.DbHelperSQL.ExecuteSql(sql.ToString(),par);
        }
        public SqlDataReader drid(Model.user aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from [user] where _email=@email");
            SqlParameter[] par = {
                                     new SqlParameter("@email",SqlDbType .VarChar,50)
                                 };
            par[0].Value = aa.email;
            return Common.DbHelperSQL.ExecuteReader(sql.ToString(),par);
        }
        
     
    }
    //地址
    public class address
    {
        public int insert(Model.address aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into address (_userid) values(@id)");
            SqlParameter[] par = {
                                     new SqlParameter("@id",SqlDbType.Int,4)
                                 };
            par[0].Value = aa.userid;
            return Common.DbHelperSQL.ExecuteSql(sql.ToString(), par);
        }
    }
    //订单
    public class order
    {
        //查看订单
        public DataSet dsor(int a, int b, Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable where _userid=@id  order by _ordertime ");
            SqlParameter[] par ={
                                    new SqlParameter("@id",SqlDbType.Int,4)
                                };
            par[0].Value = aa.userid;
            return Common.DbHelperSQL.PageQuery(sql.ToString(), a, b, par);
        }
        // 订单条数
        public int coun(Model.order aa)
        {
            String sql = "select count(*)from ordertable where _userid='" + aa.userid + "'";
            int i = Convert.ToInt32(Common.DB.ExecuteScalar(sql));
            return i;
        }
        //查看某条订单
        public DataSet kandi(Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable where _ordernum=@num");
            SqlParameter[] par = {
                                     new SqlParameter("@num",SqlDbType.VarChar,50)
                                 };
            par[0].Value = aa.ordernum;
            return Common.DbHelperSQL.Query(sql.ToString(),par);
        }
        public DataSet dsmai(Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ordertable where _userid=@id and _paystate=1 order by _ordertime ");
            SqlParameter[] par = {
                                     new SqlParameter("@id",SqlDbType.Int,4)
                                 };
            par[0].Value = aa.userid;
            return Common.DbHelperSQL.Query(sql.ToString(),par);
        }
        public int deo(Model.order aa)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from ordertable where _userid=@uid and _id=@id");
            SqlParameter[] par = {
                                     new  SqlParameter("@uid",SqlDbType.Int,4),
                                     new  SqlParameter("@id",SqlDbType.Int,4)
                                 };
            par[0].Value = aa.userid;
            par[1].Value = aa.id;
            return Common.DbHelperSQL.ExecuteSql(sql.ToString(),par);
        }
    
    }
    


}
