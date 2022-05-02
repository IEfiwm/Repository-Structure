using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Enums
{
    public enum ChargeReason
    {
        [Display(Name = "شارژ با درگاه آنلاین")]
        RechargeWithOnlinePortal,
        [Display(Name = "پرداخت با اعتبار")]
        RechargeWithCredit,
        [Display(Name = "پرداخت نقدی")]
        RechargeWithCash,
        [Display(Name = "هدیه مناسبتی")]
        EventPrice,
        [Display(Name = "حق عضویت")]
        Subscription,
        [Display(Name = "پاداش ثبت معرف")]
        ReferalPrice,
        [Display(Name = "پاداش از سمت مدیر")]
        AdminPrice,
        [Display(Name = "مشکل در پرداخت")]
        TransactionProblem,
        [Display(Name = "مالیات")]
        Tax,
        [Display(Name = "کارمزد")]
        Wage,
        [Display(Name = "کارمزد و مالیات")]
        WageAndTax,
        [Display(Name = "مالیات بر ارزش افزوده")]
        VAT,
        [Display(Name = "تخلف")]
        Violation
    }
}