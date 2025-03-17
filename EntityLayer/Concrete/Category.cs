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
        
        [DisplayName("Kategori Adı")]
        [StringLength(20)]
        [Column(TypeName = "Varchar")]
        public string CategoryName { get; set; }
        [DisplayName("Açıklama")]
        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string CategoryDescription { get; set; }
        [DisplayName("Durum")]
        public bool? CategoryStatus { get; set; }

        public virtual ICollection<Heading> Headings { get; set; }
    }
}
