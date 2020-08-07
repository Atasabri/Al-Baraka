using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALBaraka.Models
{
    [Table("Services")]
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Name (English)")]
        public string Name_EN { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Description (English)")]
        public string Description_EN { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Service_Analyzes> Service_Analyzes { get; set; }
    }
}
