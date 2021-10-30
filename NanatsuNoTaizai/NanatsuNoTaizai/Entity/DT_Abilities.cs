using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NanatsuNoTaizai.Entity
{
    public class DT_Abilities
    {
        [Key]
        public byte AbilityID { get; set; }
        [StringLength(50)]
        public string AbilityName { get; set; }
        public ICollection<DT_Character> Characters { get; set; }
    }
}
