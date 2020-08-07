using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ALBaraka.Models
{
    public class StaticData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Key { get; set; }
        public string Value { get; set; }
        public string Value_EN { get; set; }
        [Required]
        public int Type { get; set; }
        public string Description { get; set; }
        [Required]
        public bool HasEnglish { get; set; }
    }

    public enum Types
    {
        Image = 1,
        Icon =2,
        TextArea = 3,
        Text=4
    }
}
