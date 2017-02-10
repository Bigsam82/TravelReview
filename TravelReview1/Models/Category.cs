using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReview1.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Travel_Category { get; set; }
        public DateTime Date { get; set; }
        public string Purpose { get; set; }

        public virtual ICollection<Review> Review { get; set; }

    }
}