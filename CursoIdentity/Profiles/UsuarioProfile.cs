using AutoMapper;
using CursoIdentity.DATA.DataTransferObject;
using CursoIdentity.Models;
namespace CursoIdentity.Model
{
    public class UsuarioProfile : Profile 
    {
        //Ultilizei o AutoMapper para fazer a conversão da DTO para um modelo. 
        public UsuarioProfile()
        {
            CreateMap<UsuarioDTO, Usuario>(); 
        }
    }
}
