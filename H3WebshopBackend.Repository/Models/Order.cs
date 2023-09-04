using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Item? Item { get; set; }
        [Required]
        public Customer? Customer { get; set; }
        [Required]
        public DateTime? DateTime { get; set; }
    }
}
