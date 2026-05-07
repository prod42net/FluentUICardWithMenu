using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class MyBaseModel
{
    public long Id { get; set; }
    [MaxLength(100)]
    public string Title { get; set; } = "";
    [MaxLength(255)]
    public string Description { get; set; } = "";
    [MaxLength(255)]
    public string UserId { get; set; } = "";
    [MaxLength(10)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    [MaxLength(10)]
    public string CustomColor { get; set; } = "";
    public bool IsFavorite { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
}