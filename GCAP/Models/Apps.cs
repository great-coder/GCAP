using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAP.Models
{
    public enum ACCESS
    {
        Administrator,
        Manager,
        User
    }

    public class UserApp
    {
        [Key, Column(Order = 0)]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Key, Column(Order = 1)]
        public string ClientId { get; set; }

        public ACCESS AppAccess { get; set; }
    }
}
