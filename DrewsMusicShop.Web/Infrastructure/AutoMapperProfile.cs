﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrewsMusicShop.Entity;
using AutoMapper;
using DrewsMusicShop.Models;

namespace DrewsMusicShop.Infrastructure
{
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<Guitar, GuitarViewModel>();

                CreateMap<GuitarViewModel, Guitar>();
            }
        }
    
}