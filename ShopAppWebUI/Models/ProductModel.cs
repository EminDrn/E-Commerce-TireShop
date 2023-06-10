using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppWebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        //[Required]
        //[StringLength(60,MinimumLength =10,ErrorMessage ="Ürün ismi minimum 10 karakter ve maksimmum 60 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(100000, MinimumLength = 20, ErrorMessage = "Ürün ismi minimum 20 karakter ve maksimmum 100000 karakter olmalıdır.")]
        public string Description { get; set; }
        [Required (ErrorMessage ="fiyat belirtiniz")]
        [Range(1,10000)]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories{ get; set; }
    }
}
