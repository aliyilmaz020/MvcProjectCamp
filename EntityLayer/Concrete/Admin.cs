using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string AdminUserName { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string AdminPassword { get; set; }
        [Required]
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string AdminRole { get; set; }
    }
}
