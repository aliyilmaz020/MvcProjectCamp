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
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        [DisplayName("Başlık Adı")]
        [Column(TypeName = "Varchar")]
        public string HeadingName { get; set; }
        [Required]
        [DisplayName("Tarih")]
        public DateTime HeadingDate { get; set; }

        [DisplayName("Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        [DisplayName("Yazar")]
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
       
    }
}
