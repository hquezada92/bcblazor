using System.ComponentModel.DataAnnotations;

namespace blazorbcamp.models.LearnBlazor;

public class ProductModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; } = 0.00;
    public bool IsActive { get; set; }
}