using Domain.Base.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Basic
{
    public class Tarrif : IdentityBaseEntity
    {
        public double Cost { get; set; }

        public bool IsAssumption { get; set; } = true;

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}