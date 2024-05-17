using Api_Face.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Api_Face
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }

        //creacion de tablas
        public DbSet<ROSTRO> ROSTROS { get; set; }


        public DbSet<PERSONA> PERSONAS { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ROSTRO>().HasNoKey();
            modelBuilder.Entity<PERSONA>().HasKey(a => a.ID);
        }

    }
}
