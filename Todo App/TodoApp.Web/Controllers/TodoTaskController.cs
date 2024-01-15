using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Todo.App.Model.Models;
using Todo.App.Model.ViewModels;
using TodoApp.Data.Repository.IRepository;

namespace Todo_App.Controllers;

public class TodoTaskController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public TodoTaskController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Create()
    {
        TodoTaskVM task = new()
        {
            Task = new(),
            CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            }),
        };
        return View(task);
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(TodoTask task)
    {
        if (!ModelState.IsValid)
            return RedirectToAction("Index" , "Home");
        
        _unitOfWork.TodoTask.Add(task);
        _unitOfWork.Save();
        
        return RedirectToAction("Index" , "Home");
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int? id)
    {
        TodoTask task = _unitOfWork.TodoTask.GetFirstOrDefault(t => t.Id == id);
        
        if (task == null)
            return RedirectToAction("Index" , "Home");
        
        _unitOfWork.TodoTask.Remove(task);
        _unitOfWork.Save();
        
        return RedirectToAction("Index" , "Home");
    }
}