using Microsoft.EntityFrameworkCore;

namespace WizardSpellsAPI.Models
{
    public partial class DatabaseContext : DatabaseContext
    {
        public DbSet<WizardSpell> WizardSpells
        {
            get; set;
        }
        protected override voic OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpsql("server=localhost; database=WizardSpells");
        }
    }
}