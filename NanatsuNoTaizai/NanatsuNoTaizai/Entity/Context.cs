using System.Data.Entity;

namespace NanatsuNoTaizai.Entity
{
    public class Context : DbContext
    {
        public DbSet<DT_Character> DT_Characters { get; set; }
        public DbSet<DT_Abilities> DT_Abilities { get; set; }
        public DbSet<DT_Stats> DT_Stats { get; set; }
    }
}
