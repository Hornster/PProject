using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model.Implementation;

namespace DB.Services.Interfaces
{
    public interface ICompanyService
    {
        List<CompanyModel> GetAllCompanies();

        CompanyModel GetSingleCompany(int? companyId);

        CompanyModel GetSingleCompany(string nip);

        void AddOrEditResident(CompanyModel newCompany);

        void RemoveResident(int companyId);
    }
}
