using System.ComponentModel.DataAnnotations;

namespace Application.Enums
{
    public enum Roles
    {
        [Display(Name = "مدیر کل")]
        SuperAdmin,
        [Display(Name = "مدیر")]
        Admin,
        [Display(Name = "مشتری")]
        Customer
    }
}