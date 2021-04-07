using AutoMapper;
using DOLPHIN.DTO;
using DOLPHIN.Model;
using System;

namespace DOLPHIN.Mapping
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            this.CreateMap<CanBo, CategoriesDto>();
            this.CreateMap<CategoriesDto, CanBo>();
            this.CreateMap<UsersDto, ToTrinh>();
            this.CreateMap<ToTrinh, UsersDto>();
        }
    }
}
