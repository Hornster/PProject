using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Mappers;
using DB.Model.Implementation;
using DB.Model.Interfaces;
using DB.Services.Interfaces;

namespace DB.Services.Implementation
{
    public class CompanyService : ICompanyService
    {
        public List<CompanyModel> GetAllCompanies()
        {
            var queryResult = new List<CompanyModel>();
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var companies = ctx.Firmy.Select(x => x).AsQueryable();

                    foreach (var company in companies)
                    {
                        queryResult.Add(ModelMapper.Mapper.Map<CompanyModel>(company));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public CompanyModel GetSingleCompany(int? companyId)
        {
            CompanyModel queryResult = null;
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var company = ctx.Firmy.Find(companyId);
                    if (company != null)
                    {
                        queryResult = ModelMapper.Mapper.Map<CompanyModel>(company);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public CompanyModel GetSingleCompany(string nip)
        {
            CompanyModel queryResult = null;
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var resident = ctx.Firmy.FirstOrDefault(x => x.NIP == nip);

                    queryResult = ModelMapper.Mapper.Map<CompanyModel>(resident);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return queryResult;
        }

        public void AddOrEditCompany(CompanyModel newCompany)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var company = ctx.Firmy.Find(newCompany.id_firmy);

                    if (company == null)
                    {
                        company = ModelMapper.Mapper.Map<Firmy>(newCompany);
                        ctx.Firmy.Add(company);
                    }
                    else
                    {
                        company.NIP = newCompany.NIP;
                        company.id_firmy = newCompany.id_firmy;
                        company.nr_telefonu = newCompany.nr_telefonu;
                        company.nazwa_firmy = newCompany.nazwa_firmy;
                    }

                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoveCompany(int companyId)
        {
            try
            {
                using (var ctx = new DBProjectEntities())
                {
                    var result = ctx.Firmy.Find(companyId);
                    if (result != null)
                    {
                        ctx.Firmy.Remove(result);
                    }

                    ctx.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while processing your request.");
            }
        }
    }
}
