using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class Achat
    {
          [Required]
        [StringLength(255)]
    public string Id { get; set; } 
    
    [Required]
    [StringLength(255)]
    public string ProductName { get; set; } 
    
    
    [Required]
    [StringLength(255)]
    public string Price { get; set; } 
    
   
    }
}