using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
namespace CursoIdentity.DATA.DataTransferObject
{
    public class UsuarioDTO
    {

        //utilizei a annotation de Required do DataAnnotations, para o campo ser obrigatório 
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        //É poreciso explicar que essa propriedade deve ser tratada como senha.
        //Para isso, depois de required, coloquei a anotação DataType() seguido do tipo data para a senha,DateType.Password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
    }
 }
