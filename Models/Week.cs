using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Week
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public string Topics { get; set; } 
        public string Dates { get; set; } 
        public double Hours { get; set; }
        public string Image { get; set; }
        public virtual List<Lecture> Lectures { get; set; }
    }
}
