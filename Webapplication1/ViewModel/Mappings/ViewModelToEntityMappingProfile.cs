using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapplication1.Models.Entities;
using AutoMapper;

namespace Webapplication1.ViewModel.Mappings
{
    public class ViewModelToEntityMappingProfile: Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
