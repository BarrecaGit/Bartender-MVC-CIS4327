using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Store.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        public string Line1 { get; set; }   // Phone Number
        public string Line2 { get; set; }   // Email

    }
}
