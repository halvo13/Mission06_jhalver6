using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_jhalver6.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int Movieid { get; set; }
        [Required(ErrorMessage = "The Category is required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "The Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The Year is required")]
        
        public int Year { get; set; }
        [Required(ErrorMessage = "The Director is required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "The Rating is required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
        
    }
}
