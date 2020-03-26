using System.ComponentModel.DataAnnotations;

namespace GCAP.Models.Account
{
    public class RegisterViewModel : LoginInputModel
    {
        [Required]
        public string GivenName { get; set; }
        [Required]
        public string FamilyName { get; set; }
    }
}
