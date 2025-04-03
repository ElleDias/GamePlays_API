using Microsoft.EntityFrameworkCore;
using SystemGameAPI.Domains;

namespace SystemGameAPI.Context
{
    public class GamePlay_Context : DbContext
    {
        public GamePlay_Context()
        {
        }
        public GamePlay_Context(DbContextOptions<GamePlay_Context> options)
            : base(options)
        {
        }

        public DbSet<Jogos> Jogos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= NOTE16-S28\\SQLEXPRESS; Database = GamePlays; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true; ");
            }
        }
    }
}
