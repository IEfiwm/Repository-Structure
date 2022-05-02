using System.ComponentModel.DataAnnotations;

namespace Common.Enums
{
    public enum TransactionStatus
    {
        [Display(Name = "موفقیت آمیز")]
        Success,
        [Display(Name = "با خطا مواجعه شده")]
        Failed,
        [Display(Name = "نا مشخص")]
        Unknown,
        //[Display(Name = "بازگشت به حساب")]
        //RoleBack
    }
}