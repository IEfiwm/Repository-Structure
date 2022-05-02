using Common.Enums;
using Domain.Base.Entity;
using System;

namespace Domain.Entities.Basic
{
    public class Payment : IdentityBaseEntity
    {
        public string Title { get; set; }

        public string TrackingCode { get; set; }

        public string Authority{ get; set; }

        public double PriceAmount { get; set; }

        public double DiscountAmount { get; set; } = 0;

        public double Tax { get; set; } = 0;

        public double TotalAmount
        {
            get
            {
                return (PriceAmount - DiscountAmount) + Tax;
            }
        }

        public PaymentStatus Status { get; set; } = PaymentStatus.UnPaid;

        public TransactionStatus TransactionStatus { get; set; } = TransactionStatus.Unknown;

        public string Description { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime ChangeStatusDate { get; set; } = DateTime.Now;

        public bool IsVerified { get; set; } = true;
    }
}
