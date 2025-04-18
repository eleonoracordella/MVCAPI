using Microsoft.EntityFrameworkCore;
using MVCAPI.Models.Entites;


namespace MVCAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //costruttore(ctor e spazio): popolato dall'applicativo sulla base di ciò che utilizziamo
        //specifico lista di opzioni che andrò ad utilizzare --> le opzioni di cosa? della classe base
        {


        }
        public DbSet<Facolta> Facolta { get; set; }

        public DbSet<Studente> Studenti { get; set; }
    }
}
