using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Bu alanın girilmesi zorunludur")]
        [DisplayName("Kategori Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(20,ErrorMessage ="En Fazla 20 Karakter Giriniz")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Bu alanın girilmesi zorunludur")]
        [DisplayName("Açıklama")]
        [Column(TypeName = "Varchar")]
        [StringLength(500, ErrorMessage = "En Fazla 500 Karakter Giriniz")]
        public string CategoryDescription { get; set; }
        [DisplayName("Durum")]
        public bool? CategoryStatus { get; set; }

        public virtual ICollection<Heading> Headings { get; set; }
    }
}
