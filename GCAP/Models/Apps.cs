using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCAP.Models
{
    public class App
    {
        [Key]
        public string AppId { get; set; }

        public string Name { get; set; }
    }

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
        [ForeignKey("App")]
        public string AppId { get; set; }
        public virtual App App { get; set; }

        public ACCESS AppAccess { get; set; }
    }
}
