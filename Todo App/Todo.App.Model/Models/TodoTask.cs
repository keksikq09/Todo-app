using System.ComponentModel.DataAnnotations;

namespace Todo.App.Model.Models;

public class TodoTask
{
    [Key] 
    public int Id { get; set; }
    
    [Required] 
    public string Name { get; set; }

    public string Description { get; set; }
}