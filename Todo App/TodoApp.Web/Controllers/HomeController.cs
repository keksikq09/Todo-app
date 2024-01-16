using Microsoft.AspNetCore.Mvc;
using Todo.App.Model.Models;
using TodoApp.Data.Repository.IRepository;

namespace Todo_App.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<TodoTask> tasks = _unitOfWork.TodoTask.GetAll(includeProperties:"Category");
        return View(tasks);
    }
}