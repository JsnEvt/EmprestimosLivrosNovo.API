using AutoMapper;
using EmprestimosLivrosNovo.Application.DTOs;
using EmprestimosLivrosNovo.Domain.Entities;


namespace EmprestimosLivrosNovo.Application.Mappings
{
    public class EntitiesToDTOMappingProfile : Profile
    {
        public EntitiesToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
<<<<<<< HEAD
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
=======
>>>>>>> dcda9d8e1ddfadb10d94a93e13fc0e9791649612
        }
    }
}
