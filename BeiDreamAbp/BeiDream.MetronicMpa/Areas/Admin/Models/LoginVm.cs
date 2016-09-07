using System.ComponentModel.DataAnnotations;
using Abp.Auditing;

namespace BeiDream.MetronicMpa.Areas.Admin.Models
{
    public class LoginVm
    {


        [Required]
        public string UsernameOrEmailAddress { get; set; }

        [Required]
        [DisableAuditing]
        public string Password { get; set; }

        [Required]
        public string VCode { get; set; }

        public bool RememberMe { get; set; }
    }
}