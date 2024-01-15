using System.ComponentModel.DataAnnotations;

namespace Todo.App.Model.Models;

public class Category
{
    [Key] 
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
}