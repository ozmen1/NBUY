using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(3, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalıdır.")]
        public string Name { get; set; }


        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(10, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalıdır.")]
        public string Description { get; set; }


        [DisplayName("Not")]
        [MaxLength(500, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalıdır.")]
        public string Note { get; set; }


        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsActive { get; set; }


        [DisplayName("Silinsin mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsDeleted { get; set; }
    }
}
