using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHYMG.paymentStatmenents
{

    /// <summary>
    /// 支付类型接口
    /// </summary>
    public interface IPaymentType
    {
        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 检查对账单文件，是否是当前支付类型的文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        bool CheckFile(string path);

        /// <summary>
        /// 读取对账单，并解析支付记录
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        List<Payment> ReadAndParsePaymentRecords(string path);

    }
}
