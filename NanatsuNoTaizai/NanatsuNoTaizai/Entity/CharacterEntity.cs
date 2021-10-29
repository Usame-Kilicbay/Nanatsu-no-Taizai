using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanatsuNoTaizai.Entity
{
    public class CharacterEntity
    {
        public short CharacterID { get; set; }
        public string CharacterName { get; set; }
        public short CharacterAge { get; set; }
        public int CharacterAbilities { get; set; }
    }
}
