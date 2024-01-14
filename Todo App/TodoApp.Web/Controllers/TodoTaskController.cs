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
    
    // GET
    public IActionResult Index()
    {
        IEnumerable<TodoTask> tasks = _unitOfWork.TodoTask.GetAll();
        return View(tasks);
    }
}