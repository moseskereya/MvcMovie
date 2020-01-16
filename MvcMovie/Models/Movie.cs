using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "ReleasedDate")]
        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName ="decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
