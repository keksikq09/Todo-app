using Microsoft.AspNetCore.Mvc;
using Todo.App.Model.Models;
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
        return View();
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