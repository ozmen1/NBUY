using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; //virtual daha sonra bunun override yapılabilmesini sağlar.
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual string CreatedByName { get; set; } //üye olmadan yorum yapılmasını sağlamak için.
        public virtual string ModifiedByName { get; set; }
        public bool IsDeleted { get; set; } = false; //ilk oluşturulduğunda alacağı değeri atadık.
        public bool IsActive { get; set; } = true; //ilk oluşturulduğunda alacağı değeri atadık.

    }
}
