using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Models;

namespace TodoApi.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options):base(options)
        {}

        public DbSet<TodoItem> TodoItems {get;set;}
    }
}