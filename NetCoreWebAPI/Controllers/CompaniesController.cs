using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebAPI.Services;

namespace NetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public class CompaniesController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService ?? throw new ArgumentException(nameof(companyService));
        }

        [HttpGet(nameof(GetCompanies))]
        public async Task<ActionResult> GetCompanies()
        {
            var companies = await _companyService.GetCompanyAsync(Guid.Parse("6fb600c1-9011-4fd7-9234-881379716440"));
            return Ok(companies);
        }
    }
}