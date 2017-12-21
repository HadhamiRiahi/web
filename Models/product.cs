using System ;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.Models
{
     [Table("product")]
    public class product
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
    
    [Required]
    
    public string Description { get; set; } 
    
    [Required]
    
    public string ImageUrl { get; set; } 

     [Required]
    [StringLength(255)]
     public string Type { get; set; } 

    }
}