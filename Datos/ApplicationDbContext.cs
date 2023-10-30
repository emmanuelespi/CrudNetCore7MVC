using CrudNet7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet7MVC.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        //Debemos agregar los modelos
        public DbSet<Contacto> Contacto { get; set; }
    }
}
