using System.Data.Entity;

namespace NanatsuNoTaizai.Entity
{
    public class Context : DbContext
    {
        public DbSet<DT_Character> DT_Characters { get; set; }
    }
}
