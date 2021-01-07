using my_vue_starter_new.Models.Entities;
using AutoMapper;

namespace my_vue_starter_new.ViewModel.Mappings 
{
    public class ViewModelToEntityMapping : Profile 
    {
        public ViewModelToEntityMapping() 
        {
            CreateMap<RegistrationViewModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }

    }
}