using System.ComponentModel.DataAnnotations;
using UniMartAPI.DTOs.Product;
using UniMartAPI.Models;

namespace UniMartAPI.DTOs.Category;

public class CategoryResponseDto
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
}

