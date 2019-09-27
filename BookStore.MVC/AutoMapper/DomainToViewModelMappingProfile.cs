using AutoMapper;
using BookStore.Domain.Entities;
using BookStore.MVC.ViewModels;

namespace BookStore.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Book, BookViewModel>();
        }
    }
}