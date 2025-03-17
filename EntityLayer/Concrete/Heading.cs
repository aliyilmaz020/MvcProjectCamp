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
        [Required]
        [DisplayName("Başlık Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string HeadingName { get; set; }
        [Required]
        [DisplayName("Tarih")]
        public DateTime HeadingDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
       
    }
}
