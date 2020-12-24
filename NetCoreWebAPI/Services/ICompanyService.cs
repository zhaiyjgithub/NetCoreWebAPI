using System;
using System.Threading.Tasks;
using NetCoreWebAPI.Entities;

namespace NetCoreWebAPI.Services
{
    public interface ICompanyService
    {
        Task<Company> GetCompanyAsync(Guid companyId);
    }
}