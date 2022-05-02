using Common.Enums;
using Domain.Base.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Basic
{
    public class Line : AuditBaseEntity
    {
        public string FullNumber { get; set; }

        public string AreaCode { get; set; }

        public string CountryCode { get; set; }

        public LineType Type { get; set; } = LineType.Private;

        public bool IsAssumption { get; set; } = true;

        [ForeignKey("User")]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}