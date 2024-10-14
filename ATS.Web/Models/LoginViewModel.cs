using System.ComponentModel.DataAnnotations;

namespace ATS.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; } = string.Empty;
    }
}
