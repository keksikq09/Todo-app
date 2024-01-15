using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Todo.App.Model.Models;

public class TodoTask
{
    [Key] 
    public int Id { get; set; }
    
    [Required] 
    public string Name { get; set; }
    
    [Required]
    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    [ValidateNever]
    public Category Category { get; set; }
}