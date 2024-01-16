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
    
    public IActionResult Upsert(int? id)
    {
        Category category = new Category();
        if (id == null)
        {
            return View(category);
        }
        category = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);
        
        if (category == null)
        {
            return NotFound();
        }
        return View(category);
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Upsert(Category category)
    {
        if (ModelState.IsValid)
        {
            if (category.Id == 0)
            {
                _unitOfWork.Category.Add(category);
            }
            else
            {
                _unitOfWork.Category.Update(category);
            }
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        
        return View(category);
    }

    [HttpPost]
    public ActionResult DeleteCategory(int id)
    {
        Category category = _unitOfWork.Category.GetFirstOrDefault(c => c.Id == id);

        if (category == null)
        {
            return Json(new { success = false});
        }

        _unitOfWork.Category.Remove(category);
        _unitOfWork.Save();
        return Json(new { success = true });
    }
}