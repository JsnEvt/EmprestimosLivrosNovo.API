using AutoMapper;
using EmprestimosLivros.API.DTOs;
using EmprestimosLivros.API.Models;

namespace EmprestimosLivros.API.Mappings
{
    public class EntitiesToDTOMappingProfile : Profile
    {
        public EntitiesToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
