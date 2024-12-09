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
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Livro, LivroDTO>().ReverseMap();
            CreateMap<Emprestimo, EmprestimoDTO>().ReverseMap()
            //na classe Emprestimo tem dois atributos que precisam ser mapeados aqui:
            //Cliente -> ClienteDTO / Livros -> LivrosDTO:
                .ForMember(dest => dest.Livro, opt => opt.MapFrom(x => x.LivroDTO))
                .ForMember(dest => dest.Cliente, opt => opt.MapFrom(x => x.ClienteDTO));


        }
    }
}
