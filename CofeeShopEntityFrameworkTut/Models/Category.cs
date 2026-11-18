using System;
using System.ComponentModel.DataAnnotations;

namespace CofeeShopEntityFrameworkTut.Models;

internal class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public List<Product> Products { get; set; }


}
