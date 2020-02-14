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
        public int PurchaseID { get; set; }
        [Required]
        public Managment Managment { get; set; }
        [Required]
        public float Money { get; set; }
        [Required]
        public System.Nullable<DateTime> BookReturnededDate { get; set; }
    }
}
