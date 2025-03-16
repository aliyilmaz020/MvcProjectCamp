using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("Kategori Adı")]
        [DataType("varchar")]
        [StringLength(20)]
        public string CategoryName { get; set; }
        [Required]
        [DisplayName("Kategori Adı")]
        [DataType("varchar")]
        [StringLength(500)]
        public string CategoryDescription { get; set; }
        [Required]
        [DisplayName("Durum")]
        public bool CategoryStatus { get; set; }

        public virtual ICollection<Heading> Headings { get; set; }
    }
}
