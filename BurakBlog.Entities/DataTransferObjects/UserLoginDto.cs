using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class UserLoginDto
    {
        [DisplayName("E-Posta Adresi"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(100, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(10, ErrorMessage = "{0} {1} karakterden az olamaz."), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(30, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(5, ErrorMessage = "{0} {1} karakterden az olamaz."), DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
