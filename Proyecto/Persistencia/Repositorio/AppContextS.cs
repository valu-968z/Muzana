using Microsoft.EntityFrameworkCore;
using Proyecto.Dominio;

namespace Proyecto.Persistencia
{
    public class AppContextS : DbContext
    {
        //Es un objeto que le pertenece al context que me permite modelar la base de datos.

        //<establecimiento> Es el nombre de la tabla que se encuentra en dominio.
        //Establecimientos= Es el nombre que va a tener la tabla en la base de datos.

        public DbSet<Establecimientos> Establecimientos {get;set;}
        public DbSet<Manzanas> Manzanas{get;set;}
        public DbSet<UsuarioMujeres> UsuarioMujeres {get;set;}
        public DbSet<Municipios> Municipios {get;set;}
        public DbSet<Cuidadora> Cuidadoras {get;set;}
        public DbSet<Servicios> Servicios {get;set;}
        public DbSet<Personas> Personas {get; set;}

    // El void es un metodo vacío que sirve para la conexion a la base de datos.
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=Muzana");
            }

        }

    }

}