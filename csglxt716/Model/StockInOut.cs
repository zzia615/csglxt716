using System;

namespace csglxt716.Model
{
    /// <summary>
    /// 库存出入
    /// </summary>
    public class StockInOut
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string billno { get; set; }
        /// <summary>
        /// 方式：入库/出库/退货
        /// </summary>
        public string method { get; set; }
        /// <summary>
        /// 录入人
        /// </summary>
        public string recorduser { get; set; }
        /// <summary>
        /// 录入日期
        /// </summary>
        public DateTime recorddate { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string applyuser { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime applydate { get; set; }
        /// <summary>
        /// 订单状态：未审核/已审核
        /// </summary>
        public string status { get; set; }

    }
}