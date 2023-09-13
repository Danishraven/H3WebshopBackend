using H3WebshopBackend.Repository.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Frontend.Models
{
    public class Order : IAddress
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Item? Item { get; set; }
        [Required]
        public Customer? Customer { get; set; }
        [Required]
        public DateTime? DateTime { get; set; }

        [Required]
        public string? Address { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? ZipCode { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        public string? Country { get; set; }
    }
}
