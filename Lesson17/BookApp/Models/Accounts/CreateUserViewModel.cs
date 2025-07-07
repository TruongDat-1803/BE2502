using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models.Accounts
{
    public class CreateUserViewModel
    {
        [DisplayName("Tên đăng nhập")]
        [StringLength(6, ErrorMessage = "Tên người dùng tối đa 6 ký tự")]
        public string UserName { get; set; }

        [DisplayName("Hòm thư")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập email đúng định dạng")]
        public string Email { get; set; }

        [DisplayName("Mật khẩu")]

        public string Password { get; set; }

        [DisplayName("Quyền")]
        public string RoleId { get; set; }
    }
}
