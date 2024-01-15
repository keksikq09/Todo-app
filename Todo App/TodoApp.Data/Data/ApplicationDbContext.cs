using Microsoft.EntityFrameworkCore;
using Todo.App.Model.Models;

namespace TodoApp.Data.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<TodoTask> TodoTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoTask>().HasData(
            new TodoTask()
            {
                Id = 1,
                Name = "Call Mom"
            },
            new TodoTask()
            {
                Id = 2,
                Name = "Do HomeWork"
            },
            new TodoTask()
            {
                Id = 3,
                Name = "Learn c#"
            }
        );
    }
}