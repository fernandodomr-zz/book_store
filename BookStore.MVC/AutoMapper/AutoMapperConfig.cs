using AutoMapper;

namespace BookStore.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }

        //public MapperConfiguration Configure()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.AddProfile<ViewModelToDomainMappingProfile>();
        //        cfg.AddProfile<DomainToViewModelMappingProfile>();
        //    });

        //    return config;
        //}
    }
}