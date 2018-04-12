using AutoMapper;
using HanaShop.Model.Models;
using HanaShop.Web.Models;

namespace HanaShop.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>()
                .ForMember(p => p.Post, opt => opt.MapFrom(s => s.Post))
                .ReverseMap();
                cfg.CreateMap<PostTag, PostTagViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
                //cfg.CreateMap<Customer, RegisterViewModel>();
            });

        }
    }
}