using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Todo.App.Model.Models;

namespace Todo.App.Model.ViewModels;

public class TodoTaskVM
{
    public TodoTask Task { get; set; }
    [ValidateNever]
    public IEnumerable<SelectListItem> CategoryList { get; set; }
}