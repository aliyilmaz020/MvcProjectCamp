using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [Required]
        [DisplayName("Detay 1")]
        [DataType("varchar")]
        [StringLength(1000)]
        public string AboutDetails1 { get; set; }
        [Required]
        [DisplayName("Detay 2")]
        [DataType("varchar")]
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [Required]
        [DisplayName("Görsel 1")]
        [DataType("varchar")]
        [StringLength(200)]
        public string AboutImage1 { get; set; }
        [Required]
        [DisplayName("Görsel 2")]
        [DataType("varchar")]
        [StringLength(200)]
        public string AboutImage2 { get; set; }
    }
}
