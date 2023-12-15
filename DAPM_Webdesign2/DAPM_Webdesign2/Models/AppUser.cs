using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DAPM_Webdesign2.Models
{
    public class AppUser : IdentityUser
    {
        public string? Password { get; set; }
        [Key]
        public string? Email { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? dateofbirth { get; set; }
        public string? streetname { get; set; }
        public int? streetnumber { get; set; }
        public int? plz { get; set; }
        public string? city { get; set; }
        public int? companynumber { get; set; }
        
        
    }
}
