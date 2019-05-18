using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthDB.Model.Implementation;
using AutoMapper;

namespace AuthDB.Mappers
{
    public static class AuthModelMapper
    {
        public static IMapper Mapper { get; } = new MapperConfiguration(cfg =>
        {
            //Users
            cfg.CreateMap<AspNetUsers, UserModel>()
                .ForSourceMember(src => src.AspNetRoles, src => src.DoNotValidate())
                .ForSourceMember(src => src.AspNetUserClaims, src => src.DoNotValidate())
                .ForSourceMember(src => src.AspNetUserLogins, src => src.DoNotValidate());
            cfg.CreateMap<UserModel, AspNetUsers>()
                .ForMember(dest => dest.AspNetRoles, dest => dest.Ignore())
                .ForMember(dest => dest.AspNetUserClaims, dest => dest.Ignore())
                .ForMember(dest => dest.AspNetUserLogins, dest => dest.Ignore());

            //Assignment of roles
            cfg.CreateMap<AspNetRoles, RoleModel>()
                .ForSourceMember(src => src.AspNetUsers, src => src.DoNotValidate());
            cfg.CreateMap<RoleModel, AspNetRoles>()
                .ForMember(dest => dest.AspNetUsers, dest => dest.Ignore());

        }).CreateMapper();
    }
}
