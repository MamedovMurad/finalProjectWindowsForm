using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace finalProjectWindowsForm.Models
{
    public class Order
    {
        [ Key]
        public int OrderID { get; set; }
        [Required]
        public Management Management { get; set; }
        [Required]
        public float Money { get; set; }
        [Required]
        public System.Nullable<DateTime> BookReturnededDate { get; set; }
    }
}
