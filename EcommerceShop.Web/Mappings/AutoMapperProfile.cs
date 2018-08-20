using AutoMapper;
using EcommerceShop.Model.Models;
using EcommerceShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceShop.Web.Mappings
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<Tag, TagViewModel>();
        }
    }
}