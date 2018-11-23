
using AutoMapper;
using Domain;
using Service.ViewModel;

namespace Service.Middleware
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<Domain.User, LoginViewModel>();
            CreateMap<LoginViewModel, Domain.User>();
        }
    }
}
