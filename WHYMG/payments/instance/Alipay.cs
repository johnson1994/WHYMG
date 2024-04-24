using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHYMG.paymentStatmenents;

namespace WHYMG.payments.instance
{

    /// <summary>
    /// 支付宝
    /// </summary>
    public class Alipay : IPaymentType
    {
        string IPaymentType.Name => "AliPay";

        /// <summary>
        /// 检查文件是否为 支付宝对账单
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        bool IPaymentType.CheckFile(string path)
        {
            return false;
        }

        /// <summary>
        /// 解析支付宝对账单
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        List<Payment> IPaymentType.ReadAndParsePaymentRecords(string path)
        {
            return new List<Payment>();
        }
    }
}
