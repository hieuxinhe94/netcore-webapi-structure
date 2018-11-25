
using AutoMapper;
using Domains;
using Service.ViewModel;

namespace Service.Middleware
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<User, LoginViewModel>();
            CreateMap<LoginViewModel, User>();
        }
    }
}
