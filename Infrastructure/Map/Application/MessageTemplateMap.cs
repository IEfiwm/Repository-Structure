using Domain.Entities.Basic;
using Infrastructure.Attribute;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Map.Application
{
    [Application]
    public class MessageTemplateMap : AuditBaseEntityMap<MessageTemplate>
    {
        public override void Configure(EntityTypeBuilder<MessageTemplate> builder)
        {
            builder.HasQueryFilter(m => m.IsActive);

            base.Configure(builder);
        }
    }
}