using AutoMapper;
using Puhoi.DataModels;
using Puhoi.Models.Models;

namespace PuhoiAPI
{
    public class AutoMapperProfileConfiguration : Profile
    {
        protected override void Configure()
        {
            CreateMap<StoreDto, StoreModel>().
                ForSourceMember("StoreId", s => s.Ignore()).
                ForSourceMember("UId", s => s.Ignore()).
                ForMember("Id", s => s.Ignore()).
                AfterMap((dto, model) => model.Id = dto.UId);

            CreateMap<StoreModel, StoreDto>()
                //ForMember("UId", s => s.Ignore()).
                .AfterMap((model, dto) => dto.UId = model.Id);
        }


    }
}
