using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Media
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Lecture")]
        public int LectureId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public virtual Lecture Lecture { get; set; }
    }
}
