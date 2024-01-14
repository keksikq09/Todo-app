using Microsoft.EntityFrameworkCore;
using Todo.App.Model.Models;

namespace TodoApp.Data.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<TodoTask> TodoTasks { get; set; }
    
}