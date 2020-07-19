using csglxt716.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csglxt716.BLL
{
    public class UserBLL
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="code"></param>
        /// <param name="pwd"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool LoginSys(string code,string pwd,out string msg)
        {
            msg = "登录成功";
            UserInfo user = new DAL.UserDAL().GetSingleUser(code);
            if (user == null)
            {
                msg = "用户信息不存在";
                return false;
            }

            if (pwd != user.pwd)
            {
                msg = "用户密码输入有误";
                return false;
            }
            GlobalVar.LoginUser = user;
            return true;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="pwd_n"></param>
        /// <param name="pwd_n1"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool ChangePwd(string pwd,string pwd_n,string pwd_n1,out string msg)
        {
            msg = "密码修改成功";
            if (pwd != GlobalVar.LoginUser.pwd)
            {
                msg = "原密码输入有误";
                return false;
            }

            if (pwd == pwd_n)
            {
                msg = "新老密码不能一致";
                return false;
            }

            if (pwd_n != pwd_n1)
            {
                msg = "两次输入的新密码不一致";
                return false;
            }

            return true;
        }

        public List<UserInfo> GetUserInfo(string code,string name)
        {
            return new DAL.UserDAL().GetUserInfo(code, name);
        }

         
    }
}