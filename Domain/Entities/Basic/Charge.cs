using Domain.Base.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Basic
{
    public class Charge : IdentityBaseEntity
    {
        public double Value { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public DateTime? LastChargeDateTime { get; set; }

        [ForeignKey("LastCharge")]
        public long? LastChargeId { get; set; }

        public DateTime? FirstChargeDateTime { get; set; }

        [ForeignKey("FirstCharge")]
        public long? FirstChargeId { get; set; }

        public virtual ChargeHistory FirstCharge { get; set; }

        public virtual ChargeHistory LastCharge { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}