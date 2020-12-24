using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreWebAPI.Data;
using SQLitePCL;

namespace NetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/doctor")]
    public class DoctorController : Controller
    {
        private readonly MainDbContext _context;
        public DoctorController(MainDbContext context)
        {
            _context = context;
        }
        
        [HttpGet(nameof(GetDoctor))]
        public async Task<IActionResult> GetDoctor()
        {
            var doctor = await _context.Clinicals.FirstOrDefaultAsync();
            return Ok(doctor);
        }
    }
}