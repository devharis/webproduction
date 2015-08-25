using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Round
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Speaker { get; set; }
        public string Description { get; set; }
        public TimeSpan Time { get; set; }
        public double Hours { get; set; }
        [ForeignKey("Lecture")]
        public int LectureId { get; set; }
        public virtual Lecture Lecture { get; set; }
    }
}
