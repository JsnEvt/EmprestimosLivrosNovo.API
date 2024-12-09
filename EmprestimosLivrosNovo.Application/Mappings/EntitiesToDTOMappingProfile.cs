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
            CreateMap<EmprestimoDTO, Emprestimo>().ReverseMap()
            //na classe Emprestimo tem dois atributos que precisam ser mapeados aqui:
            //Cliente -> ClienteDTO / Livros -> LivrosDTO:
                .ForMember(dest => dest.LivroDTO, opt => opt.MapFrom(x => x.Livro))
                .ForMember(dest => dest.ClienteDTO, opt => opt.MapFrom(x => x.Cliente));
            CreateMap<Emprestimo, EmprestimoPOSTDTO>().ReverseMap();
            CreateMap<Emprestimo, EmprestimoPUTDTO>().ReverseMap();

        }
    }
}
