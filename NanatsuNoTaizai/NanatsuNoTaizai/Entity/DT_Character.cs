using System;
using System.ComponentModel.DataAnnotations;

namespace NanatsuNoTaizai.Entity
{
    public class DT_Character
    {
        [Key]
        public byte CharacterID { get; set; }

        [StringLength(50)]
        public string CharacterName { get; set; }
        
        public short CharacterAge { get; set; }
    }
}
