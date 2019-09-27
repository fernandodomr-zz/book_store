using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.MVC.ViewModels
{
    public class BookViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, inform the title")]
        [MaxLength(100, ErrorMessage = "Max of {1} chars")]
        [MinLength(3, ErrorMessage = "Min of {1} chars")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, inform the author")]
        [MaxLength(100, ErrorMessage = "Max of {1} chars")]
        [MinLength(3, ErrorMessage = "Min of {1} chars")]
        public string Author { get; set; }

        [MaxLength(50, ErrorMessage = "Max of {1} chars")]
        [MinLength(3, ErrorMessage = "Min of {1} chars")]
        public string ISBN { get; set; }
    }
}