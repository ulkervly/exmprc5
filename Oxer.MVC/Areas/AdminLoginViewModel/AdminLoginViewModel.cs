using System.ComponentModel.DataAnnotations;

namespace Oxer.MVC.Areas.AdminLoginViewModel
{
    public class AdminLoginViewModel
    {
        [Required]
        [MaxLength(50)]
         public string UserName { get; set; }
        [Required]
        [MaxLength(60)]
        public string Password { get; set; }
    }
}
