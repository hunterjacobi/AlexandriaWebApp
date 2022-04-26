using System;
using System.ComponentModel.DataAnnotations;

namespace AlexandriaWebApp.Shared.Models.Category
{
    public class CategoryEdit
    {
        [Required]
        public string Name { get; set; }
    }
}
