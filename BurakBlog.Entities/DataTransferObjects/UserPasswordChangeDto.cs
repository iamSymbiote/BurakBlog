using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class UserPasswordChangeDto
    {
        [DisplayName("Şu anki şifreniz"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(30, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(5, ErrorMessage = "{0} {1} karakterden az olamaz."), DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DisplayName("Yeni şifreniz"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(30, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(5, ErrorMessage = "{0} {1} karakterden az olamaz."), DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DisplayName("Yeni şifrenizin tekrarı"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(30, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(5, ErrorMessage = "{0} {1} karakterden az olamaz."), DataType(DataType.Password), Compare("NewPassword", ErrorMessage = "Girmiş olduğunuz yeni şifreniz ile yeni şifrenizin tekrarı birbiriyle uyuşmalıdır.")]
        public string RepeatNewPassword { get; set; }

    }
}
