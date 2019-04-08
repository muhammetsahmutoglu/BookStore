using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.UI.Areas.Admin.Models.DTO
{
    public class CategoryDTO : BaseDTO
    {
        [Required(ErrorMessage = "Please enter Category Name")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Please enter Category Description")]
        public string CategoryDescription { get; set; }
    }
}