
using AutoMapper;
using CursoIdentity.DATA.DataTransferObject;
using CursoIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace CursoIdentity.Services
{
    public class CadastroService
    {
        private IMapper _mapper; 
        private UserManager<Usuario> _userManager;


        public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task CadastraUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDTO);

            IdentityResult result = await _userManager.CreateAsync(usuario, usuarioDTO.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuario");
            }
        }
    }
}
