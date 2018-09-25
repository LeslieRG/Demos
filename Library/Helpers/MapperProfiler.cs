using AutoMapper;
using Library.DTOs;
using Library.Models;

namespace Library.Helpers{


    public class MapperProfile: Profile{

        public MapperProfile(){

                CreateMap<Author, AuthorDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.AuthorName))       
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.AuthorEmail))   
                .ForMember(dest => dest.Last_Name, opt => opt.MapFrom(src => src.AuthorLastName));
             

            CreateMap<Book, BookDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id_Book));
                
        }
    }
}