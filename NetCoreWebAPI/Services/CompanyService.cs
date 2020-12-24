using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreWebAPI.Data;
using NetCoreWebAPI.Entities;
using SQLitePCL;

namespace NetCoreWebAPI.Services
{
    
    public class CompanyService : ICompanyService
    {
        private readonly MasterDbContext _context;
        public CompanyService(MasterDbContext context )
        {
            _context = context;
        }
        public async Task<Company> GetCompanyAsync(Guid companyId)
        {
            if (companyId == Guid.Empty)
            {
                throw new ArgumentException(nameof(companyId));
            }

            return await _context.Companies.FirstOrDefaultAsync(x => x.Id == companyId);
        }
    }
}