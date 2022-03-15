using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurakBlog.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; // bunu ilerde override edebilmek icin virtual yaptim yani mesela; override CreatedDate = new DateTime(2022/05/05);
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string? CreatedByName { get; set; } = "Admin"; //Default deger vermek istedigimden Admin yazdim. Bunlari olusturan admin degilse ordaki kullanicinin adi gelecek ilerde.
        public virtual string? ModifiedByName { get; set; } = "Admin";
        public virtual string? Note { get; set; }
    }
}
