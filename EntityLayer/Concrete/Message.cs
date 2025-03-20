using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string SenderMail { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string ReceiverMail { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }

    }
}
