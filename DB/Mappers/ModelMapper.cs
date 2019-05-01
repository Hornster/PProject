using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DB.Model;
using DB.Model.Implementation;

namespace DB.Mappers
{
    public static class ModelMapper
    {
        public static IMapper Mapper { get; } = new MapperConfiguration(cfg =>
        {
            //Residents
            cfg.CreateMap<Najemcy, ResidentModel>()
                .ForSourceMember(src=>src.Wynajmy, src=>src.DoNotValidate());
            cfg.CreateMap<ResidentModel, Najemcy>()
                .ForMember(dest=>dest.Wynajmy, dest => dest.Ignore());

            //Residences, buildings
            cfg.CreateMap<Budynki, BuildingModel>()
                .ForSourceMember(src=>src.Mieszkania, src=>src.DoNotValidate());
            cfg.CreateMap<BuildingModel, Budynki>()
                .ForMember(dest => dest.Mieszkania, dest => dest.Ignore());
            cfg.CreateMap<Mieszkania, ResidenceModel>()
                .ForSourceMember(src=>src.Wynajmy, src=>src.DoNotValidate())
                .ForSourceMember(src=>src.Usterki, src=> src.DoNotValidate());
            cfg.CreateMap<ResidenceModel, Mieszkania>()
                .ForMember(dest=>dest.Wynajmy, dest=>dest.Ignore())
                .ForMember(dest=>dest.Usterki, dest=>dest.Ignore());

            //Repairs
            cfg.CreateMap<Naprawy, RepairModel>()
                .ForSourceMember(src=>src.FakturyNapraw, src=>src.DoNotValidate())
                .ForSourceMember(src=>src.FakturyNapraw, src=>src.DoNotValidate())
                .ForSourceMember(src=>src.Firmy, src=>src.DoNotValidate())
                .ForSourceMember(src=>src.StanyNapraw, src=>src.DoNotValidate());
            cfg.CreateMap<RepairModel, Naprawy>()
                .ForMember(dest => dest.FakturyNapraw, dest => dest.Ignore())
                .ForMember(dest => dest.FakturyNapraw, dest => dest.Ignore())
                .ForMember(dest => dest.Firmy, dest => dest.Ignore())
                .ForMember(dest => dest.StanyNapraw, dest => dest.Ignore());

            //Rentals
            cfg.CreateMap<StrictRentalDataModel, Wynajmy>()
                .ForMember(dest => dest.FakturyWynajem, dest => dest.Ignore())
                .ForMember(dest => dest.Mieszkania, dest => dest.Ignore())
                .ForMember(dest => dest.Najemcy, dest => dest.Ignore())
                .ForMember(dest => dest.Platnosci, dest => dest.Ignore());
            cfg.CreateMap<Wynajmy, StrictRentalDataModel>()
                .ForSourceMember(src => src.FakturyWynajem, src => src.DoNotValidate())
                .ForSourceMember(src => src.Mieszkania, src => src.DoNotValidate())
                .ForSourceMember(src => src.Najemcy, src => src.DoNotValidate())
                .ForSourceMember(src => src.Platnosci, src => src.DoNotValidate());

            //Payments
            cfg.CreateMap<PaymentModel, Platnosci>()
                .ForMember(dest => dest.Wynajmy, dest => dest.Ignore());
            cfg.CreateMap<Platnosci, PaymentModel>()
                .ForSourceMember(src => src.Wynajmy, src => src.DoNotValidate());

            //Payment Bills
            cfg.CreateMap<PaymentBillModel, FakturyWynajem>()
                .ForMember(dest => dest.Wynajmy, dest => dest.Ignore());
            cfg.CreateMap<FakturyWynajem, PaymentBillModel>()
                .ForSourceMember(src => src.Wynajmy, src => src.DoNotValidate());
        }).CreateMapper();

    }
}
