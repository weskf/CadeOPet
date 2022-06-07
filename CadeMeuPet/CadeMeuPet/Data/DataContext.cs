using CadeMeuPet.Data.Mapping;
using CadeMeuPet.Model;
using Microsoft.EntityFrameworkCore;

namespace CadeMeuPet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new AccountMap());
            model.ApplyConfiguration(new PetMap());
            model.ApplyConfiguration(new BreedMap());
            model.ApplyConfiguration(new ColorMap());
            model.ApplyConfiguration(new SizeMap());
            model.ApplyConfiguration(new StatusMap());
            model.ApplyConfiguration(new ImageMap());
        }
    }
}
