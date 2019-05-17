using AutoMapper;
using Domain;
using WebApplicationMvc.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDetailViewModel>();
        CreateMap<AddressBook, AddressBookDetailViewModel>();
        CreateMap<Contact, ContactDetailViewModel>();
    }
}
