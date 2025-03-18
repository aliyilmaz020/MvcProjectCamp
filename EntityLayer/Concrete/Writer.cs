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
        [DisplayName("Adı")]
        [Column(TypeName = "Varchar")]
        public string WriterName { get; set; }
        [DisplayName("Soyadı")]
        [Column(TypeName = "Varchar")]
        public string WriterSurname { get; set; }
        [DisplayName("Görsel")]
        [Column(TypeName = "Varchar")]
        public string WriterImage { get; set; }
        [DisplayName("E-Posta")]
        [Column(TypeName = "Varchar")]
        public string WriterMail { get; set; }
        [DisplayName("Şifre")]
        [Column(TypeName = "Varchar")]
        public string WriterPassword { get; set; }

        [DisplayName("Hakkımda")]
        [Column(TypeName = "varchar")]
        public string WriterAbout { get; set; }

        [DisplayName("Unvan")]
        [Column(TypeName = "varchar")]
        public string WriterTitle { get; set; }
        public virtual ICollection<Heading> Headings { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
    }
}
