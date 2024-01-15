using Todo.App.Model.Models;

namespace TodoApp.Data.Repository.IRepository;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category obj);
}