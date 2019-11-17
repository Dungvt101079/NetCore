using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiTap.Models;
using BaiTap.ViewModels;
using AutoMapper;

namespace BaiTap.MapperProfile
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<TeaOrder, TeaOrderViewModel>();
            CreateMap<TeaOrderViewModel, TeaOrder>();
        }
    }
}

