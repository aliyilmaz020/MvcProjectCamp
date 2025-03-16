using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [Required]
        [DisplayName("Adı")]
        [DataType("varchar")]
        [StringLength(20)]
        public string WriterName { get; set; }
        [Required]
        [DisplayName("Soyadı")]
        [DataType("varchar")]
        [StringLength(20)]
        public string WriterSurname { get; set; }
        [Required]
        [DisplayName("Görsel")]
        [DataType("varchar")]
        [StringLength(300)]
        public string WriterImage { get; set; }
        [Required]
        [DisplayName("E-Posta")]
        [EmailAddress(ErrorMessage = "E-Posta adresinizi doğru biçimde giriniz")]
        [DataType("varchar")]
        [StringLength(100)]
        public string WriterMail { get; set; }
        [Required]
        [DisplayName("Şifre")]
        [DataType("varchar")]
        [StringLength(20)]
        public string WriterPassword { get; set; }

        public virtual ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
