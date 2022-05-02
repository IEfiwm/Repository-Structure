using Common.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Basic
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            UserKey = Guid.NewGuid().ToString("N") + Guid.NewGuid().ToString("N");

            ApiKey = CommonHelper.Base64Encode(Guid.NewGuid().ToString("N"));
        }

        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(14)] //The reason being is that International standards can support up to 15 digits
        public string PhoneNumber { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(320)]// {64}@{255} so => 64 + 1 + 255 = 320
        public string Email { get; set; }

        public string CompanyName { get; set; }

        public string UserKey { get; set; }

        public string ApiKey { get; set; }

        public bool IsDeleted { get; set; } = false;

        [ForeignKey("Role")]
        public string RoleId { get; set; }

        public IdentityRole Role { get; set; }

        [NotMapped]
        public virtual List<Line> Lines { get; set; }

        [NotMapped]
        public virtual List<MessageTemplate> TemplateMessages { get; set; }

        public virtual Charge Charge { get; set; }
    }
}