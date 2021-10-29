using System.Data.Entity;

namespace NanatsuNoTaizai.Entity
{
    public class Context
    {
        public DbSet<CharacterEntity> characterEntities { get; set; }
    }
}
