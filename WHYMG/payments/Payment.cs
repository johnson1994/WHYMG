using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHYMG.paymentStatmenents
{

    /// <summary>
    /// 支付记录
    /// </summary>
    public class Payment
    {
        public long Id { get; set; }
        public DateTime PayTime { get; set; }           // 交易时间
        public decimal Amount { get; set; }             // 支付金额
        public string PaymentType { get; set; }         // 支付类型（平台）
        public string OrderNbr { get;set; }             // 平台订单号
        public string OrderDetail { get; set; }         // 交易详情（商品信息）               
        public string Tag { get; set; }                 // 自定义标签
        public string remark { get; set; }              // 备注                                                        

    }
}
