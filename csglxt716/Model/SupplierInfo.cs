using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csglxt716.Model
{
    /// <summary>
    /// 供应商表
    /// </summary>
    public class SupplierInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string contract { get; set; }
    }
}