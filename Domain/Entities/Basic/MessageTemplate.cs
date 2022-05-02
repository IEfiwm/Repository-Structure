using Domain.Base.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Basic
{
    public class MessageTemplate : AuditBaseEntity
    {
        public MessageTemplate()
        {
            IsActive = false;
        }

        public string Template { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}