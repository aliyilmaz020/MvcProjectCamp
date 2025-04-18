﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [Required]
        [DisplayName("İçerik Metni")]
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string ContentText { get; set; }
        [Required]
        [DisplayName("Tarih")]
        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }

        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
