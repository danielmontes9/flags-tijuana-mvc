using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace flags_tijuana_mvc.Models.Entities
{
    public class FlagEntity
    {
        [Key] public int Id { get; set; }
        public required string Name { get; set; }
        public IdentityUser User { get; set; } = null!;
        public required virtual string UserId { get; set; }
        public required bool Velue { get; set; }

    }
}
