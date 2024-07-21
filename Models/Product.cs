using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name="Urun Adı")]
        public string Name { get; set; } = null!;

        [Display(Name="Fiyat")]
        [Range(0,1000000)]
        public decimal Price { get; set; }

        [Display(Name="Resim")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        
        [Display(Name="Kategori")]
        [Required]
        public int? CategoryId { get; set; }

    }
}
