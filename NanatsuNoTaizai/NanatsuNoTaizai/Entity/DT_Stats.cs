using System.ComponentModel.DataAnnotations;

namespace NanatsuNoTaizai.Entity
{
   public class DT_Stats
    {
        [Key]
        public byte StatisticID { get; set; }
        public int Magic { get; set; }
        public int Strength { get; set; }
        public int Spirit { get; set; }
        public int Power { get; set; }
    }
}
