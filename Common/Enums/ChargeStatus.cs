using System.ComponentModel.DataAnnotations;

namespace Common.Enums
{
    public enum ChargeStatus
    {
        [Display(Name = "کاهش یافته")]
        Decrease,
        [Display(Name = "افزایش یافته")]
        Increase
    }
}