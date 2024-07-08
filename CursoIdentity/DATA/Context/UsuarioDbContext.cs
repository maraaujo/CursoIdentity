using CursoIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CursoIdentity.DATA.Context
{
    public class UsuarioDbContext : IdentityDbContext<Usuario>
    {
        //cobstrutor que recebe DbContextOptions. O DbCotextOptions, por sua vez, será do nosso UsuarioDbContext
        //que chamei de opts
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> opts)
            : base(opts)
        {
            
        }

     
 
        
    }
}
