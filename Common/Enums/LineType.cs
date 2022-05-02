using System.ComponentModel.DataAnnotations;

namespace Common.Enums
{
    public enum LineType
    {
        [Display(Name = "عمومی" )]
        Public,
        [Display(Name = "اختصاصی")]
        Private,
        [Display(Name = "اشتراکی")]
        Communal
    }
}