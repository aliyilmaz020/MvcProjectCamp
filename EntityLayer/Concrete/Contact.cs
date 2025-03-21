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
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        [DisplayName("E-Posta Adresi")]
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string UserMail { get; set; }
        [Required]
        [DisplayName("Konu")]
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Subject { get; set; }
        [Required]
        [DisplayName("Mesaj")]
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string Message { get; set; }
        [DisplayName("Tarih")]
        public DateTime ContactDate { get; set; }
    }
}
