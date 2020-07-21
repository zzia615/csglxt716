using csglxt716.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace csglxt716.DAL
{
    public class UserDAL
    {
        public List<UserInfo> GetUserInfo(string code, string name,int pageIndex=1,int pageSize=10)
        {
            StringBuilder sWHERE = new StringBuilder();

            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(code))
            {
                sWHERE.Append(" AND code=@code");
                parameters.Add(new SqlParameter("@code", code));
            }
            if (!string.IsNullOrEmpty(name))
            {
                sWHERE.Append(" AND name=@name");
                parameters.Add(new SqlParameter("@name", name));
            }

            StringBuilder sSQL = new StringBuilder(SqlServerHelper.GetPageSql("UserInfo", new[] { "code" }, pageIndex, pageSize, sWHERE.ToString()));

            return new SqlServerHelper().Query<UserInfo>(sSQL.ToString(), parameters);
        }
        public int GetUserCount(string code, string name)
        {
            StringBuilder sWHERE = new StringBuilder();

            List<SqlParameter> parameters = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(code))
            {
                sWHERE.Append(" AND code=@code");
                parameters.Add(new SqlParameter("@code", code));
            }
            if (!string.IsNullOrEmpty(name))
            {
                sWHERE.Append(" AND name=@name");
                parameters.Add(new SqlParameter("@name", name));
            }

            StringBuilder sSQL = new StringBuilder("select * from UserInfo where 1=1 ");
            sSQL.Append(sWHERE);

            return new SqlServerHelper().QuerySqlCount(sSQL.ToString(), parameters);
        }
        public UserInfo GetSingleUser(string code)
        {
            return GetUserInfo(code, string.Empty).FirstOrDefault();
        }

        public int AddUser(UserInfo user)
        {
            return new SqlServerHelper().Add(user);
        }
        public int EditUser(UserInfo user)
        {
            return new SqlServerHelper().Edit(user);
        }
        public int DeleteUser(UserInfo user)
        {
            return new SqlServerHelper().Delete(user);
        }
    }
}