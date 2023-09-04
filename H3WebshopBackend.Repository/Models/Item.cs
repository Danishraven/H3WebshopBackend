using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Models
{
    public class Item
    {
        [Key] 
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public Supplier? Supplier { get; set; }
        [Required]
        public double? Price { get; set; }
    }
}