using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web.Controllers.resources;
using web.Models;

namespace web.Controllers
{
   // [EnableCors]
[Route("api/[controller]")]
[EnableCors("AllowSpecificOrigin")]
public class ValuesController : Controller {
     private readonly VegaDbContext context;
    private readonly IMapper mapper;
    public ValuesController(VegaDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }
        [HttpGet]
    public async Task<IEnumerable<productResource>> Get()
    {
        var makes = await context.product.ToListAsync();

        return mapper.Map<List<product>, List<productResource>>(makes);
    }
}
}