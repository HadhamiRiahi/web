using System ;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.Models
{
    [Table("user")]
    public class  UserDetails 
    {
        [Required]
        [StringLength(255)]

        public string Id { get; set; } 
        [Required]
        [StringLength(255)]
        public string Name { get; set; } 
        
        [Required]
        [StringLength(255)]
        public string Email { get; set; } 
        

        [Required]
        [StringLength(255)]
        public string NumTelephone { get; set; } 
    
        
    }
}