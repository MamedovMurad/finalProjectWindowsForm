using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace finalProjectWindowsForm.Models
{
   public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [MaxLength(50)]
        public string BookName { get; set; }

        [Required]
        [MaxLength(50)]
        public string PublisherName { get; set; }

        [Required]
        [MaxLength(50)]
        public string BookGenre{ get; set; }
        [Required]
        public float BookPrice { get; set; }
    
    }
}
