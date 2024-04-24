using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHYMG.payments.instance;

namespace WHYMG.paymentStatmenents
{
    /// <summary>
    /// 支付类型工厂类
    /// </summary>
    public class PaymentTypeFactory
    {
        IPaymentType[] PaymentTypes = { 
            new Alipay(), 
            new WechatPay() 
        };


    }
}
