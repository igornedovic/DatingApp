using System.Linq;
using AutoMapper;
using DatingAppNew.DTOs;
using DatingAppNew.Entities;
using DatingAppNew.Extensions;

namespace DatingAppNew.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // mapira objekat klase AppUser sa objektom klase MemberDto
            CreateMap<AppUser, MemberDto>() // mapiramo konkretan property sa ForMember
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                   src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src =>
                   src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>(); // mapira objekat klase Photo sa objektom klase PhotoDto
            CreateMap<MemberUpdateDto, AppUser>(); // mapira objekat klase MemberUpdateDto sa objektom klase 
            CreateMap<RegisterDto, AppUser>(); // mapira objekat klase RegisterDto sa objketom klase AppUser
        }
    }
}