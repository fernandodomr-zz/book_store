using AutoMapper;
using BookStore.Domain.Entities;
using BookStore.MVC.ViewModels;

namespace BookStore.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<BookViewModel, Book>();
        }
    }
}