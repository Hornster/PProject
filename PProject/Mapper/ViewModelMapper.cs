using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuthDB.Model.Implementation;
using AutoMapper;
using DB.Model;
using DB.Model.Implementation;
using PProject.Models;
using PProject.Models.PaymentBills;
using PProject.Models.Payments;
using PProject.Models.Repairs;
using PProject.Models.Residences;
using PProject.Models.Residents;
using PProject.Models.UserManagement;

namespace PProject.Mapper
{
    public static class ViewModelMapper
    {
        public static IMapper Mapper { get; } = new MapperConfiguration(cfg =>
            {
                //Residents table
                cfg.CreateMap<ResidentModel, ResidentViewModel>();
                cfg.CreateMap<ResidentViewModel, ResidentModel>();

                //Residences and buildings table
                cfg.CreateMap<BuildingModel, BuildingViewModel>();
                cfg.CreateMap<BuildingViewModel, BuildingModel>();

                //Repairs table
                cfg.CreateMap<RepairModel, RepairViewModel>();
                cfg.CreateMap<RepairViewModel, RepairModel>();

                //Payments
                cfg.CreateMap<PaymentModel, PaymentViewModel>();
                cfg.CreateMap<PaymentViewModel, PaymentModel>();

                //Payment Bills
                cfg.CreateMap<PaymentBillModel, PaymentBillViewModel>();
                cfg.CreateMap<PaymentBillViewModel, PaymentBillModel>();

                //UserManager
                cfg.CreateMap<UserViewModel, UserModel>();
                cfg.CreateMap<UserModel, UserViewModel>();
            }).CreateMapper();

    }
}