using System;
using System.ComponentModel.DataAnnotations;

namespace FoodHub.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public bool IsActive { get; set; }
    }
}
