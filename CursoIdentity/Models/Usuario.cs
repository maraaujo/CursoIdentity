using Microsoft.AspNetCore.Identity;

namespace CursoIdentity.Models
{
    public class Usuario : IdentityUser
    {

        public Usuario() : base()
        {
            //agora é preciso indicar que, quando um usuario for instanciado, faremos a chamada do contrutor da superclasse desse usuário (IdentityUser)
        }
       //agora foi definido que o Usuario, além de ter todas as propriedades e possíveis métodos do IdentityUser, também possui a propriedade DataNascimento (um campo autoral) --> Uario que estende identityUser
        public  DateTime DataNascimento { get; set; }
       
    }

}
