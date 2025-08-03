using AutoMapper;
using E_Commerce.Core.DTOs;
using E_Commerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Mappers
{
   public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserAuthentificationResponse>()
                .ForMember(dest => dest.UsereID, opt => opt.MapFrom(src => src.UserID))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.PersonName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.Success, opt => opt.Ignore())
                .ForMember(dest => dest.Token, opt => opt.Ignore());
        }
    }
}
