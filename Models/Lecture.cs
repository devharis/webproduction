using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Lecture
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Week")]
        public int WeekId { get; set; }
        public virtual Week Week { get; set; }
        public virtual List<Round> Round { get; set; }
        public virtual List<Media> Medias { get; set; }
    }
}
