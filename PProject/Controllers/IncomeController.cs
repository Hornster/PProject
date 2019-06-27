using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DB.Common.Enums;
using DB.Model.Interfaces;
using DB.Services.Interfaces;
using PProject.App_Start;
using PProject.Mapper;
using PProject.Models;

namespace PProject.Controllers
{
    [Authorize]
    public class IncomeController : Controller
    {
        #region Members
        private readonly IIncomeService service;

        #endregion Members

        #region Ctor
        public IncomeController(IIncomeService service)
        {
            this.service = service;
        }
        #endregion Ctor

        #region ActionMethods
        [AuthorizeRole(AvailableRoles.Overseer, AvailableRoles.Treasurer, AvailableRoles.Administrator)]
        public ActionResult Index(IncomeListViewModel viewModel)
        {
            if (viewModel == null)
            {
                viewModel = new IncomeListViewModel();
            }

            viewModel.Items = new List<IIncomeData>();
            //Retrieve all residents.

            var result = service.GetIncomeForBuildings(null, viewModel.StartDate, viewModel.EndDate);

            result.ToList().ForEach(u => viewModel.Items.Add(ViewModelMapper.Mapper.Map<IIncomeData>(u)));

            return View(viewModel);
        }
        #endregion  
    }
}