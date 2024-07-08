
using System.Threading.Tasks;
using CursoIdentity.DATA.DataTransferObject;
using CursoIdentity.Services;
using Microsoft.AspNetCore.Mvc;


namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {

        private CadastroService _cadastroService;

        public UsuarioController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }


        [HttpPost("Cadastrar")]
        public async Task<IActionResult> CadastraUsuario
            (UsuarioDTO dto)
        {
            await _cadastroService.CadastraUsuario(dto);
            return Ok("Usuário cadastrado!");

        }
    }
}