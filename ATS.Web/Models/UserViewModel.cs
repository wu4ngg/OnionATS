using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ATS.Web.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public Int64 Id { get; set; }
        [Display(Name = "Họ Lót")]
        public string SurName { get; set; }
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Tên người dùng")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Display(Name = "Ngày thêm")]
        public DateTime DateAdded { get; set; }

    }
}
