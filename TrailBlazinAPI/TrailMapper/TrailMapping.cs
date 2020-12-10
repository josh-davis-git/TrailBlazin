using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailBlazinAPI.Models;
using TrailBlazinAPI.Models.Dtos;

namespace TrailBlazinAPI.TrailMapper
{
    public class TrailMapping : Profile
    {
        public TrailMapping()
        {

            CreateMap<NationalPark, NationalParkDto>().ReverseMap();
            CreateMap<Trail, TrailDto>().ReverseMap();
            CreateMap<Trail, TrailCreateDto>().ReverseMap();
            CreateMap<Trail, TrailUpdateDto>().ReverseMap();
        }
    }
}
