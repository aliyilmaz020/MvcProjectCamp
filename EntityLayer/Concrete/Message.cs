using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

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
        [AllowHtml]
        public string MessageContent { get; set; }
        [Required]
        public bool MessageIsRead { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageIsDelete { get; set; }
        public bool MessageIsDeleteSent { get; set; }

    }
}
