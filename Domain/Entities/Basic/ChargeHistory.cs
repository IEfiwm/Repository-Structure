using Common.Enums;
using Domain.Base.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Basic
{
    public class ChargeHistory : IdentityBaseEntity
    {
        public double Value { get; set; }

        public ChargeStatus Status { get; set; }

        public ChargeReason Reason { get; set; }

        public string Description { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; }

        public ApplicationUser User { get; set; }
    }
}