using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAssignment02.Models
{
    [Table("TblMovie")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
    }
}