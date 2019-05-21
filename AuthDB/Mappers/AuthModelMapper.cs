using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthDB.Model.Implementation;
using AutoMapper;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthDB.Mappers
{
    public static class AuthModelMapper
    {
        public static IMapper Mapper { get; } = new MapperConfiguration(cfg =>
        {
            //Users
            cfg.CreateMap<ApplicationUser, UserModel>()
                .ForSourceMember(src => src.Roles, src => src.DoNotValidate())
                .ForSourceMember(src => src.Claims, src => src.DoNotValidate())
                .ForSourceMember(src => src.Logins, src => src.DoNotValidate());
            cfg.CreateMap<UserModel, ApplicationUser>()
                .ForMember(dest => dest.Roles, dest => dest.Ignore())
                .ForMember(dest => dest.Claims, dest => dest.Ignore())
                .ForMember(dest => dest.Logins, dest => dest.Ignore());

            //Assignment of roles
            cfg.CreateMap<IdentityRole, RoleModel>()
                .ForSourceMember(src => src.Users, src => src.DoNotValidate());
            cfg.CreateMap<RoleModel, IdentityRole>()
                .ForMember(dest => dest.Users, dest => dest.Ignore());

        }).CreateMapper();
    }
}
