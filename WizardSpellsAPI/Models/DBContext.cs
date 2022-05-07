using Microsoft.EntityFrameworkCore;
using WizardSpellsAPI;


namespace WizardSpellsAPI.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DbSet<Spell> WizardSpells
        {
            get; set;
        }
        public DbSet<UserComment> Comments
        {
            get; set;
        }
        public DbSet<User> Users
        {
            get; set;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost; database=WizardSpells");
        }





    }
}