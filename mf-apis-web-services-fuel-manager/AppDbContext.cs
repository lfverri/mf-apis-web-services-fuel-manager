using mf_apis_web_services_fuel_manager.Models;
using Microsoft.EntityFrameworkCore;

namespace mf_apis_web_services_fuel_manager
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurando o tipo de dado para o campo 'Valor'
            modelBuilder.Entity<Consumo>()
                .Property(c => c.Valor)
                .HasColumnType("decimal(18,2)");

            // Configurações adicionais para outras entidades, se necessário
        }
    }
}
 