using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [DataType("varchar")]
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        [DisplayName("E-Posta Adresi")]
        [DataType("varchar")]
        [StringLength(100)]
        public string UserMail { get; set; }
        [Required]
        [DisplayName("Konu")]
        [DataType("varchar")]
        [StringLength(100)]
        public string Subject { get; set; }
        [Required]
        [DisplayName("Mesaj")]
        [DataType("varchar")]
        [StringLength(1000)]
        public string Message { get; set; }
    }
}
