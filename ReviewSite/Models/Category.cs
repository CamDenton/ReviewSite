using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewSite.Models
{
    public class Category
    {
        [Key]
        public int CatID { get; set; }
        [Display(Name = "Category:")]
        public string CatName { get; set; }

        [ForeignKey("Review")]
        public int ReviewID { get; set; }
        public virtual Review Review { get; set; }
    }
}