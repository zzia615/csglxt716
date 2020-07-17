using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csglxt716.Model
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 账号
        /// </summary>
        [column(PrimaryKey = true)]
        public string code { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string pwd { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string sfzh { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public string type { get; set; }

    }
}