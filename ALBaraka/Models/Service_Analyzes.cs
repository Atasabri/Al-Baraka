using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALBaraka.Models
{
    public class Service_Analyzes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name="Name (English)")]
        public string Name_EN { get; set; }

        [Required]
        public int Service_ID { get; set; }

        [ForeignKey("Service_ID")]
        public Service Service { get; set; }
    }
}
