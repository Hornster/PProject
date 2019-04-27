using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DB.Model;
using DB.Model.Implementation;
using PProject.Models;
using PProject.Models.Repairs;
using PProject.Models.Residences;
using PProject.Models.Residents;

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
            }).CreateMapper();

    }
}