using Domain.Base.Entity;
using Domain.Entities.Basic;
using Infrastructure.Attribute;

namespace Infrastructure.Map.Application
{
    [Application]
    public class PaymentMap : IdentityBaseEntityMap<Payment>
    {
    }
}