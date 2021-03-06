using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class UserUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Kullanıcı Adı"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(50, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string UserName { get; set; }

        [DisplayName("E-Posta Adresi"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(100, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(10, ErrorMessage = "{0} {1} karakterden az olamaz."), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Telefon Numarası"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(13, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(13, ErrorMessage = "{0} {1} karakterden az olamaz."), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DisplayName("Resim Ekle"), DataType(DataType.Upload)]
        public IFormFile PictureFile { get; set; }
        [DisplayName("Resim")]
        public string? Picture { get; set; }
    }
}
