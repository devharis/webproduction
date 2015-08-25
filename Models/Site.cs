using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Site
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ett namn krävs"), MaxLength(50, ErrorMessage = "Namnet får max vara 50 täcken i längd")]
        public string Name { get; set; }
        [Required(ErrorMessage = "En url krävs"), MaxLength(100, ErrorMessage = "Urlen får max vara 100 täcken i längd")]
        public string Url { get; set; }
    }
}
