using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHYMG.paymentStatmenents;

namespace WHYMG.payments.instance
{
    /// <summary>
    /// 微信支付
    /// </summary>
    public class WechatPay : IPaymentType
    {
        string IPaymentType.Name => "WechatPay";


        /// <summary>
        /// 检查文件是否为 微信支付对账单
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        bool IPaymentType.CheckFile(string path)
        {
            return false;
        }


        /// <summary>
        /// 解析微信支付对账单
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        List<Payment> IPaymentType.ReadAndParsePaymentRecords(string path)
        {
            return new List<Payment>();
        }
    }
}
