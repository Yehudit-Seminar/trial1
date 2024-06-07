using AutoMapper;
using ex1.Models.DTO;

namespace ex1.Models
{
    public class DIProfile : Profile
    {
        public DIProfile()
        {
            CreateMap<ProductDto, Products>()
                    .ForMember(p => p.Id, i => i.MapFrom(o => 7));
        }
    }
}

