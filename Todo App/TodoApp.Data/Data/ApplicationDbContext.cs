using Microsoft.EntityFrameworkCore;
using Todo.App.Model.Models;

namespace TodoApp.Data.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<TodoTask> TodoTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Name = "Work"
            },
            new Category()
            {
                Id = 2,
                Name = "Home"
            },
            new Category()
            {
                Id = 3,
                Name = "School"
            }
        );
        
        modelBuilder.Entity<TodoTask>().HasData(
            new TodoTask()
            {
                Id = 1,
                Name = "Call Mom",
                CategoryId = 1
            },
            new TodoTask()
            {
                Id = 2,
                Name = "Do HomeWork",
                CategoryId = 2
            },
            new TodoTask()
            {
                Id = 3,
                Name = "Learn c#",
                CategoryId = 3
            }
        );
    }
}