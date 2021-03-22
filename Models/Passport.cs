using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PassportApi.Models
{[Table("Passport")]
    public class Passport
    {
        [Key]
        public int PPId { get; set; }
        [Required]
        [Column(TypeName ="varchar(100)",Order=1)]
        public string PPHolderName { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)", Order = 2)]
        public string  PPNumber{ get; set; }
        [Required]
        [Column(TypeName = "varchar(5)", Order = 3)]
        public string  PPExpiry{ get; set; }
        [Required]
        [Column(TypeName = "varchar(6)", Order = 4)]
        public string  PPOcode{ get; set; }
     }
}
