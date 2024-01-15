using Microsoft.AspNetCore.Mvc;
using Todo.App.Model.Models;
using TodoApp.Data.Repository.IRepository;

namespace Todo_App.Controllers;

public class CategoryController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    
    public CategoryController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    // GET
    public IActionResult Index()
    {
        IEnumerable<Category> categories = _unitOfWork.Category.GetAll();
        return View(categories);
    }
}