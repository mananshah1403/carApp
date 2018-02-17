using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using carApp.Controllers.Resources;
using carApp.Models;
using carApp.persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carApp.Controllers
{
    public class MakesController : Controller
    {
        private readonly CarDbContext context;
        private readonly IMapper mapper;
        public MakesController(CarDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}