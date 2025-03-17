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
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [Required]
        [DisplayName("Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string WriterName { get; set; }
        [Required]
        [DisplayName("Soyadı")]
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string WriterSurname { get; set; }
        [Required]
        [DisplayName("Görsel")]
        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string WriterImage { get; set; }
        [Required]
        [DisplayName("E-Posta")]
        [EmailAddress(ErrorMessage = "E-Posta adresinizi doğru biçimde giriniz")]
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string WriterMail { get; set; }
        [Required]
        [DisplayName("Şifre")]
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string WriterPassword { get; set; }

        public virtual ICollection<Heading> Headings { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
    }
}
