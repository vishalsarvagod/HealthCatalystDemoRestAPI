using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalystDemoRestAPI.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name can only be 50 characters")]
        public string Name { get; set; }
    }
}
