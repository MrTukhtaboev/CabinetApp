using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cabinet.Backend.Models
{
    [Table("car")]
    public class Car
    {
        [Required]
        [Column("id")]
        public int ID { get; set; }
        
        [Required]
        [Column("name")]
        public string Name { get; set; }
        
        [Required]
        [Column("number")]
        public int Number { get; set; }
        
        [Required]
        [Column("color")]
        public string Color { get; set; }
    }
}