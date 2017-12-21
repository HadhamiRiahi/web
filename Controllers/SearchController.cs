using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web.Controllers.resources;
using web.Models;

namespace web.Controllers

{
  [Route("api/[controller]")]
  [EnableCors("AllowSpecificOrigin")]
  public class SearchController : Controller
     {
private readonly VegaDbContext context;      
    public SearchController(VegaDbContext context)
    {
      
      this.context = context;
    }
     [HttpGet]
     [Route("/api/search/{searchString}")]
      [EnableCors("AllowSpecificOrigin")]
     public IEnumerable<product> searchProduct(string searchString)
    {
   var searchProducts= context.product.Where(s => s.Id.Contains(searchString) ||
      s.Description.Contains(searchString)|| s.ProductName.Contains(searchString)||
       s.Price.Contains(searchString)||
       s.Type.Contains(searchString)).ToList();
       return searchProducts ;
       
       
 
        
    }

}
}