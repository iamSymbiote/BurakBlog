using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BurakBlog.Entities.DataTransferObjects
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Kategori Adı"), Required(ErrorMessage = "{0} boş bırakılamaz."), MaxLength(70, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(3, ErrorMessage = "{0} {1} 3 karakterden az olamaz.")]

        public string? Name { get; set; }

        [DisplayName("Kategori Açıklaması"), MaxLength(500, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(3, ErrorMessage = "{0} {1} 3 karakterden az olamaz.")]
        public string? Description { get; set; }

        [DisplayName("Kategori Özel Not Alanı"), MaxLength(500, ErrorMessage = "{0} {1} karakterden uzun olamaz."), MinLength(3, ErrorMessage = "{0} {1} 3 karakterden az olamaz.")]
        public string? Note { get; set; }

        [DisplayName("Aktif mi?"), Required(ErrorMessage = "{0} boş bırakılamaz.")]
        public bool IsActive { get; set; }

        [DisplayName("Silindi mi?"), Required(ErrorMessage = "{0} boş bırakılamaz.")]
        public bool IsDeleted { get; set; }
    }
}
