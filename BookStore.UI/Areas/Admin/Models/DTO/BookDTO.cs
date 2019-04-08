using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.UI.Areas.Admin.Models.DTO
{
    public class BookDTO : BaseDTO
    {
        [Required(ErrorMessage = "Please enter Book Name")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Please enter Book Description")]
        public string BookDescription { get; set; }
        [Required(ErrorMessage = "Please Choose a Category")]
        public int CategoryID { get; set; }
    }
}