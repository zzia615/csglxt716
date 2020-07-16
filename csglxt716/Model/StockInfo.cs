using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csglxt716.Model
{
    /// <summary>
    /// 库存信息表
    /// </summary>
    public class StockInfo
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// ID跟ProductInfo.id一样
        /// </summary>
        public int pid { get; set; }
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
        /// 进单（同一种商品价格每次进价可能不太一样）
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// 零售价
        /// </summary>
        public decimal sellprice { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }
    }
}