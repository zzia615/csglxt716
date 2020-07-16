using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csglxt716.Model
{
    /// <summary>
    /// 商品信息表
    /// </summary>
    public class ProductInfo
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public string cname { get; set; }
        /// <summary>
        /// 条码
        /// </summary>
        public string barcode { get; set; }
        /// <summary>
        /// 店内码
        /// </summary>
        public string shopcode { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public string sname { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        public string madein { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string specs { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

    }
}