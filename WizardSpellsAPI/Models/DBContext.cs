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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost; database=WizardSpells");
        }


        //Does this go inside these curly brackets?
        public DbSet<UserComment> Comments
        {
            get; set;
        }

    }
}