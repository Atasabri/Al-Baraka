using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALBaraka.Models
{
    [Table("Branchs")]
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Name (English)")]
        public string Name_EN { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }
        public string Map { get; set; }
    }
}
