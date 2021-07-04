using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cabinet.Backend.Models
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        [Required]
        public int ID { get; set; }
        
        [Column("firstname")]
        public string FirstName { get; set; }
        
        [Column("lastname")]
        public string LastName { get; set; }
        
        [Column("username")]
        public string Username { get; set; }
        
        [Column("phone")]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}