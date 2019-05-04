using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DB.Model.Implementation;
using DB.Services.Interfaces;
using PProject.Mapper;
using PProject.Models;
using PProject.Models.Companies;
using PProject.Models.Faults;

namespace PProject.Controllers
{
    public class CompaniesController : Controller
    {
        #region Members
        private readonly ICompanyService companyService;

        #endregion Members

        #region Ctor
        public CompaniesController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        #endregion Ctor

        public ActionResult Index()
        {
            var viewModel = new ListViewModel<CompanyViewModel>() { Items = new List<CompanyViewModel>() };

            var result = companyService.GetAllCompanies();

            result.ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<CompanyViewModel>(u)));

            return View(viewModel);
        }
        public ActionResult AddCompany()
        {
            var viewModel = new CompanyViewModel() { id_firmy = -1 };   //We are adding new company - id is not relevant now as the DB will generate it anyway.
            return View("EditCompany", viewModel);
        }

        public ActionResult EditCompany(int companyId)
        {
            var queryResult = companyService.GetSingleCompany(companyId);
            var viewModel = ViewModelMapper.Mapper.Map<CompanyViewModel>(queryResult);

            return View(viewModel);
        }

        public void DeleteCompany(int companyId)
        {
            companyService.RemoveCompany(companyId);
        }


        public void ConfirmCompanyEdit(int companyId,  string companyNip, string companyName,
            string companyPhone)
        {
            var company = new CompanyViewModel()
            {
                id_firmy = companyId,
                nazwa_firmy = companyName,
                NIP = companyNip,
                nr_telefonu = companyPhone
            };
            companyService.AddOrEditCompany(ViewModelMapper.Mapper.Map<CompanyModel>(company));
        }
    }
}